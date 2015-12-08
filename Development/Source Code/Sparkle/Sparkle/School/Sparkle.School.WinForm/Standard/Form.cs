namespace Sparkle.School.WinForm.Standard
{

    public partial class Form : Sparkle.Core.Presentation.Form
    {

        public Form()
        {
            InitializeComponent();
            base.ListDisplayName = "Name";
            base.FormName = "Standard";
        }

        #region Framework

        protected override void InstantiateFormControl()
        {
            base.FormControl = new FormControl();
        }

        #endregion

    }

}