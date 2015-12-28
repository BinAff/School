using System.Collections.Generic;

using BinAff.Core;
using BinAff.Utility;

namespace Crystal.Configuration.Component.Frequency
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
                retMsg.Add(new Message("Frequency cannot be empty.", Message.Type.Error));
            }

            if ((this.Server.DataAccess as Dao).ReadDuplicate())
            {
                retMsg.Add(new Message("Frequency already exists.", Message.Type.Error));
            }
            return retMsg;
        }

    }

}