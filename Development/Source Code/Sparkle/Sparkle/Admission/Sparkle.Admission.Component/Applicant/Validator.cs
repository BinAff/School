using System.Collections.Generic;

using BinAff.Core;
using BinAff.Utility;

namespace Sparkle.Admission.Component.Applicant
{

    public class Validator : BinAff.Core.Validator
    {

        public Validator(Data data)
            : base(data)
        {

        }

        protected override List<BinAff.Core.Message> Validate()
        {
            List<Message> retMsg = new List<Message>();
            Data data = base.Data as Data;

            if (ValidationRule.IsNullOrEmpty(data.FirstName))
            {
                retMsg.Add(new Message("First Name cannot be Empty.", Message.Type.Error));
            }

            if (ValidationRule.IsNullOrEmpty(data.LastName))
            {
                retMsg.Add(new Message("Last Name cannot be Empty.", Message.Type.Error));
            }

            if (ValidationRule.IsNullOrEmpty(data.DateOfBirth))
            {
                retMsg.Add(new Message("Date Of Birth cannot be Empty.", Message.Type.Error));
            }

            if ((this.Server.DataAccess as Dao).ReadDuplicate())
            {
                retMsg.Add(new Message("Applicant already exists.", Message.Type.Error));
            }
            return retMsg;
        }

    }

}