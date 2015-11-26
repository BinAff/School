using System;

namespace Sparkle.Configuration.WinForm.Gender
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
            Facade.Gender.Dto dto = base.FormDto.Dto as Facade.Gender.Dto;
            dto.Name = this.txtName.Text;
        }

        protected override void AssignFormControls()
        {
            Facade.Gender.Dto dto = base.FormDto.Dto as Facade.Gender.Dto;
            this.txtName.Text = dto.Name;
        }

        protected override Boolean ValidateForm()
        {

            return true;
        }

    }

}