using System;

using BinAff.Presentation.Library.Extension;

using Fac = Sparkle.Configuration.Facade.District;

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
            this.cboState.Bind((this.FormDto as Fac.FormDto).StateList, "Name");
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
            Fac.Dto dto = base.FormDto.Dto as Fac.Dto;
            dto.Name = this.txtName.Text;
            dto.State = this.cboState.SelectedItem as Facade.State.Dto;
        }

        protected override void AssignFormControls()
        {
            Fac.Dto dto = base.FormDto.Dto as Fac.Dto;
            this.txtName.Text = dto.Name;
            this.cboState.SelectedItem = (this.FormDto as Fac.FormDto).StateList.FindLast((p) => { return p.Id == dto.State.Id; });
        }

        protected override Boolean ValidateForm()
        {

            return true;
        }

    }

}