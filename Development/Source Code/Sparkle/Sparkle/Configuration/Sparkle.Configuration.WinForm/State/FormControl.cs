using System;

using BinAff.Presentation.Library.Extension;

using Fac = Sparkle.Configuration.Facade.State;

namespace Sparkle.Configuration.WinForm.State
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
            this.cboCountry.Bind((this.FormDto as Fac.FormDto).CountryList, "Name");
        }

        protected override void ClearForm()
        {
            this.txtName.Text = String.Empty;
            this.cboCountry.SelectedIndex = -1;
            this.cboCountry.Text = String.Empty;
            this.txtName.Focus();
        }

        protected override void AssignDto()
        {
            Fac.Dto dto = base.FormDto.Dto as Fac.Dto;
            dto.Name = this.txtName.Text;
            dto.Country = this.cboCountry.SelectedItem as Facade.Country.Dto;
        }

        protected override void AssignFormControls()
        {
            Fac.Dto dto = base.FormDto.Dto as Fac.Dto;
            this.txtName.Text = dto.Name;
            this.cboCountry.SelectedItem = (this.FormDto as Fac.FormDto).CountryList.FindLast((p) => { return p.Id == dto.Country.Id; });
        }

        protected override Boolean ValidateForm()
        {

            return true;
        }

    }

}