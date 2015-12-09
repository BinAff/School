namespace Sparkle.School.Facade.Class
{

    public class Dto : Sparkle.Core.Facade.Dto
    {

        public Standard.Dto Standard { get; set; }

        public Section.Dto Section { get; set; }

        public Dto()
        {
            this.Standard = new Standard.Dto();
            this.Section = new Section.Dto();
        }

    }

}