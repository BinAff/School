using System;

using BinAff.Presentation.Library.Extension;

using Bil = Sparkle.Billing.Facade;

using Fac = Sparkle.Billing.Facade.Fee.Definition;

namespace Sparkle.Billing.WinForm.Fee.Definition
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
            this.cboFeeGroup.Bind((this.FormDto as Fac.FormDto).FeeGroupList, "Name");
            this.cboFineDe.Bind((this.FormDto as Fac.FormDto).FineDefinationList, "Name");
        }

        protected override void ClearForm()
        {
            this.txtName.Text = String.Empty;
            this.cboFeeGroup.SelectedIndex = -1;
            this.cboFeeGroup.Text = String.Empty;
            this.cboFineDe.SelectedIndex = -1;
            this.cboFineDe.Text = String.Empty;
            this.txtName.Focus();
        }

        protected override void AssignDto()
        {
            Fac.Dto dto = base.FormDto.Dto as Fac.Dto;
            dto.Name = this.txtName.Text;
            dto.FeeGroup = this.cboFeeGroup.SelectedItem as Bil.Fee.Group.Dto;
            dto.FineDefination = this.cboFineDe.SelectedItem as Bil.Fine.Definition.Dto;

        }

        protected override void AssignFormControls()
        {
            Fac.Dto dto = base.FormDto.Dto as Fac.Dto;
            this.txtName.Text = dto.Name;
            this.cboFeeGroup.SelectedItem = (this.FormDto as Fac.FormDto).FeeGroupList.FindLast((p) => { return p.Id == dto.FeeGroup.Id; }); ;
            this.cboFineDe.SelectedItem = (this.FormDto as Fac.FormDto).FineDefinationList.FindLast((p) => { return p.Id == dto.FineDefination.Id; }); ;
        }

        protected override Boolean ValidateForm()
        {

            return true;
        }

    }

}