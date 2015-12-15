using System.Collections.Generic;

using BinAff.Core;
using BinAff.Utility;

namespace Sparkle.Student.Component.PersonalInformation
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

            if (ValidationRule.IsNullOrEmpty(data.DateOfBirth))
            {
                msg.Add(new Message("Date of Birth cannot be empty.", Message.Type.Error));
            }
            if (ValidationRule.IsNullOrEmpty(data.BirthPlace))
            {
                msg.Add(new Message("Birth Place cannot be empty.", Message.Type.Error));
            }
            if (ValidationRule.IsNullOrEmpty(data.MotherTongue))
            {
                msg.Add(new Message("Mother Tongue cannot be empty.", Message.Type.Error));
            }
            if (ValidationRule.IsNullOrEmpty(data.Religion))
            {
                msg.Add(new Message("Religion cannot be empty.", Message.Type.Error));
            }
            if (ValidationRule.IsNullOrEmpty(data.Caste))
            {
                msg.Add(new Message("Caste cannot be empty.", Message.Type.Error));
            }
            if (ValidationRule.IsNullOrEmpty(data.Gender))
            {
                msg.Add(new Message("Gender cannot be empty.", Message.Type.Error));
            }
            if (ValidationRule.IsNullOrEmpty(data.PresentAddress))
            {
                msg.Add(new Message("Current Address cannot be empty.", Message.Type.Error));
            }
            if (ValidationRule.IsNullOrEmpty(data.PermanentAddress))
            {
                msg.Add(new Message("Permanent Address cannot be empty.", Message.Type.Error));
            }

            return msg;
        }

    }

}