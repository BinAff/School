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
            this.cboCountry.Bind((base.FormDto as Facade.FormDto).CountryList, "Name");
            this.cboState.Bind((base.FormDto as Facade.FormDto).StateList, "Name");
        }

        protected override void AssignDto()
        {
            Facade.Dto dto = base.FormDto.Dto as Facade.Dto;
            dto.FirstName = this.txtFirstName.Text;
            dto.MiddleName = this.txtMiddleName.Text;
            dto.LastName = this.txtLastName.Text;
            dto.Address = this.txtAddress.Text;
            dto.State = this.cboState.SelectedItem as StateFac.Dto;
            dto.City = this.txtCity.Text;
            dto.Pin = Convert.ToInt32(this.txtPin.Text);
        }

        protected override void AssignFormControls()
        {
            Facade.Dto dto = base.FormDto.Dto as Facade.Dto;
            this.txtFirstName.Text = dto.FirstName;
            this.txtMiddleName.Text = dto.MiddleName;
            this.txtLastName.Text = dto.LastName;
            this.txtAddress.Text = dto.Address;
            this.cboState.SelectedItem = (this.FormDto as Facade.FormDto).StateList.FindLast((p) => { return p.Id == dto.State.Id; });
            this.cboCountry.SelectedItem = (this.FormDto as Facade.FormDto).CountryList.FindLast((p) => { return p.Id == dto.State.Country.Id; });
            this.txtCity.Text = dto.City;
            this.txtPin.Text = dto.Pin.ToString();
        }

        protected override Boolean ValidateForm()
        {
            return true;
        }

    }

}