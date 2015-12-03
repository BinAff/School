using StateFac = Vanilla.Configuration.Facade.State;

using FacLib = Sparkle.Core.Facade;

namespace Sparkle.Student.WinForm.Student
{

    public partial class Form : Sparkle.Core.Presentation.Form
    {

        public Form()
            : base()
        {            
            InitializeComponent();
            base.ListDisplayName = "FirstName";
        }

        #region Framework

        protected override void InstantiateFormControl()
        {
            base.FormControl = new FormControl();
        }

        #endregion

    }

}