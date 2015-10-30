using System;

using BinAff.Presentation.Library.Extension;

using CountryFac = Vanilla.Configuration.Facade.Country;
using StateFac = Vanilla.Configuration.Facade.State;

namespace Sparkle.Student.WinForm
{

    public partial class StudentForm : BinAff.Presentation.Library.Form
    {

        private Facade.Server facade;
        private Facade.FormDto formDto;

        public StudentForm()
            :base()
        {
            InitializeComponent();
            this.formDto = new Facade.FormDto
            {
                Dto = new Facade.Dto(),
            };
            facade = new Facade.Server(this.formDto);
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            this.facade.LoadForm();
        }

        private void StudentForm_Shown(object sender, EventArgs e)
        {
            this.cboCountry.Bind(this.formDto.CountryList, "Name");
            this.cboState.Bind(this.formDto.StateList, "Name");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Validate
            this.Convert();
            this.facade.Add();
        }

        private void Convert()
        {
            this.formDto.Dto.FirstName = this.txtFirstName.Text;
            this.formDto.Dto.MiddleName = this.txtMiddleName.Text;
            this.formDto.Dto.LastName = this.txtLastName.Text;
            this.formDto.Dto.Address = this.txtAddress.Text;
            this.formDto.Dto.State = this.cboState.SelectedItem as StateFac.Dto;
            this.formDto.Dto.Country = this.cboCountry.SelectedItem as CountryFac.Dto;
        }

    }

}