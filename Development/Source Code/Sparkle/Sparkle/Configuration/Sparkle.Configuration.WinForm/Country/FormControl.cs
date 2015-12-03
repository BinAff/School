using System;

using Fac = Sparkle.Configuration.Facade.Country;

namespace Sparkle.Configuration.WinForm.Country
{

    public partial class FormControl : Sparkle.Core.Presentation.FormControl
    {

        public FormControl()
        {
            InitializeComponent();
        }

        protected override Core.Facade.Server InstantiateFacade()
        {
            return new Fac.Server(base.FormDto as Fac.FormDto);
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
            Fac.Dto dto = base.FormDto.Dto as Fac.Dto;
            dto.Name = this.txtName.Text;
            dto.Code = this.txtCode.Text;
            dto.IsdCode = Convert.ToInt16(this.txtIsdCode.Text);
        }

        protected override void AssignFormControls()
        {
            Fac.Dto dto = base.FormDto.Dto as Fac.Dto;
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