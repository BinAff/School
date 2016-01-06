﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Threading.Tasks;
using System.Transactions;

namespace BinAff.Core
{

    public abstract class Crud : ICrud, IActivator, IFactory
    {

        private readonly Boolean isReadParallel = true;
        private readonly Boolean isWriteParallel = false;

        private readonly String logPath = Environment.CurrentDirectory + ConfigurationManager.AppSettings["ExceptionPath"];
        private Utility.Log.Server logWritter;

        protected Action actionType;
        private List<Crud> dependentChildren; //Child class will hold parent reference
        private List<Crud> independentChildren; //Parent class will hold child reference

        private Boolean isMultiValuedChild; //If the child is getting added using AddChildren();
        //In case of AddChildren(), initially data will be null for read operation.
        //So there is secondtime call of CreateChildren() to protect infinite loop
        //this flag is used.
        private Boolean isChildrenCreatedAlready;

        #region Properties

        private Data data;
        public Data Data
        {
            get
            {
                return this.data;
            }
            protected set
            {
                if (this.data != value)
                {
                    this.data = value;
                    if (this.dataAccess != null) this.dataAccess.Data = value;
                    if (this.validator != null) this.validator.Data = value;
                }
            }
        }

        private Data parentData;
        public Data ParentData
        {
            get
            {
                return this.parentData;
            }
            set
            {
                if (this.parentData != value)
                {
                    this.parentData = value;
                    if (this.dataAccess != null) this.dataAccess.ParentData = value;
                    if (this.validator != null) this.validator.ParentData = value;
                }
            }
        }

        private Dao dataAccess;
        /// <summary>
        /// Object for data access from database
        /// </summary>
        public Dao DataAccess
        {
            get
            {
                return this.dataAccess;
            }
            set
            {
                this.dataAccess = value;
                if (this.dataAccess != null) this.dataAccess.Server = this;
            }
        }

        private Validator validator;
        /// <summary>
        /// Object for validation
        /// </summary>
        public Validator Validator
        {
            get
            {
                return this.validator;
            }
            set
            {
                this.validator = value;
                if (this.validator != null) this.validator.Server = this;
            }
        }

        /// <summary>
        /// Name of the component
        /// </summary>
        public String Name { get; set; }

        /// <summary>
        /// Is skiping CRUD
        /// </summary>
        public Boolean IsSkip { get; set; }

        /// <summary>
        /// Is skiping create, update and delete
        /// </summary>
        public Boolean IsReadOnly { get; set; }

        /// <summary>
        /// Is only reading own data not child data
        /// </summary>
        public Boolean IsReadOwnData { get; set; }

        /// <summary>
        /// Kind of child with respect to parent
        /// </summary>
        public ChildType Type { get; set; }

        #endregion

        public Crud(Data data)
        {
            this.isReadParallel = ConfigurationManager.AppSettings["IsReadParallel"] == "Y";
            this.isWriteParallel = ConfigurationManager.AppSettings["IsWriteParallel"] == "Y";
            this.logWritter = new Utility.Log.Server(logPath, Utility.Log.Server.Type.Daily);
            this.Data = data;
            this.dependentChildren = new List<Crud>();
            this.independentChildren = new List<Crud>();
            this.isChildrenCreatedAlready = false;
            this.Compose();
        }

        #region Children

        /// <summary>
        /// Add child component to parent component
        /// </summary>
        /// <param name="child">Child component</param>
        protected Data AddChild(Crud child)
        {
            if (this.actionType == Action.Delete && child.Data == null) return null;
            //Assign parent data
            child.ParentData = this.Data;
            child.dataAccess.ParentData = this.Data;
            if (child.validator != null) child.validator.ParentData = this.Data;
            
            if (this.actionType == Action.Read)
            {
                if (child.Data == null || child.Data.Id == 0)
                {
                    if (child.Type == ChildType.Dependent)
                    {
                        child.Data = (child as IFactory).CreateDataObject();
                        child.dataAccess.Data = child.Data;
                        if (child.validator != null) child.validator.Data = child.Data;
                        child.dataAccess.ReadForParent();
                    }
                }
            }
            else if (child.Data == null)
            {
                if (this.actionType == Action.Create || this.actionType == Action.Update)
                {
                    child.validator = null;
                    child.dataAccess = null;
                    child = null;
                }
            }

            if (child != null && child.Data != null)
            {
                if (child.Type == ChildType.Dependent)
                {
                    this.dependentChildren.Add(child);
                }
                else
                {
                    this.independentChildren.Add(child);
                }
                return child.Data;
            }
            return null;
        }

