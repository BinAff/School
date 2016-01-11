using System;

using Sch = Sparkle.School.Facade;

using Stu = Sparkle.Student.Facade;

namespace Sparkle.Billing.Facade.Fee
{

    public class Dto : Sparkle.Core.Facade.Dto
    {

        public Double Amount { get; set; }

        public Fee.Group.Dto FeeGroup { get; set; }

        public Fee.Definition.Dto FeeDefination { get; set; }

        public Sch.Standard.Dto SchoolStandard { get; set; }

        public Stu.Category.Dto Category { get; set; }

        public Dto()
        { 
            this.FeeGroup = new Group.Dto();
            this.FeeDefination = new Fee.Definition.Dto();
            this.SchoolStandard = new Sch.Standard.Dto();
            this.Category = new Stu.Category.Dto();

        }
    }

}