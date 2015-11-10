using System;

using BinAff.Presentation.Library.Extension;

using StateFac = Vanilla.Configuration.Facade.State;

namespace Sparkle.Student.WinForm.Student
{

    public partial class FormControl : Core.Presentation.FormControl
    {

        public FormControl()
        {
            InitializeComponent();
        }

        protected override void Bind()
        {
            this.cboCurrentAddressCountry.Bind((base.FormDto as Facade.FormDto).CountryList, "Name");
            this.cboCurrentAddressState.Bind((base.FormDto as Facade.FormDto).StateList, "Name");
            this.cboCountry.Bind((base.FormDto as Facade.FormDto).CountryList, "Name");
            this.cboPermanentAddressCountry.Bind((base.FormDto as Facade.FormDto).CountryList, "Name");
            this.cboPermanentAddressState.Bind((base.FormDto as Facade.FormDto).StateList, "Name");
        }

        protected override void AssignDto()
        {
            Facade.Dto dto = base.FormDto.Dto as Facade.Dto;
            dto.FirstName = this.txtFirstName.Text;
            dto.MiddleName = this.txtMiddleName.Text;
            dto.LastName = this.txtLastName.Text;
            dto.Address = this.txtPermanentAddress.Text;
            dto.State = this.cboPermanentAddressState.SelectedItem as StateFac.Dto;
            dto.City = this.txtPermanentAddressCity.Text;
            dto.Pin = Convert.ToInt32(this.txtPermanentAddressPin.Text);
        }

        protected override void AssignFormControls()
        {
            Facade.Dto dto = base.FormDto.Dto as Facade.Dto;
            this.txtFirstName.Text = dto.FirstName;
            this.txtMiddleName.Text = dto.MiddleName;
            this.txtLastName.Text = dto.LastName;
            this.txtPermanentAddress.Text = dto.Address;
            this.cboPermanentAddressState.SelectedItem = (this.FormDto as Facade.FormDto).StateList.FindLast((p) => { return p.Id == dto.State.Id; });
            this.cboPermanentAddressCountry.SelectedItem = (this.FormDto as Facade.FormDto).CountryList.FindLast((p) => { return p.Id == dto.State.Country.Id; });
            this.txtPermanentAddressCity.Text = dto.City;
            this.txtRollNumber.Text = dto.Pin.ToString();
        }

        protected override Boolean ValidateForm()
        {
            return true;
        }

    }

}