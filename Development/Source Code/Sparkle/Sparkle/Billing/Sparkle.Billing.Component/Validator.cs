using System.Collections.Generic;

using BinAff.Core;
using BinAff.Utility;

namespace Sparkle.Billing.Component
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

            if (ValidationRule.IsNullOrEmpty(data.Date))
            {
                retMsg.Add(new Message("Date cannot be Empty.", Message.Type.Error));
            }

            if (ValidationRule.IsNegative(data.Installment))
            {
                retMsg.Add(new Message("Installment cannot be Negative.", Message.Type.Error));
            }

            if (ValidationRule.IsNegative(data.FeeAmount))
            {
                retMsg.Add(new Message("Fee Amount cannot be Negative.", Message.Type.Error));
            }

            if (ValidationRule.IsNegative(data.FineAmount))
            {
                retMsg.Add(new Message("Fine Amount cannot be Negative.", Message.Type.Error));
            }

            if (ValidationRule.IsNegative(data.TotalAmount))
            {
                retMsg.Add(new Message("Total Amount cannot be Negative.", Message.Type.Error));
            }

            if (ValidationRule.IsNegative(data.AmountPaid))
            {
                retMsg.Add(new Message("Amount Paid cannot be Negative.", Message.Type.Error));
            }

            if ((this.Server.DataAccess as Dao).ReadDuplicate())
            {
                retMsg.Add(new Message("Fine already exists.", Message.Type.Error));
            }
            return retMsg;
        }

    }

}