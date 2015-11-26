using FacLib = Sparkle.Core.Facade;

using Fac = Sparkle.Configuration.Facade.District;

namespace Sparkle.Configuration.WinForm.District
{

    public partial class Form : Sparkle.Core.Presentation.Form
    {

        public Form()
        {
            base.FormControl = new FormControl();
            InitializeComponent();
            base.ListDisplayName = "Name";
            base.FormName = "District";
        }

        #region Framework

        protected override FacLib.FormDto InstantiateFormDto()
        {
            return new Fac.FormDto
            {
                Dto = new Fac.Dto(),
            };
        }

        protected override FacLib.Server InstantiateFacade()
        {
            return new Fac.Server(base.FormDto as Fac.FormDto);
        }

        #endregion

    }

}