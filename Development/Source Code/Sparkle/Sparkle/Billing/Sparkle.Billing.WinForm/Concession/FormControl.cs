using System;

using BinAff.Presentation.Library.Extension;

using Fac = Sparkle.Billing.Facade.Concession;

using FinFac = Sparkle.Billing.Facade.Fee;

using ConFac = Sparkle.Configuration.Facade;

namespace Sparkle.Billing.WinForm.Concession
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
            this.cboFeeDefinition.Bind((this.FormDto as Fac.FormDto).FeeDefinationList, "Name");
            this.cboCaste.Bind((this.FormDto as Fac.FormDto).CasteList, "Name");
        }

        protected override void ClearForm()
        {
            this.cboFeeDefinition.SelectedIndex = -1;
            this.cboFeeDefinition.Text = String.Empty;
            this.cboCaste.SelectedIndex = -1;
            this.cboCaste.Text = String.Empty;
            this.txtAmount.Text = String.Empty;
            this.rdlYes.Checked = true;
            this.cboFeeDefinition.Focus();
        }

        protected override void AssignDto()
        {
            Fac.Dto dto = base.FormDto.Dto as Fac.Dto;
            dto.FeeDefinition = this.cboFeeDefinition.SelectedItem as FinFac.Definition.Dto;
            dto.Caste = this.cboCaste.SelectedItem as ConFac.Caste.Dto;
            dto.Amount = Convert.ToDouble(this.txtAmount.Text);
            dto.IsPercentage = rdlYes.Checked == true ? true : false;
        }

        protected override void AssignFormControls()
        {
            Fac.Dto dto = base.FormDto.Dto as Fac.Dto;

            this.cboFeeDefinition.SelectedItem = (this.FormDto as Fac.FormDto).FeeDefinationList.FindLast((p) => { return p.Id == dto.FeeDefinition.Id; });
            this.cboCaste.SelectedItem = (this.FormDto as Fac.FormDto).CasteList.FindLast((p) => { return p.Id == dto.Caste.Id; }); 
            this.txtAmount.Text = Convert.ToString(dto.Amount);
        }

        protected override Boolean ValidateForm()
        {

            return true;
        }
    }

}