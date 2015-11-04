﻿using System;

namespace Sparkle.Core.Facade
{

    public abstract class Server : BinAff.Facade.Library.Server
    {

        public BinAff.Core.ICrud ComponentServer { get; protected set; }
        public BinAff.Core.Data ComponentData { get; protected set; }

        public Server(FormDto formDto)
            : base(formDto)
        {
            this.Instantiate();
        }

        public abstract void AssignDto();

        public abstract void AssignData();
        
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
            BinAff.Core.ReturnObject<BinAff.Core.Data> ret = this.ComponentServer.Read();
            if (this.IsError = ret.HasError())
            {
                this.DisplayMessageList = ret.GetMessage(BinAff.Core.Message.Type.Error);
            }
            else
            {
                (this.FormDto as FormDto).Dto = this.Convert(ret.Value) as Dto;
            }
        }

        public override void Delete()
        {
            this.AssignData();
            BinAff.Core.ReturnObject<Boolean> ret = this.ComponentServer.Delete();
            this.DisplayMessageList = ret.GetMessage((this.IsError = ret.HasError()) ? BinAff.Core.Message.Type.Error : BinAff.Core.Message.Type.Information);
        }

        protected override sealed BinAff.Core.ICrud AssignComponentServer(BinAff.Core.Data data)
        {
            return this.ComponentServer;
        }

        private void Save()
        {
            this.AssignData();
            BinAff.Core.ReturnObject<Boolean> ret = this.ComponentServer.Save();
            if (ret.Value) (this.FormDto as FormDto).Dto.Id = this.ComponentData.Id;
            this.DisplayMessageList = ret.GetMessage((this.IsError = ret.HasError()) ? BinAff.Core.Message.Type.Error : BinAff.Core.Message.Type.Information);
        }

        protected abstract void Instantiate();

    }

}