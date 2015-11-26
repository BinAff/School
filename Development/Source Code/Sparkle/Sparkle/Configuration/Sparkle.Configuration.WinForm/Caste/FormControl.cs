using System;

namespace Sparkle.Configuration.WinForm.Caste
{

    public partial class FormControl : Sparkle.Core.Presentation.FormControl
    {

        public FormControl()
        {
            InitializeComponent();
        }

        protected override void Bind()
        {

        }

        protected override void ResetForm()
        {
            this.txtName.Text = String.Empty;
            this.txtName.Focus();
        }

        protected override void AssignDto()
        {
            Facade.Caste.Dto dto = base.FormDto.Dto as Facade.Caste.Dto;
            dto.Name = this.txtName.Text;
        }

        protected override void AssignFormControls()
        {
            Facade.Caste.Dto dto = base.FormDto.Dto as Facade.Caste.Dto;
            this.txtName.Text = dto.Name;
        }

        protected override Boolean ValidateForm()
        {

            return true;
        }

    }

}