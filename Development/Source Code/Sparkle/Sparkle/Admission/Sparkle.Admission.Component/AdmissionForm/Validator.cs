using System.Collections.Generic;

using BinAff.Core;
using BinAff.Utility;

namespace Sparkle.Admission.Component.AdmissionForm
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

            if (ValidationRule.IsNullOrEmpty(data.Number))
            {
                retMsg.Add(new Message("Admission Number cannot be Empty.", Message.Type.Error));
            }

            if ((this.Server.DataAccess as Dao).ReadDuplicate())
            {
                retMsg.Add(new Message("Admission Number already exists.", Message.Type.Error));
            }
            return retMsg;
        }

    }

}