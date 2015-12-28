using Sparkle.Core.Presentation;

namespace Sparkle.Finance.WinForm.AccountDetails
{
    public partial class Form : Sparkle.Core.Presentation.Form
    {
        public Form()
        {
            InitializeComponent();
            base.ListDisplayName = "Name";
            base.FormName = "AccountDetails";
        }

        #region Framework

        protected override void InstantiateFormControl()
        {
            base.FormControl = new FormControl();
        }

        #endregion
    }
}
