using System.Collections.Generic;
using BinAff.Core;
using BinAff.Utility;


namespace Crystal.Configuration.Component.Religion
{
public  class Validator :BinAff.Core.Validator
    {
    public Validator(Data data)
        : base(data) 
    { 

    }

    protected override List<BinAff.Core.Message> Validate()
    {
        List<Message> msg = new List<Message>();
        Data data = base.Data as Data;

        if (ValidationRule.IsNullOrEmpty(data.Name))
        {
            msg.Add(new Message("Religion name cannot be empty.", Message.Type.Error));
        }
        
          return msg;
    }

    }
}
