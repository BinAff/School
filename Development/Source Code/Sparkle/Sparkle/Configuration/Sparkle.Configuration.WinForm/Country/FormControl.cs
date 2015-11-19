using System;

namespace Sparkle.Configuration.WinForm.Country
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
            this.txtCode.Text = String.Empty;
            this.txtIsdCode.Text = String.Empty;
            this.txtName.Focus();
        }

        protected override void AssignDto()
        {
            Facade.Country.Dto dto = base.FormDto.Dto as Facade.Country.Dto;
            dto.Name = this.txtName.Text;
            dto.Code = this.txtCode.Text;
            dto.IsdCode = Convert.ToInt16(this.txtIsdCode.Text);
        }

        protected override void AssignFormControls()
        {
            Facade.Country.Dto dto = base.FormDto.Dto as Facade.Country.Dto;
            this.txtName.Text = dto.Name;
            this.txtCode.Text = dto.Code;
            this.txtIsdCode.Text = dto.IsdCode.ToString();
        }

        protected override Boolean ValidateForm()
        {

            return true;
        }

    }

}