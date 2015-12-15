using System.Collections.Generic;

using BinAff.Core;
using BinAff.Utility;

namespace Sparkle.Student.Component.Guardian
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

            if (ValidationRule.IsNullOrEmpty(data.Relationship))
            {
                msg.Add(new Message("Relationship cannot be empty.", Message.Type.Error));
            }
            if (ValidationRule.IsNullOrEmpty(data.Profile))
            {
                msg.Add(new Message("Profile cannot be empty.", Message.Type.Error));
            }
            return msg;
        }

    }

}