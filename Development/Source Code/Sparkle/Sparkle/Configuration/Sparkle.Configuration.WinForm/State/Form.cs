using Fac = Sparkle.Core.Facade;

namespace Sparkle.Configuration.WinForm.State
{

    public partial class Form : Sparkle.Core.Presentation.Form
    {

        public Form()
        {
            base.FormControl = new FormControl();
            InitializeComponent();
            base.ListDisplayName = "Name";
            base.FormName = "State";
        }

        #region Framework

        protected override Fac.FormDto InstantiateFormDto()
        {
            return new Facade.State.FormDto
            {
                Dto = new Facade.State.Dto(),
            };
        }

        protected override Sparkle.Core.Facade.Server InstantiateFacade()
        {
            return new Facade.State.Server(base.FormDto as Facade.State.FormDto);
        }

        #endregion

    }

}