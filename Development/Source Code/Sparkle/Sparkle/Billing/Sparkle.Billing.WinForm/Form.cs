namespace Sparkle.Billing.WinForm
{

    public partial class Form : Sparkle.Core.Presentation.Form
    {

        public Form()
        {
            InitializeComponent();
            base.ListDisplayName = "Name";
            base.FormName = "Bill";
        }

        #region Framework

        protected override void InstantiateFormControl()
        {
            //base.FormControl = new FormControl();
        }

        #endregion

    }

}