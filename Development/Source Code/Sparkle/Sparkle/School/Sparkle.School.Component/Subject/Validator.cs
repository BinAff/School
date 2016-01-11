using System.Collections.Generic;

using BinAff.Core;
using BinAff.Utility;

namespace Sparkle.School.Component.Subject
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

            if (ValidationRule.IsNullOrEmpty(data.Name))
            {
                retMsg.Add(new Message("Name cannot be Empty.", Message.Type.Error));
            }

            if (ValidationRule.IsNullOrEmpty(data.TotalMarks))
            {
                retMsg.Add(new Message("Total Marks cannot be Empty.", Message.Type.Error));
            }

            if (ValidationRule.IsNullOrEmpty(data.PassMarks))
            {
                retMsg.Add(new Message("Pass Marks cannot be Empty.", Message.Type.Error));
            }

            if ((this.Server.DataAccess as Dao).ReadDuplicate())
            {
                retMsg.Add(new Message("Applicant already exists.", Message.Type.Error));
            }
            return retMsg;
        }

    }

}