using System;
using System.Collections.Generic;

using BinAff.Core;
using BinAff.Utility;

namespace Crystal.Configuration.Component.Landline
{
    public class Validator : BinAff.Core.Validator
    {
        public Validator(Data data)
            : base(data)
        {

        }

        protected override List<Message> Validate()
        {
            List<Message> retMsg = new List<Message>();
            Data data = (Data)base.Data;

            if (ValidationRule.IsNullOrEmpty(data.StdCode))
            {
                retMsg.Add(new Message("StdCode cannot be empty.", Message.Type.Error));
            }
            if ((this.Server.DataAccess as Dao).ReadDuplicate())
            {
                retMsg.Add(new Message("StdCode already exists.", Message.Type.Error));
            }

            return retMsg;
        }
 

    }
}
