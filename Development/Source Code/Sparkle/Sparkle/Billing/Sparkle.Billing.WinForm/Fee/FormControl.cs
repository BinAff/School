using System;

using BinAff.Presentation.Library.Extension;

using Bil = Sparkle.Billing.Facade;

using Sch = Sparkle.School.Facade;

using Stu = Sparkle.Student.Facade;

using Fac = Sparkle.Billing.Facade.Fee;

namespace Sparkle.Billing.WinForm.Fee
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
            this.cboFeeDefinition.Bind((this.FormDto as Fac.FormDto).FeeDefinationList, "Name");
            this.cboStandard.Bind((this.FormDto as Fac.FormDto).SchoolStandardList, "Name");
            this.cboCategory.Bind((this.FormDto as Fac.FormDto).CategoryList, "Name");
        }

        protected override void ClearForm()
        {
            this.cboFeeGroup.Text = String.Empty;
            this.cboFeeGroup.SelectedIndex = -1;
            this.cboFeeDefinition.Text = String.Empty;
            this.cboFeeDefinition.SelectedIndex = -1;
            this.cboStandard.Text = String.Empty;
            this.cboStandard.SelectedIndex = -1;
            this.cboCategory.Text = String.Empty;
            this.cboCategory.SelectedIndex = -1;
            this.txtAmount.Text = String.Empty;
            this.cboFeeGroup.Focus();
        }

        protected override void AssignDto()
        {
            Fac.Dto dto = base.FormDto.Dto as Fac.Dto;
            dto.FeeGroup = this.cboFeeGroup.SelectedItem as Bil.Fee.Group.Dto;
            dto.FeeDefination = this.cboFeeDefinition.SelectedItem as Bil.Fee.Definition.Dto;
            dto.SchoolStandard = this.cboStandard.SelectedItem as Sch.Standard.Dto;
            dto.Category = this.cboCategory.SelectedItem as Stu.Category.Dto;
            dto.Amount = Convert.ToDouble(this.txtAmount.Text);
        }

        protected override void AssignFormControls()
        {
            Fac.Dto dto = base.FormDto.Dto as Fac.Dto;
            this.cboFeeGroup.SelectedItem = (this.FormDto as Fac.FormDto).FeeGroupList.FindLast((p) => { return p.Id == dto.FeeGroup.Id; });
            this.cboFeeDefinition.SelectedItem = (this.FormDto as Fac.FormDto).FeeDefinationList.FindLast((p) => { return p.Id == dto.FeeDefination.Id; });
            this.cboStandard.SelectedItem = (this.FormDto as Fac.FormDto).SchoolStandardList.FindLast((p) => { return p.Id == dto.SchoolStandard.Id; });
            this.cboCategory.SelectedItem = (this.FormDto as Fac.FormDto).CategoryList.FindLast((p) => { return p.Id == dto.Category.Id; });
            this.txtAmount.Text = Convert.ToString(dto.Amount);
        }

        protected override Boolean ValidateForm()
        {

            return true;
        }

    }

}