        /// Add children component to parent component
        /// </summary>
        /// <param name="schema">Child component</param>
        /// <param name="dataList"></param>
        /// <returns></returns>
        protected List<Data> AddChildren(Crud schema, List<Data> dataList)
        {
            if (dataList == null)
            {
                Crud child = (schema as IFactory).CreateInstance(null);
                child.Type = schema.Type;
                child.IsReadOnly = schema.IsReadOnly;
                child.IsSkip = schema.IsSkip;
                child.ParentData = this.Data;

                if (this.actionType == Action.Read)
                {
                    if (child.Type == ChildType.Dependent)
                    {
                        child.Data = (child as IFactory).CreateDataObject();
                        child.dataAccess.Data = child.Data;
                        if (child.validator != null) child.validator.Data = child.Data;
                        child.dataAccess.ReadForParent();
                        if (!this.isChildrenCreatedAlready)
                        {
                            this.isChildrenCreatedAlready = true;
                            this.CreateChildren();
                        }
                    }
                }
            }
            if (dataList != null && dataList.Count > 0)
            {
                for (Int32 i = 0; i < dataList.Count; i++)
                {
                    Crud child = schema.CreateInstance(dataList[i]);
                    child.Type = schema.Type;
                    child.IsReadOnly = schema.IsReadOnly;
                    child.IsSkip = schema.IsSkip;
                    child.ParentData = schema.ParentData;
                    child.isMultiValuedChild = true;
                    this.AddChild(child);
                }
                return dataList;
            }
            return null;
        }

        #endregion

        #region CRUD

