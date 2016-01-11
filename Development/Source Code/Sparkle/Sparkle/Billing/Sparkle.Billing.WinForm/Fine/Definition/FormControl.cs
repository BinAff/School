using System;

using Fac = Sparkle.Billing.Facade.Fine.Definition;

namespace Sparkle.Billing.WinForm.Fine.Definition
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

        protected override void ClearForm()
        {
            this.txtName.Text = String.Empty;
            this.rdlYes.Checked = true;
            this.txtName.Focus();
        }

        protected override void AssignDto()
        {
            Fac.Dto dto = base.FormDto.Dto as Fac.Dto;
            dto.Name = this.txtName.Text;
            dto.IsPercentage = this.rdlYes.Checked == true ? true : false;
        }

        protected override void AssignFormControls()
        {
            Fac.Dto dto = base.FormDto.Dto as Fac.Dto;
            this.txtName.Text = dto.Name;
            this.rdlYes.Checked = dto.IsPercentage;
        }

        protected override Boolean ValidateForm()
        {

            return true;
        }

    }

}