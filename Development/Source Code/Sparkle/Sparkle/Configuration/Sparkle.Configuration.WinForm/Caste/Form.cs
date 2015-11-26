using Fac = Sparkle.Core.Facade;

namespace Sparkle.Configuration.WinForm.Caste
{

    public partial class Form : Sparkle.Core.Presentation.Form
    {

        public Form()
        {
            base.FormControl = new FormControl();
            InitializeComponent();
            base.ListDisplayName = "Name";
            base.FormName = "Caste";
        }

        #region Framework

        protected override Fac.FormDto InstantiateFormDto()
        {
            return new Facade.Caste.FormDto
            {
                Dto = new Facade.Caste.Dto(),
            };
        }

        protected override Sparkle.Core.Facade.Server InstantiateFacade()
        {
            return new Facade.Caste.Server(base.FormDto as Facade.Caste.FormDto);
        }

        #endregion

    }

}