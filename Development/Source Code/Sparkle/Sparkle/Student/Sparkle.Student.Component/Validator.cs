using System.Collections.Generic;

using BinAff.Core;
using BinAff.Utility;

namespace Sparkle.Student.Component
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

            if (ValidationRule.IsNullOrEmpty(data.FirstName))
            {
                msg.Add(new Message("First name cannot be empty.", Message.Type.Error));
            }
            if (ValidationRule.IsNullOrEmpty(data.Address))
            {
                msg.Add(new Message("Address cannot be empty.", Message.Type.Error));
            }
            if (data.State == null || data.State.Id == 0)
            {
                msg.Add(new Message("State has to be selected.", Message.Type.Error));
            }
            if (data.Country == null || data.Country.Id == 0)
            {
                msg.Add(new Message("Country has to be selected.", Message.Type.Error));
            }

            return msg;
        }

    }

}