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
            if (this.ComponentServer != null) this.IsLov = this.ComponentServer.IsLov;
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
            (this.ComponentServer as Crud).IsReadOwnData = true;
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
            this.AssignDataInternal();
            (this.ComponentServer as Crud).IsReadOwnData = false;
            ReturnObject<Data> ret = (this.ComponentServer as ICrud).Read();
            if (this.IsError = ret.HasError())
            {
                this.DisplayMessageList = ret.GetMessage(Message.Type.Error);
            }
            else
            {
                this.AssignDtoInternal();
            }
        }

        public override void Delete()
        {
            this.AssignDataInternal();
            ReturnObject<Boolean> ret = (this.ComponentServer as ICrud).Delete();
            this.DisplayMessageList = ret.GetMessage((this.IsError = ret.HasError()) ? Message.Type.Error : Message.Type.Information);
        }

        public override void Activate()
        {
            ReturnObject<Boolean> ret = (this.ComponentServer as IActivator).Activate();
            this.DisplayMessageList = ret.GetMessage((this.IsError = ret.HasError()) ? Message.Type.Error : Message.Type.Information);
            if (!this.IsError) (base.FormDto as FormDto).Dto.IsActive = true;
        }

        public override void Deactivate()
        {
            ReturnObject<Boolean> ret = (this.ComponentServer as IActivator).Deactivate();
            this.DisplayMessageList = ret.GetMessage((this.IsError = ret.HasError()) ? Message.Type.Error : Message.Type.Information);
            if (!this.IsError) (base.FormDto as FormDto).Dto.IsActive = false;

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
            ReturnObject<Boolean> ret = (this.ComponentServer as ICrud).Save();
            if (ret.Value) (this.FormDto as FormDto).Dto.Id = this.ComponentData.Id;
            this.DisplayMessageList = ret.GetMessage((this.IsError = ret.HasError()) ? Message.Type.Error : Message.Type.Information);
        }

    }

}