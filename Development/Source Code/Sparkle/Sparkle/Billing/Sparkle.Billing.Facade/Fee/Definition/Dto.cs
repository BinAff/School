using System;

using Bil = Sparkle.Billing.Facade;

namespace Sparkle.Billing.Facade.Fee.Definition
{

    public class Dto : Sparkle.Core.Facade.Dto
    {
        public String Name { get; set; }

        public Group.Dto FeeGroup { get; set; }

        public Fine.Definition.Dto FineDefination { get; set; }

        public Dto()
        {
            FeeGroup = new Group.Dto();
            FineDefination = new Fine.Definition.Dto();
        }
    }

}