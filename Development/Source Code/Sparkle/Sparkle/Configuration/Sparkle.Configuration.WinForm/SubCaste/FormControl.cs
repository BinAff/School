using System;

using Fac = Sparkle.Configuration.Facade.SubCaste;

namespace Sparkle.Configuration.WinForm.SubCaste
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
            Fac.Dto dto = base.FormDto.Dto as Fac.Dto;
            dto.Name = this.txtName.Text;
        }

        protected override void AssignFormControls()
        {
            Fac.Dto dto = base.FormDto.Dto as Fac.Dto;
            this.txtName.Text = dto.Name;
        }

        protected override Boolean ValidateForm()
        {

            return true;
        }

    }

}