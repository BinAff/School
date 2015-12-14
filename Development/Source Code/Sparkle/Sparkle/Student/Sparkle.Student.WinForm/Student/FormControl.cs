using System;

using BinAff.Presentation.Library.Extension;

using SchlFac = Sparkle.School.Facade;

using Fac = Sparkle.Student.Facade;

namespace Sparkle.Student.WinForm.Student
{

    public partial class FormControl : Core.Presentation.FormControl
    {

        public FormControl()
            : base()
        {
            InitializeComponent();
        }

        protected override Core.Facade.Server InstantiateFacade()
        {
            return new Fac.Server(base.FormDto as Fac.FormDto);
        }

        protected override void AttachDtoToChildControl()
        {
            this.ucPersonalInformation.FormDto.Dto = ((this.FormDto as Fac.FormDto).Dto as Fac.Dto).PersonalInformation;
        }

        protected override void Bind()
        {
            this.cboStandard.Bind((this.FormDto as Fac.FormDto).StandardList, "Name");
            this.cboSection.Bind((this.FormDto as Fac.FormDto).SectionList, "Name");
        }

        protected override void ClearForm()
        {
            this.txtFirstName.Text = String.Empty;
            this.txtMiddleName.Text = String.Empty;
            this.txtLastName.Text = String.Empty;
            this.cboStandard.SelectedIndex = -1;
            this.cboStandard.Text = String.Empty;
            this.cboSection.SelectedIndex = -1;
            this.cboSection.Text = String.Empty;
            this.txtRollNumber.Text = String.Empty;
            this.tbcMain.SelectTab(this.tbpGeneral);
            this.txtFirstName.Focus();
        }

        protected override void AssignDto()
        {
            Facade.Dto dto = base.FormDto.Dto as Facade.Dto;
            dto.FirstName = this.txtFirstName.Text;
            dto.MiddleName = this.txtMiddleName.Text;
            dto.LastName = this.txtLastName.Text;
            dto.Standard = this.cboStandard.SelectedItem as SchlFac.Standard.Dto;
            dto.Section = this.cboSection.SelectedItem as SchlFac.Section.Dto;
            dto.RollNumber = Convert.ToInt16(this.txtRollNumber.Text.Trim());
            dto.Category.Id = 1; //Hardcoded
        }

        protected override void AssignFormControls()
        {
            Facade.Dto dto = base.FormDto.Dto as Facade.Dto;
            this.txtFirstName.Text = dto.FirstName;
            this.txtMiddleName.Text = dto.MiddleName;
            this.txtLastName.Text = dto.LastName;
            this.cboStandard.SelectedItem = (this.FormDto as Facade.FormDto).StandardList.FindLast((p) => { return p.Id == dto.Standard.Id; });
            this.cboSection.SelectedItem = (this.FormDto as Facade.FormDto).SectionList.FindLast((p) => { return p.Id == dto.Section.Id; });
            this.txtRollNumber.Text = Convert.ToString(dto.RollNumber);
            this.tbcMain.SelectTab(this.tbpGeneral);
            this.txtFirstName.Focus();
        }

        protected override Boolean ValidateForm()
        {
            return true;
        }

    }

}