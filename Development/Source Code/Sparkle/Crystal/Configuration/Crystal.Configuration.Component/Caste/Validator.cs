﻿using System;
using System.Collections.Generic;

using BinAff.Core;
using BinAff.Utility;


namespace Crystal.Configuration.Component.Caste
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

            if (ValidationRule.IsNullOrEmpty(data.Name))
            {
                retMsg.Add(new Message("Caste name cannot be empty.", Message.Type.Error));
            }
            else if (data.Name.Length > 50)
            {
                retMsg.Add(new Message("Caste name cannot be more than 50 characters.", Message.Type.Error));
            }
            if ((this.Server.DataAccess as Dao).ReadDuplicate() != null)
            {
                retMsg.Add(new Message("Same Caste already exists.", Message.Type.Error));
            }

            return retMsg;
        }
 

    }
}