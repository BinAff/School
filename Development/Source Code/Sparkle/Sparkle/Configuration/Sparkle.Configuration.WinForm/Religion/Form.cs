using Fac = Sparkle.Core.Facade;

namespace Sparkle.Configuration.WinForm.Religion
{

    public partial class Form : Sparkle.Core.Presentation.Form
    {

        public Form()
        {
            base.FormControl = new FormControl();
            InitializeComponent();
            base.ListDisplayName = "Name";
            base.FormName = "Religion";
        }

        #region Framework

        protected override Fac.FormDto InstantiateFormDto()
        {
            return new Facade.Religion.FormDto
            {
                Dto = new Facade.Religion.Dto(),
            };
        }

        protected override Sparkle.Core.Facade.Server InstantiateFacade()
        {
            return new Facade.Religion.Server(base.FormDto as Facade.Religion.FormDto);
        }

        #endregion

    }

}