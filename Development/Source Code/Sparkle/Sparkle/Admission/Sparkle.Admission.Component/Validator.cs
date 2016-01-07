using System.Collections.Generic;

using BinAff.Core;
using BinAff.Utility;

namespace Sparkle.Admission.Component
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

            return retMsg;
        }

    }

}