        protected virtual Data GetDataForParent()
        {
            return this.dataAccess.GetDataFromParentData();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private ReturnObject<Boolean> SaveInternal()
        {
            ReturnObject<Boolean> retObj = new ReturnObject<Boolean>
            {
                Value = true,
                MessageList = new List<Message>()
            };

            this.actionType = this.Data.Id == 0 ? Action.Create : Action.Update;
            this.CreateChildren();

            //Validate
            retObj.MessageList = this.Validate();
            if (retObj.HasError()) retObj.Value = false;
            if (!retObj.Value) return retObj;

            using (TransactionScope T = new TransactionScope(TransactionScopeOption.Required, new TimeSpan(1, 0, 0)))
            {
                //Manage hook before
                if (!ManipulateReturnObject(retObj, this.actionType == Action.Create ? this.CreateBefore() : this.UpdateBefore()).Value) return retObj;

                //Update manipulation of children
                if (this.actionType == Action.Update)
                {
                    this.PrepareChildrenForUpdate();

                    //Delete children linking data for update
                    if (this.independentChildren.Exists((p) => p.actionType == Action.Delete))
                    {
                        this.ManipulateReturnObject(retObj, this.dataAccess.DeleteBefore() ?
                            new ReturnObject<Boolean>
                            {
                                Value = true,
                                MessageList = new List<Message>
                                {
                                    new Message(String.IsNullOrEmpty(this.Name)? "Children link deleted." : "Children link for " +  this.Name + " deleted.", Message.Type.Information)
                                },
                            } :
                            new ReturnObject<Boolean>
                            {
                                Value = false,
                                MessageList = new List<Message>
                                {
                                    new Message(String.IsNullOrEmpty(this.Name)? "Children link deletion failed." : "Children link deletion for " +  this.Name + " failed.", Message.Type.Error)
                                },
                            });
                        if (retObj.HasError()) return retObj;
                    }
                }

                //Save independent children
                foreach (ICrud child in this.independentChildren)
                {
                    if (!(child as Crud).IsReadOnly && !this.SaveOrDelete(child, retObj).Value) return retObj;
                }

                //Save own
                if (!ManipulateReturnObject(retObj, this.actionType == Action.Create ? this.Create() : this.Update()).Value) return retObj;

                //Save dependent children
                foreach (ICrud child in this.dependentChildren)
                {
                    if (!(child as Crud).IsReadOnly && !this.SaveOrDelete(child, retObj).Value) return retObj;
                }

                ////Create link data in case of update
                //if (this.actionType == Action.Update)
                //{
                //    if (this.independentChildren.Exists((p) => p.actionType == Action.Create))
                //    {
                //        this.ManipulateReturnObject(retObj, this.dataAccess.CreateAfter()?
                //            new ReturnObject<Boolean>
                //            {
                //                Value = true,
                //                MessageList = new List<Message>
                //                {
                //                    new Message(String.IsNullOrEmpty(this.Name)? "Children link created." : "Children link for " +  this.Name + " created.", Message.Type.Information)
                //                },
                //            } :
                //            new ReturnObject<Boolean>
                //            {
                //                Value = false,
                //                MessageList = new List<Message>
                //                {
                //                    new Message(String.IsNullOrEmpty(this.Name)? "Children link creation failed." : "Children link creation for " +  this.Name + " failed.", Message.Type.Error)
                //                },
                //            });
                //        if (retObj.HasError()) return retObj;
                //    }
                //}

                //Manage hook after
                if (!ManipulateReturnObject(retObj, this.actionType == Action.Create ? this.CreateAfter() : this.UpdateAfter()).Value) return retObj;
                T.Complete();
            }

            return retObj;
        }

        private void PrepareChildrenForUpdate()
        {
            //Mark Id all existing children to 0, such that it will insert only
            foreach (Crud child in this.dependentChildren)
            {
                if (child.isMultiValuedChild && !child.IsReadOnly)
                {
                    child.Data.Id = 0;
                    child.actionType = Action.Create;
                }
            }
            foreach (Crud child in this.independentChildren)
            {
                if (child.isMultiValuedChild && !child.IsReadOnly)
                {
                    child.Data.Id = 0;
                    child.actionType = Action.Create;
                }
            }

            //Prepare children for deletion
            Data d = (this as IFactory).CreateDataObject();
            d.Id = this.Data.Id;
            Crud me = (this as IFactory).CreateInstance(d);
            me.ReadInternal();
            me.dependentChildren.Clear();
            me.independentChildren.Clear();
            me.actionType = Action.Delete;
            me.CreateChildren();
            //Map deletable dependent children
            foreach (Crud child in me.dependentChildren)
            {
                if (child.isMultiValuedChild)
                {
                    child.Data.IsDeletable = true;
                    child.actionType = Action.Delete;
                    this.dependentChildren.Insert(0, child);
                }
            }
            //Map deletable independent children
            foreach (Crud child in me.independentChildren)
            {
                if (child.isMultiValuedChild)
                {
                    child.Data.IsDeletable = true;
                    child.actionType = Action.Delete;
                    this.independentChildren.Insert(0, child);
                }
            }
        }

        /// <summary>
        /// Validate component as per validation defined in validator
        /// Validation will be ignored if validator is not declared
        /// </summary>
        /// <returns></returns>
        private List<Message> Validate()
        {
            List<Message> valMsgLst = new List<Message>();
            IValidator val = this.validator;
            if (this.validator != null) valMsgLst = val.Validate();

            //Validate independent children
            this.RunForEach<Crud>(this.isWriteParallel, this.independentChildren, (p) =>
            {
                if (!p.IsSkip && !p.IsReadOnly && p.validator != null)
                {
                    val = p.validator;
                    valMsgLst.AddRange(val.Validate());
                }
                return true;
            });
            //foreach (Crud child in this.independentChildren)
            //{
            //    if (!child.IsSkip && !child.IsReadOnly && child.validator != null)
            //    {
            //        val = child.validator;
            //        valMsgLst.AddRange(val.Validate());
            //    }
            //}

            //Validate independent children
            this.RunForEach<Crud>(this.isWriteParallel, this.dependentChildren, (p) =>
            {
                if (!p.IsSkip && !p.IsReadOnly && p.validator != null)
                {
                    val = p.validator;
                    valMsgLst.AddRange(val.Validate());
                }
                return true;
            });
            //foreach (Crud child in this.dependentChildren)
            //{
            //    if (!child.IsSkip && !child.IsReadOnly && child.validator != null)
            //    {
            //        val = child.validator;
            //        valMsgLst.AddRange(val.Validate());
            //    }
            //}
            return valMsgLst;
        }

        /// <summary>
        /// Save or delete child
        /// </summary>
        /// <remarks>
        /// In case of parent updation, child may be deleted or saved (Created or Updated)
        /// </remarks>
        /// <param name="crud">CRUD engine</param>
        /// <param name="retObj">Return object</param>
        /// <returns></returns>
        private ReturnObject<Boolean> SaveOrDelete(ICrud crud, ReturnObject<Boolean> retObj)
        {
            if (!(crud as Crud).IsSkip && (crud as Crud).Data != null)
            {
                if (((crud as Crud).actionType == Action.Delete && this.actionType == Action.Update))
                {
                    if (!this.ManipulateReturnObject(retObj, crud.Delete()).Value) return retObj;
                }
                else
                {
                    if (!ManipulateReturnObject(retObj, crud.Save()).Value) return retObj;
                }
            }
            return retObj;
        }

        /// <summary>
        /// Insert a new record
        /// </summary>
        /// <returns></returns>
        protected virtual ReturnObject<Boolean> Create()
        {
            ReturnObject<Boolean> retObj = new ReturnObject<Boolean>
            {
                MessageList = new List<Message>()
            };

            if (!this.IsSkip && !this.IsReadOnly)
            {
                retObj.Value = this.dataAccess.Create();
                Message msg = new Message();
                if (retObj.Value)
                {
                    msg.Description = String.IsNullOrEmpty(this.Name) ? "Data successfully inserted." : this.Name + " data successfully inserted.";
                    msg.Category = Message.Type.Information;
                }
                else
                {
                    msg.Description = String.IsNullOrEmpty(this.Name) ? "Data insertion failed." : this.Name + " data insertion failed.";
                    msg.Category = Message.Type.Error;
                }
                retObj.MessageList.Add(msg);
            }

            return retObj;
        }

        /// <summary>
        /// Update existing record
        /// </summary>
        /// <returns></returns>
        protected virtual ReturnObject<Boolean> Update()
        {
            ReturnObject<Boolean> retObj = new ReturnObject<Boolean>
            {
                MessageList = new List<Message>()
            };

            if (!this.IsSkip && !this.IsReadOnly)
            {
                retObj.Value = this.dataAccess.Update();
                Message msg = new Message();
                if (retObj.Value)
                {
                    msg.Description = String.IsNullOrEmpty(this.Name) ? "Data successfully updated." : this.Name + " data successfully updated.";
                    msg.Category = Message.Type.Information;
                }
                else
                {
                    msg.Description = String.IsNullOrEmpty(this.Name) ? "Data updation failed." : this.Name + " data updation failed.";
                    msg.Category = Message.Type.Error;
                }
                retObj.MessageList.Add(msg);
            }

            return retObj;
        }

        private ReturnObject<Boolean> DeleteInternal()
        {
            ReturnObject<Boolean> retObj = new ReturnObject<Boolean>
            {
                Value = true,
                MessageList = new List<Message>()
            };

            this.ReadInternal();
            this.actionType = Action.Delete;
            this.dependentChildren.Clear();
            this.independentChildren.Clear();
            this.CreateChildren();

            if (this.Data.Id != 0) //There is data to delete
            {
                using (TransactionScope T = new TransactionScope(TransactionScopeOption.Required, new TimeSpan(1, 0, 0)))
                {
                    //Manage before hook
                    if (!this.ManipulateReturnObject(retObj, this.DeleteBefore()).Value) return retObj;

                    //Check the data is deletable or not
                    if (!this.ManipulateReturnObject(retObj, this.validator.IsDeletable()).Value) return retObj;

                    //Delete own with all children
                    if (!this.ManipulateReturnObject(retObj, this.Delete()).Value) return retObj;

                    //Manage after hook
                    if (!this.ManipulateReturnObject(retObj, this.DeleteAfter()).Value) return retObj;
                    T.Complete();
                }
            }

            return retObj;
        }

        /// <summary>
        /// Delete own data with all children data
        /// </summary>
        /// <returns></returns>
        protected virtual ReturnObject<Boolean> Delete()
        {
            ReturnObject<Boolean> retObj = new ReturnObject<Boolean>
            {
                Value = true,
                MessageList = new List<Message>()
            };

            //Delete dependent children
            if (!ManipulateReturnObject(retObj, this.DeleteChildren(this.dependentChildren)).Value) return retObj;

            //Delete own
            if (!ManipulateReturnObject(retObj, this.DeleteOwn()).Value) return retObj;

            //Delete independent children
            if (!ManipulateReturnObject(retObj, this.DeleteChildren(this.independentChildren)).Value) return retObj;

            return retObj;
        }

        /// <summary>
        /// Delete own data
        /// </summary>
        /// <returns></returns>
        protected virtual ReturnObject<Boolean> DeleteOwn()
        {
            if (!this.IsSkip && !this.IsReadOnly && this.Data != null)
            {
                ReturnObject<Boolean> retObj = new ReturnObject<Boolean>
                {
                    Value = this.dataAccess.Delete(),
                    MessageList = new List<Message>()
                };
                Message msg = new Message();
                if (retObj.Value)
                {
                    msg.Description = String.IsNullOrEmpty(this.Name) ? "Data successfully deleted." : this.Name + " data successfully deleted.";
                    msg.Category = Message.Type.Information;
                }
                else
                {
                    msg.Description = String.IsNullOrEmpty(this.Name) ? "Data deletion failed." : this.Name + " data deletion failed.";
                    msg.Category = Message.Type.Error;
                }
                retObj.MessageList.Add(msg);
                return retObj;
            }

            //Data not deleted due to rule
            return new ReturnObject<Boolean>
            {
                Value = true
            };
        }

        /// <summary>
        /// Delete chldren data
        /// </summary>
        /// <param name="children"></param>
        /// <returns></returns>
        protected virtual ReturnObject<Boolean> DeleteChildren(List<Crud> children)
        {
            ReturnObject<Boolean> retObj = new ReturnObject<Boolean>
            {
                Value = true,
                MessageList = new List<Message>()
            };
            this.RunForEach<Crud>(this.isWriteParallel, children, (p) =>
            {
                if (!p.IsSkip && !p.IsReadOnly && p.Data != null)
                {
                    if (!ManipulateReturnObject(retObj, p.DeleteInternal()).Value) return true;
                }
                return true;
            });
            //if (this.isWriteParallel)
            //{
            //    Parallel.ForEach<ICrud>(children, child =>
            //    {
            //        if (!(child as Crud).IsSkip && !(child as Crud).IsReadOnly && (child as Crud).Data != null)
            //        {
            //            if (!ManipulateReturnObject(retObj, child.Delete()).Value) return;
            //        }
            //    });
            //}
            //else
            //{
            //    foreach (ICrud child in children)
            //    {
            //        if (!(child as Crud).IsSkip && !(child as Crud).IsReadOnly && (child as Crud).Data != null)
            //        {
            //            if (!ManipulateReturnObject(retObj, child.Delete()).Value) return retObj;
            //        }
            //    }
            //}
            return retObj;
        }

        private ReturnObject<Data> ReadInternal()
        {
            ReturnObject<Data> retObj = new ReturnObject<Data>
            {
                Value = this.Data,
                MessageList = new List<Message>(),
            };

            this.actionType = Action.Read;

            if (this.Data.Id != 0) //There is data to read
            {
                //Manage before hook
                if (retObj.MergeMessageList(this.ReadBefore()).HasError()) return retObj;

                //Read own
                if (retObj.MergeMessageList(this.Read()).HasError()) return retObj;

                //Manage after hook
                if (retObj.MergeMessageList(this.ReadAfter()).HasError()) return retObj;
            }

            return retObj;
        }

        protected virtual ReturnObject<Data> Read()
        {
            //Read own
            ReturnObject<Data> retObj = ReadOwn();

            if (!this.IsReadOwnData)
            {
                //Create children
                this.CreateChildren();
                //Read dependent
                this.RunForEach<Crud>(this.isReadParallel, this.dependentChildren, (p) =>
                {
                    retObj = this.ReadChild(p as ICrud, retObj);
                    return true;
                });

                //Read independent
                this.RunForEach<Crud>(this.isReadParallel, this.independentChildren, (p) =>
                {
                    retObj = this.ReadChild(p as ICrud, retObj);
                    return true;
                });
            }

            return retObj;
        }

        protected virtual ReturnObject<Data> ReadOwn()
        {
            ReturnObject<Data> retObj = new ReturnObject<Data>();
            if (!this.IsSkip && this.Data.Id != 0)//Data is not holding anything
            {
                retObj.Value = this.dataAccess.Read();
            }

            if (retObj.Value == null) retObj.MessageList = new List<Message> { new Message("No data found for " + this.Name, Message.Type.Information) };

            return retObj;
        }

        private ReturnObject<Data> ReadChild(ICrud child, ReturnObject<Data> retObj)
        {
            try
            {
                using (ReturnObject<Data> temp = child.Read())
                {
                    if (temp.MessageList != null && temp.MessageList.Count > 0)
                    {
                        if (retObj.MessageList == null) retObj.MessageList = new List<Message>();
                        retObj.MessageList.AddRange(temp.MessageList);
                    }
                }
                return retObj;
            }
            catch (Exception ex)
            {
                this.logWritter.Write(ex, "Module: " + (child as Crud).Name,
                    "Server Type     : " + (child as Crud).ToString() + Environment.NewLine +
                    "Data Type       : " + (child as Crud).Data.ToString() + Environment.NewLine +
                    "Data Access Type: " + (child as Crud).dataAccess.ToString() + Environment.NewLine + Environment.NewLine +
                    "Data            : " + BinAff.Utility.Serializer.Serialize(this.Data));
                throw;
            }
        }

        protected virtual ReturnObject<List<Data>> ReadAll()
        {
            ReturnObject<List<BinAff.Core.Data>> retList = new ReturnObject<List<BinAff.Core.Data>>
            {
                Value = (this.dataAccess as Dao).ReadAll()
            };
            if (!this.IsReadOwnData)
            {
                this.RunForEach<BinAff.Core.Data>(this.isReadParallel, retList.Value, (p) =>
                {
                    ICrud server = this.CreateInstance(p);
                    server.Read();
                    return true;
                });
            }
            return retList;
        }

        protected virtual ReturnObject<List<Data>> Read(List<Data> dataList)
        {
            ReturnObject<List<Data>> retList = new ReturnObject<List<Data>>()
            {
                Value = new List<Data>(),
                MessageList = new List<Message>(),
            };

            if (this.isReadParallel)
            {
                Parallel.ForEach<BinAff.Core.Data>(dataList, data =>
                {
                    this.dataAccess.Data = data;
                    ReturnObject<BinAff.Core.Data> ret = (this.CreateInstance(data) as ICrud).Read();
                    if (ret.HasError())
                    {
                        retList.MessageList.AddRange(ret.MessageList);
                        return;
                    }
                    retList.Value.Add(ret.Value);
                });
            }
            else
            {
                foreach (Data data in dataList)
                {
                    ICrud crud = this.CreateInstance(data);
                    this.dataAccess.Data = data;
                    ReturnObject<BinAff.Core.Data> ret = crud.Read();
                    if (ret.HasError())
                    {
                        return new ReturnObject<List<Data>>
                        {
                            MessageList = ret.MessageList,
                        };
                    }
                    retList.Value.Add(ret.Value);
                }
            }

            return retList;
        }

        #endregion

        #region Activator

        private ReturnObject<Boolean> Activate()
        {
            ReturnObject<Boolean> retObj = new ReturnObject<Boolean>
            {
                MessageList = new List<Message>()
            };

            if (!this.IsSkip && !this.IsReadOnly)
            {
                retObj.Value = this.dataAccess.UpdateActivationStatus(true);
                Message msg = new Message();
                if (retObj.Value)
                {
                    msg.Description = String.IsNullOrEmpty(this.Name) ? "Data successfully activated." : this.Name + " data successfully activated.";
                    msg.Category = Message.Type.Information;
                }
                else
                {
                    msg.Description = String.IsNullOrEmpty(this.Name) ? "Data activation failed." : this.Name + " data activation failed.";
                    msg.Category = Message.Type.Error;
                }
                retObj.MessageList.Add(msg);
            }

            return retObj;
        }

        private ReturnObject<Boolean> Deactivate()
        {
            ReturnObject<Boolean> retObj = new ReturnObject<Boolean>
            {
                MessageList = new List<Message>()
            };

            if (!this.IsSkip && !this.IsReadOnly)
            {
                retObj.Value = this.dataAccess.UpdateActivationStatus(false);
                Message msg = new Message();
                if (retObj.Value)
                {
                    msg.Description = String.IsNullOrEmpty(this.Name) ? "Data successfully deactivated." : this.Name + " data successfully deactivated.";
                    msg.Category = Message.Type.Information;
                }
                else
                {
                    msg.Description = String.IsNullOrEmpty(this.Name) ? "Data deactivation failed." : this.Name + " data deactivation failed.";
                    msg.Category = Message.Type.Error;
                }
                retObj.MessageList.Add(msg);
            }

            return retObj;
        }

        private ReturnObject<List<Data>> ReadAllActivate()
        {
            ReturnObject<List<BinAff.Core.Data>> retList = new ReturnObject<List<BinAff.Core.Data>>
            {
                Value = (this.dataAccess as Dao).ReadAllActivate()
            };
            if (!this.IsReadOwnData)
            {
                this.RunForEach<BinAff.Core.Data>(this.isReadParallel, retList.Value, (p) =>
                {
                    ICrud server = this.CreateInstance(p);
                    server.Read();
                    return true;
                });
            }
            return retList;
        }

        #endregion

        #region Mandatory Hook

        protected abstract void Compose();

        #endregion

        #region IFactory

        public abstract Data CreateDataObject();

        public abstract Crud CreateInstance(Data data);

        #endregion

        #region Optional Hook

        /// <summary>
        /// Create children component list
        /// </summary>
        protected virtual void CreateChildren()
        {

        }

        protected virtual void FindChildrenData()
        {

        }

        protected virtual ReturnObject<Boolean> CreateBefore()
        {
            return new ReturnObject<Boolean>
            {
                Value = true,
                MessageList = new List<Message>()
            };
        }

        protected virtual ReturnObject<Boolean> CreateAfter()
        {
            return new ReturnObject<Boolean>
            {
                Value = true,
                MessageList = new List<Message>()
            };
        }

        protected virtual ReturnObject<Boolean> UpdateBefore()
        {
            return new ReturnObject<Boolean>
            {
                Value = true,
                MessageList = new List<Message>()
            };
        }

        protected virtual ReturnObject<Boolean> UpdateAfter()
        {
            return new ReturnObject<Boolean>
            {
                Value = true,
                MessageList = new List<Message>()
            };
        }

        protected virtual ReturnObject<Boolean> DeleteBefore()
        {
            return new ReturnObject<Boolean>
            {
                Value = true,
                MessageList = new List<Message>()
            };
        }

        protected virtual ReturnObject<Boolean> DeleteAfter()
        {
            return new ReturnObject<Boolean>
            {
                Value = true,
                MessageList = new List<Message>()
            };
        }

        protected virtual ReturnObject<Data> ReadBefore()
        {
            return new ReturnObject<Data>
            {
                MessageList = new List<Message>()
            };
        }

        protected virtual ReturnObject<Data> ReadAfter()
        {
            return new ReturnObject<Data>
            {
                MessageList = new List<Message>()
            };
        }

        private ReturnObject<Boolean> ActivateBefore()
        {
            return new ReturnObject<Boolean>
            {
                Value = true,
                MessageList = new List<Message>()
            };
        }

        private ReturnObject<Boolean> ActivateAfter()
        {
            return new ReturnObject<Boolean>
            {
                Value = true,
                MessageList = new List<Message>()
            };
        }

        private ReturnObject<Boolean> DeactivateBefore()
        {
            return new ReturnObject<Boolean>
            {
                Value = true,
                MessageList = new List<Message>()
            };
        }

        private ReturnObject<Boolean> DeactivateAfter()
        {
            return new ReturnObject<Boolean>
            {
                Value = true,
                MessageList = new List<Message>()
            };
        }

        #endregion

        #region ICrud Members

        ReturnObject<Boolean> ICrud.Save()
        {
            return this.SaveInternal();
        }

        ReturnObject<Boolean> ICrud.Delete()
        {
            return this.DeleteInternal();
        }

        ReturnObject<Data> ICrud.Read()
        {
            return this.ReadInternal();
        }

        ReturnObject<List<Data>> ICrud.ReadAll()
        {
            return this.ReadAll();
        }

        #endregion

        #region IActivator

        ReturnObject<Boolean> IActivator.Activate()
        {
            ReturnObject<Boolean> retObj = new ReturnObject<Boolean>
            {
                Value = true,
                MessageList = new List<Message>(),
            };

            this.actionType = Action.Activate;

            if (this.Data.Id != 0) //There is data to read
            {
                //Manage before hook
                if (retObj.MergeMessageList(this.ActivateBefore()).HasError()) return retObj;

                //Read own
                if (retObj.MergeMessageList(this.Activate()).HasError()) return retObj;

                //Manage after hook
                if (retObj.MergeMessageList(this.ActivateAfter()).HasError()) return retObj;
            }

            return retObj;
        }

        ReturnObject<Boolean> IActivator.Deactivate()
        {
            ReturnObject<Boolean> retObj = new ReturnObject<Boolean>
            {
                Value = true,
                MessageList = new List<Message>(),
            };

            this.actionType = Action.Activate;

            if (this.Data.Id != 0) //There is data to read
            {
                //Manage before hook
                if (retObj.MergeMessageList(this.DeactivateBefore()).HasError()) return retObj;

                //Read own
                if (retObj.MergeMessageList(this.Deactivate()).HasError()) return retObj;

                //Manage after hook
                if (retObj.MergeMessageList(this.DeactivateAfter()).HasError()) return retObj;
            }

            return retObj;
        }

        ReturnObject<List<Data>> IActivator.ReadAllActivate()
        {
            return this.ReadAllActivate();
        }

        #endregion

        protected ReturnObject<Boolean> ManipulateReturnObject(ReturnObject<Boolean> retObj, ReturnObject<Boolean> result)
        {
            if (result.MessageList != null && result.MessageList.Count > 0)
            {
                if (retObj.MessageList == null) retObj.MessageList = new List<Message>();
                retObj.MessageList.AddRange(result.MessageList);
            }
            retObj.Value &= result.Value;
            if (retObj.HasError()) retObj.Value = false;
            return retObj;
        }

        private void RunForEach<T>(Boolean isParallel, List<T> list, Predicate<T> predicate)
        {
            if (isParallel)
            {
                Parallel.ForEach<T>(list, data =>
                {
                    predicate(data);
                });
            }
            else
            {
                foreach (T data in list)
                {
                    predicate(data);
                }
            }
        }

        public enum ChildType
        {
            Dependent = 1,
            Independent = 2
        }

        public enum Action
        {
            Activate,
            Create,
            Read,
            Update,
            Delete
        }

    }

}