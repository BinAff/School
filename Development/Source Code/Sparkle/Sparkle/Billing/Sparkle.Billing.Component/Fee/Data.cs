using System;

using Sch = Sparkle.School.Component;

using Stu = Sparkle.Student.Component;

namespace Sparkle.Billing.Component.Fee
{

    public class Data : BinAff.Core.Data
    {

        public Double Amount { get; set; }

        public Group.Data FeeGroup { get; set; }

        public Definition.Data FeeDefination { get; set; }

        public Sch.Standard.Data SchoolStandard { get; set; }

        public Stu.Category.Data Category { get; set; }


        public Data()
        { 
            this.FeeGroup = new Fee.Group.Data();
            this.FeeDefination = new Definition.Data();
            this.SchoolStandard = new Sch.Standard.Data();
            this.Category = new Stu.Category.Data();

        }

    }

}