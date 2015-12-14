using System.Collections.Generic;

using BinAff.Core;
using BinAff.Utility;

namespace Crystal.Configuration.Component.Profile
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

            if (ValidationRule.IsNullOrEmpty(data.FirstName))
            {
                retMsg.Add(new Message("First name cannot be empty.", Message.Type.Error));
            }
            else if (data.FirstName.Length > 100)
            {
                retMsg.Add(new Message("First name be more than 100 characters.", Message.Type.Error));
            }
            if (!ValidationRule.IsNullOrEmpty(data.MiddleName) && data.MiddleName.Length > 100)
            {
                retMsg.Add(new Message("Middle name be more than 100 characters.", Message.Type.Error));
            }
            if (ValidationRule.IsNullOrEmpty(data.LastName))
            {
                retMsg.Add(new Message("Last name cannot be empty.", Message.Type.Error));
            }
            else if (data.LastName.Length > 100)
            {
                retMsg.Add(new Message("Last name be more than 100 characters.", Message.Type.Error));
            }
            if (data.Occupation == null || data.Occupation.Id == 0)
            {
                retMsg.Add(new Message("Occupation cannot be empty.", Message.Type.Error));
            }
            if (data.ContactInformation == null)
            {
                retMsg.Add(new Message("Contact Information cannot be empty.", Message.Type.Error));
            }

            return retMsg;
        }

    }

}