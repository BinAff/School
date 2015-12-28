using System;

using Fac = Sparkle.Finance.Facade.AccountingYear;

namespace Sparkle.Finance.WinForm.AccountingYear
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
            this.rdlCurrYrYes.Select();
            this.txtName.Focus();
        }

        protected override void AssignDto()
        {
            Fac.Dto dto = base.FormDto.Dto as Fac.Dto;
            dto.Name = this.txtName.Text;
            dto.CurrentFlag = (rdlCurrYrYes.Checked == true) ? true : false;
        }

        protected override void AssignFormControls()
        {
            Fac.Dto dto = base.FormDto.Dto as Fac.Dto;
            this.txtName.Text = dto.Name;
            this.rdlCurrYrYes.Checked = (dto.CurrentFlag == true) ? true : false;
        }

        protected override Boolean ValidateForm()
        {

            return true;
        }

    }

}