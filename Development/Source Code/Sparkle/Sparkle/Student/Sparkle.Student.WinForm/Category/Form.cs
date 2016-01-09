namespace Sparkle.Student.WinForm.Category
{

    public partial class Form : Sparkle.Core.Presentation.Form
    {

        public Form()
        {
            InitializeComponent();
            base.ListDisplayName = "Name";
            base.FormName = "Student Category";
        }

        #region Framework

        protected override void InstantiateFormControl()
        {
            base.FormControl = new FormControl();
        }

        #endregion

    }

}