using System;

using BinAff.Presentation.Library.Extension;

namespace Sparkle.Configuration.WinForm.District
{

    public partial class FormControl : Sparkle.Core.Presentation.FormControl
    {

        public FormControl()
        {
            InitializeComponent();
        }

        protected override void Bind()
        {
            this.cboState.Bind((this.FormDto as Facade.District.FormDto).StateList, "Name");
        }

        protected override void ResetForm()
        {
            this.txtName.Text = String.Empty;
            this.cboState.SelectedIndex = -1;
            this.cboState.Text = String.Empty;
            this.txtName.Focus();
        }

        protected override void AssignDto()
        {
            Facade.District.Dto dto = base.FormDto.Dto as Facade.District.Dto;
            dto.Name = this.txtName.Text;
            dto.State = this.cboState.SelectedItem as Facade.State.Dto;
        }

        protected override void AssignFormControls()
        {
            Facade.District.Dto dto = base.FormDto.Dto as Facade.District.Dto;
            this.txtName.Text = dto.Name;
            this.cboState.SelectedItem = (this.FormDto as Facade.District.FormDto).StateList.FindLast((p) => { return p.Id == dto.State.Id; });
        }

        protected override Boolean ValidateForm()
        {

            return true;
        }

    }

}