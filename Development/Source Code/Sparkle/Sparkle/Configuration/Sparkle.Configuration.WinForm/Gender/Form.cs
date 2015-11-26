using Fac = Sparkle.Core.Facade;

namespace Sparkle.Configuration.WinForm.Gender
{

    public partial class Form : Sparkle.Core.Presentation.Form
    {

        public Form()
        {
            base.FormControl = new FormControl();
            InitializeComponent();
            base.ListDisplayName = "Name";
            base.FormName = "Gender";
        }

        #region Framework

        protected override Fac.FormDto InstantiateFormDto()
        {
            return new Facade.Gender.FormDto
            {
                Dto = new Facade.Gender.Dto(),
            };
        }

        protected override Sparkle.Core.Facade.Server InstantiateFacade()
        {
            return new Facade.Gender.Server(base.FormDto as Facade.Gender.FormDto);
        }

        #endregion

    }

}