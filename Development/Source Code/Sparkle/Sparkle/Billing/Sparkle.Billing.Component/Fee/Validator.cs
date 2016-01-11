using System.Collections.Generic;

using BinAff.Core;
using BinAff.Utility;

namespace Sparkle.Billing.Component.Fee
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
            if (ValidationRule.IsNullOrEmpty(data.Amount))
            {
                retMsg.Add(new Message("Amount cannot be Empty.", Message.Type.Error));
            }
            else
            {
                if (ValidationRule.IsNegative(data.Amount))
                {
                    retMsg.Add(new Message("Amount cannot be Negative.", Message.Type.Error));
                }
            }

            if (ValidationRule.IsNegative(data.FeeGroup.Id))
            {
                retMsg.Add(new Message("Please select Fee Group.", Message.Type.Error));
            }

            if (ValidationRule.IsNegative(data.FeeDefination.Id))
            {
                retMsg.Add(new Message("Please select Fee Defination.", Message.Type.Error));
            }

            if (ValidationRule.IsNegative(data.SchoolStandard.Id))
            {
                retMsg.Add(new Message("Please select School Standard.", Message.Type.Error));
            }

            if (ValidationRule.IsNegative(data.Category.Id))
            {
                retMsg.Add(new Message("Please select Student Category.", Message.Type.Error));
            }

            if ((this.Server.DataAccess as Dao).ReadDuplicate())
            {
                retMsg.Add(new Message("Fee already exists.", Message.Type.Error));
            }
            return retMsg;
        }

    }

}