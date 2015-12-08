namespace Sparkle.School.WinForm.Section
{

    public partial class Form : Sparkle.Core.Presentation.Form
    {

        public Form()
        {
            InitializeComponent();
            base.ListDisplayName = "Name";
            base.FormName = "Section";
        }

        #region Framework

        protected override void InstantiateFormControl()
        {
            base.FormControl = new FormControl();
        }

        #endregion

    }

}