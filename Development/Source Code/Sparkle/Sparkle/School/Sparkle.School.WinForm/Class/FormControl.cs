using System;

using BinAff.Presentation.Library.Extension;

using Fac = Sparkle.School.Facade.Class;

namespace Sparkle.School.WinForm.Class
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
            this.cboStandard.Bind((this.FormDto as Fac.FormDto).StandardList, "Name");
            this.cboSection.Bind((this.FormDto as Fac.FormDto).SectionList, "Name");
        }

        protected override void ResetForm()
        {
            this.cboStandard.Text = String.Empty;
            this.cboStandard.SelectedIndex = -1;
            this.cboSection.Text = String.Empty;
            this.cboSection.SelectedIndex = -1;
            this.cboStandard.Focus();
        }

        protected override void AssignDto()
        {
            Fac.Dto dto = base.FormDto.Dto as Fac.Dto;
            dto.Standard = this.cboStandard.SelectedItem as Facade.Standard.Dto;
            dto.Section = this.cboSection.SelectedItem as Facade.Section.Dto;
        }

        protected override void AssignFormControls()
        {
            Fac.Dto dto = base.FormDto.Dto as Fac.Dto;
            this.cboStandard.SelectedItem = (this.FormDto as Fac.FormDto).StandardList.FindLast((p) => { return p.Id == dto.Standard.Id; });
            this.cboSection.SelectedItem = (this.FormDto as Fac.FormDto).SectionList.FindLast((p) => { return p.Id == dto.Section.Id; });
        }

        protected override Boolean ValidateForm()
        {

            return true;
        }

    }

}