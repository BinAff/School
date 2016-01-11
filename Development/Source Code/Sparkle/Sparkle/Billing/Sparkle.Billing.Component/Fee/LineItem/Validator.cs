using System.Collections.Generic;

using BinAff.Core;
using BinAff.Utility;

namespace Sparkle.Billing.Component.Fee.LineItem
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

            if (ValidationRule.IsNullOrEmpty(data.Installment))
            {
                retMsg.Add(new Message("Installment cannot be empty.", Message.Type.Error));
            }
            else
            {
                if (ValidationRule.IsNegative(data.Installment))
                {
                    retMsg.Add(new Message("Installment cannot be Negative.", Message.Type.Error));
                } 
            }

            if (ValidationRule.IsNullOrEmpty(data.Amount))
            {
                retMsg.Add(new Message("Amount cannot be empty.", Message.Type.Error));
            }
            else
            {
                if (ValidationRule.IsNegative(data.Amount))
                {
                    retMsg.Add(new Message("Amount cannot be Negative.", Message.Type.Error));
                }
            }

            if ((this.Server.DataAccess as Dao).ReadDuplicate())
            {
                retMsg.Add(new Message("Fee Line Item already exists.", Message.Type.Error));
            }
            return retMsg;
        }

    }

}