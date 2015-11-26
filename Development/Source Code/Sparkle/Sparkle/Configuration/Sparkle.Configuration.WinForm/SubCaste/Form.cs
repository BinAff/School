using Fac = Sparkle.Core.Facade;

namespace Sparkle.Configuration.WinForm.SubCaste
{

    public partial class Form : Sparkle.Core.Presentation.Form
    {

        public Form()
        {
            base.FormControl = new FormControl();
            InitializeComponent();
            base.ListDisplayName = "Name";
            base.FormName = "Sub Caste";
        }

        #region Framework

        protected override Fac.FormDto InstantiateFormDto()
        {
            return new Facade.SubCaste.FormDto
            {
                Dto = new Facade.SubCaste.Dto(),
            };
        }

        protected override Sparkle.Core.Facade.Server InstantiateFacade()
        {
            return new Facade.SubCaste.Server(base.FormDto as Facade.SubCaste.FormDto);
        }

        #endregion

    }

}