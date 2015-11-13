using System;
using System.Collections.Generic;

using BinAff.Core;
using BinAff.Utility;

namespace Crystal.Configuration.Component.ContactInformation
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

            if (ValidationRule.IsNullOrEmpty(data.Address))
            {
                retMsg.Add(new Message("Caste name cannot be empty.", Message.Type.Error));
            }
            else if (data.Address.Length > 150)
            {
                retMsg.Add(new Message("Address cannot be more than 150 characters.", Message.Type.Error));
            }

            return retMsg;
        }


    }
}
