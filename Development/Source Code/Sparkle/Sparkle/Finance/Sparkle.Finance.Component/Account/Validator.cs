using System.Collections.Generic;

using BinAff.Core;
using BinAff.Utility;

namespace Sparkle.Finance.Component.Account
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

            if (ValidationRule.IsNullOrEmpty(data.Id))
            {
                retMsg.Add(new Message("Id cannot be empty.", Message.Type.Error));
            }

            if (ValidationRule.IsNullOrEmpty(data.Name))
            {
                retMsg.Add(new Message("Name cannot be empty.", Message.Type.Error));
            }

            if ((this.Server.DataAccess as Dao).ReadDuplicate())
            {
                retMsg.Add(new Message("Account already exists.", Message.Type.Error));
            }
            return retMsg;
        }

    }

}