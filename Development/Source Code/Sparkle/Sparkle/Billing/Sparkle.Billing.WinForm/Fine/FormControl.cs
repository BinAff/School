using System;

using BinAff.Presentation.Library.Extension;

using Fac = Sparkle.Billing.Facade.Fine;

using Sch = Sparkle.School.Facade;

namespace Sparkle.Billing.WinForm.Fine
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
            this.cboFineType.Bind((this.FormDto as Fac.FormDto).FineTypeList, "Name");
            this.cboFineDefinition.Bind((this.FormDto as Fac.FormDto).FineDefinitionList, "Name");
            this.cboStandard.Bind((this.FormDto as Fac.FormDto).SchoolStandardList, "Name");
        }

        protected override void ClearForm()
        {
            this.cboFineType.SelectedIndex = -1;
            this.cboFineType.Text = String.Empty;
            this.cboFineDefinition.SelectedIndex = -1;
            this.cboFineDefinition.Text = String.Empty;
            this.cboStandard.SelectedIndex = -1;
            this.cboStandard.Text = String.Empty;
            this.txtAmount.Text = String.Empty;
            this.cboFineType.Focus();
        }

        protected override void AssignDto()
        {
            Fac.Dto dto = base.FormDto.Dto as Fac.Dto;
            dto.FineType = this.cboFineType.SelectedItem as Fac.Type.Dto;
            dto.FineDefinition = this.cboFineDefinition.SelectedItem as Fac.Definition.Dto;
            dto.SchoolStandard = this.cboStandard.SelectedItem as Sch.Standard.Dto;
            dto.Amount = Convert.ToDouble(this.txtAmount.Text);


        }

        protected override void AssignFormControls()
        {
            Fac.Dto dto = base.FormDto.Dto as Fac.Dto;
            this.cboFineType.SelectedItem = (this.FormDto as Fac.FormDto).FineTypeList.FindLast((p) => { return p.Id == dto.FineType.Id; });
            this.cboFineDefinition.SelectedItem = (this.FormDto as Fac.FormDto).FineDefinitionList.FindLast((p) => { return p.Id == dto.FineDefinition.Id; });
            this.cboStandard.SelectedItem = (this.FormDto as Fac.FormDto).SchoolStandardList.FindLast((p) => { return p.Id == dto.SchoolStandard.Id; });
            this.txtAmount.Text = Convert.ToString(dto.Amount);
        }

        protected override Boolean ValidateForm()
        {

            return true;
        }

    }

}