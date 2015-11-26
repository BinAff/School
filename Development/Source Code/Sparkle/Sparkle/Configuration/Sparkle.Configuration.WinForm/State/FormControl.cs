using System;
using System.Linq;

using BinAff.Presentation.Library.Extension;

namespace Sparkle.Configuration.WinForm.State
{

    public partial class FormControl : Sparkle.Core.Presentation.FormControl
    {

        public FormControl()
        {
            InitializeComponent();
        }

        protected override void Bind()
        {
            this.cboCountry.Bind((this.FormDto as Facade.State.FormDto).CountryList, "Name");
        }

        protected override void ResetForm()
        {
            this.txtName.Text = String.Empty;
            this.cboCountry.SelectedIndex = -1;
            this.cboCountry.Text = String.Empty;
            this.txtName.Focus();
        }

        protected override void AssignDto()
        {
            Facade.State.Dto dto = base.FormDto.Dto as Facade.State.Dto;
            dto.Name = this.txtName.Text;
            dto.Country = this.cboCountry.SelectedItem as Facade.Country.Dto;
        }

        protected override void AssignFormControls()
        {
            Facade.State.Dto dto = base.FormDto.Dto as Facade.State.Dto;
            this.txtName.Text = dto.Name;
            this.cboCountry.SelectedItem = (this.FormDto as Facade.State.FormDto).CountryList.FindLast((p) => { return p.Id == dto.Country.Id; });
        }

        protected override Boolean ValidateForm()
        {

            return true;
        }

    }

}