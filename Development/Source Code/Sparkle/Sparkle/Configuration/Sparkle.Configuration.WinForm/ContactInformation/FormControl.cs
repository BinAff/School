using System;

using BinAff.Presentation.Library.Extension;

using Fac = Sparkle.Configuration.Facade.ContactInformation;

namespace Sparkle.Configuration.WinForm.ContactInformation
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
            this.cboState.Bind((this.FormDto as Fac.FormDto).StateList, "Name");
            this.cboDistrict.Bind((this.FormDto as Fac.FormDto).DistrictList, "Name");
        }

        protected override void ResetForm()
        {
            this.txtAddress.Text = String.Empty;
            this.txtAddress.Focus();
        }

        protected override void AssignDto()
        {
            Fac.Dto dto = base.FormDto.Dto as Fac.Dto;
            dto.Address = this.txtAddress.Text.Trim();
            dto.District = this.cboDistrict.SelectedItem as Facade.District.Dto;
            dto.Pin = Convert.ToInt32(this.txtPin.Text.Trim());
            dto.Landline = Convert.ToInt32(this.txtLandline.Text.Trim());
        }

        protected override void AssignFormControls()
        {
            Fac.Dto dto = base.FormDto.Dto as Fac.Dto;
            this.txtAddress.Text = dto.Address;
            this.cboDistrict.SelectedItem = dto.District; ////////
            this.cboDistrict.SelectedItem = dto.District; ////////
            this.cboDistrict.SelectedItem = dto.District; ////////
            this.txtPin.Text = Convert.ToString(dto.Pin);
            this.txtLandline.Text = Convert.ToString(dto.Landline);
        }

        protected override Boolean ValidateForm()
        {

            return true;
        }

    }

}