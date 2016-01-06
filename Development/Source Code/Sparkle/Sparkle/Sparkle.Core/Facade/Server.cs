using BinAff.Core;
using System;

namespace Sparkle.Core.Facade
{

    public abstract class Server : BinAff.Facade.Library.Server
    {

        public Crud ComponentServer { get; protected set; }
        public Data ComponentData { get; protected set; }

        public Server(FormDto formDto)
            : base(formDto)
        {
            base.FormDto = this.InstantiateFormDto();
            this.Instantiate();
        }

        protected abstract void Instantiate();

        protected internal abstract FormDto InstantiateFormDto();

        protected abstract Server InstantiateFacade();

        public abstract void AssignDto();

        public abstract void AssignData();

        public virtual void LoadListForControl()
        {

        }

        public override sealed void LoadForm()
        {
            (this.ComponentServer as BinAff.Core.Crud).IsReadOwnData = true;
            (this.FormDto as FormDto).DtoList = this.ReadAll<Dto>().ConvertAll<Core.Facade.Dto>(new System.Converter<Dto, Core.Facade.Dto>((p) => { return p as Core.Facade.Dto; }));
        }
        
        public override void Add()
        {
            this.Save();
        }

        public override void Change()
        {
            this.Save();
        }

        public override void Read()
        {
            this.AssignData();
            (this.ComponentServer as BinAff.Core.Crud).IsReadOwnData = false;
            BinAff.Core.ReturnObject<BinAff.Core.Data> ret = (this.ComponentServer as ICrud).Read();
            if (this.IsError = ret.HasError())
            {
                this.DisplayMessageList = ret.GetMessage(BinAff.Core.Message.Type.Error);
            }
            else
            {
                this.AssignDtoInternal();
            }
        }

        public override void Delete()
        {
            this.AssignDataInternal();
            BinAff.Core.ReturnObject<Boolean> ret = (this.ComponentServer as ICrud).Delete();
            this.DisplayMessageList = ret.GetMessage((this.IsError = ret.HasError()) ? BinAff.Core.Message.Type.Error : BinAff.Core.Message.Type.Information);
        }

        public override void Activate()
        {
            BinAff.Core.ReturnObject<Boolean> ret = (this.ComponentServer as IActivator).Activate();
            this.DisplayMessageList = ret.GetMessage((this.IsError = ret.HasError()) ? BinAff.Core.Message.Type.Error : BinAff.Core.Message.Type.Information);
        }

        public override void Deactivate()
        {
            BinAff.Core.ReturnObject<Boolean> ret = (this.ComponentServer as IActivator).Deactivate();
            this.DisplayMessageList = ret.GetMessage((this.IsError = ret.HasError()) ? BinAff.Core.Message.Type.Error : BinAff.Core.Message.Type.Information);
        }

        protected override sealed BinAff.Core.ICrud AssignComponentServer(BinAff.Core.Data data)
        {
            return this.ComponentServer;
        }

        private void AssignDtoInternal()
        {
            (this.FormDto as FormDto).Dto.Id = this.ComponentServer.Data.Id;
            (this.FormDto as FormDto).Dto.IsActive = this.ComponentServer.Data.IsActive;
            this.AssignDto();
        }

        private void AssignDataInternal()
        {
            this.ComponentServer.Data.Id = (this.FormDto as FormDto).Dto.Id;
            this.ComponentServer.Data.IsActive = (this.FormDto as FormDto).Dto.IsActive;
            this.AssignData();
        }

        private void Save()
        {
            this.AssignDataInternal();
            BinAff.Core.ReturnObject<Boolean> ret = (this.ComponentServer as ICrud).Save();
            if (ret.Value) (this.FormDto as FormDto).Dto.Id = this.ComponentData.Id;
            this.DisplayMessageList = ret.GetMessage((this.IsError = ret.HasError()) ? BinAff.Core.Message.Type.Error : BinAff.Core.Message.Type.Information);
        }

    }

}