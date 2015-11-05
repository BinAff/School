using StateFac = Vanilla.Configuration.Facade.State;

using Fac = Sparkle.Core.Facade;

namespace Sparkle.Student.WinForm.Student
{

    public partial class Form : Sparkle.Core.Presentation.Form
    {

        public Form()
            : base()
        {
            base.FormControl = new FormControl();
            InitializeComponent();
            base.ListDisplayName = "FirstName";
        }

        #region Framework

        protected override Fac.FormDto InstantiateFormDto()
        {
            return new Facade.FormDto
            {
                Dto = new Facade.Dto
                {
                    State = new StateFac.Dto(),
                },
            };
        }

        protected override Sparkle.Core.Facade.Server InstantiateFacade()
        {
            return new Facade.Server(base.FormDto as Facade.FormDto);
        }

        #endregion

    }

}