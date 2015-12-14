using System.Collections.Generic;

using BinAff.Core;
using BinAff.Utility;

namespace Sparkle.Student.Component
{

    public class Validator : BinAff.Core.Validator
    {

        public Validator(Data data)
            : base(data)
        {

        }

        protected override List<BinAff.Core.Message> Validate()
        {
            List<Message> msg = new List<Message>();
            Data data = base.Data as Data;

            if (ValidationRule.IsNullOrEmpty(data.FirstName))
            {
                msg.Add(new Message("First name cannot be empty.", Message.Type.Error));
            }
            if (ValidationRule.IsNullOrEmpty(data.Standard))
            {
                msg.Add(new Message("Standard cannot be empty.", Message.Type.Error));
            }
            if (ValidationRule.IsNullOrEmpty(data.Section))
            {
                msg.Add(new Message("Section cannot be empty.", Message.Type.Error));
            }
            if (ValidationRule.IsNullOrEmpty(data.PersonalInformation))
            {
                msg.Add(new Message("Personal Information cannot be empty.", Message.Type.Error));
            }
            return msg;
        }

    }

}