using Fac = Sparkle.Core.Facade;

namespace Sparkle.Configuration.WinForm.Country
{

    public partial class Form : Sparkle.Core.Presentation.Form
    {

        public Form()
        {
            base.FormControl = new FormControl();
            InitializeComponent();
            base.ListDisplayName = "Name";
        }

        #region Framework

        protected override Fac.FormDto InstantiateFormDto()
        {
            return new Facade.Country.FormDto
            {
                Dto = new Facade.Country.Dto(),
            };
        }

        protected override Sparkle.Core.Facade.Server InstantiateFacade()
        {
            return new Facade.Country.Server(base.FormDto as Facade.Country.FormDto);
        }

        #endregion

    }

}