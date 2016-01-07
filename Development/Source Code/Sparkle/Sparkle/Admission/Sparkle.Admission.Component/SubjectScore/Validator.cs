
using System.Collections.Generic;

using BinAff.Core;
using BinAff.Utility;

namespace Sparkle.Admission.Component.SubjectScore
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

            if (ValidationRule.IsNullOrEmpty(data.Marks))
            {
                retMsg.Add(new Message("Marks cannot be Empty.", Message.Type.Error));
            }

            return retMsg;
        }

    }

}