using System;

namespace Sparkle.Office.WinForm
{

    public partial class Menu : Sparkle.Core.Presentation.PopupMenu
    {

        public Menu()
            : base()
        {
            InitializeComponent();
        }

        private void btnStateManagement_Click(object sender, EventArgs e)
        {
            new Configuration.WinForm.State.Form().Show();
            this.Close();
        }

        private void btnCountryManagement_Click(object sender, EventArgs e)
        {
            new Configuration.WinForm.Country.Form().Show();
            this.Close();
        }

        private void btnCasteManagement_Click(object sender, EventArgs e)
        {
            new Configuration.WinForm.Caste.Form().Show();
            this.Close();
        }

        private void btnSubCasteManagement_Click(object sender, EventArgs e)
        {
            new Configuration.WinForm.SubCaste.Form().Show();
            this.Close();
        }

        private void btnGenderManagement_Click(object sender, EventArgs e)
        {
            new Configuration.WinForm.Gender.Form().Show();
            this.Close();
        }

        private void btnReligionManagement_Click(object sender, EventArgs e)
        {
            new Configuration.WinForm.Religion.Form().Show();
            this.Close();
        }

        private void btnDistrictManagement_Click(object sender, EventArgs e)
        {
            new Configuration.WinForm.District.Form().Show();
            this.Close();
        }

        private void btnRelationshipManagement_Click(object sender, EventArgs e)
        {
            new Configuration.WinForm.Relationship.Form().Show();
            this.Close();
        }

        private void btnMotherTongueManagement_Click(object sender, EventArgs e)
        {
            new Configuration.WinForm.MotherTongue.Form().Show();
            this.Close();
        }

        private void btnOcupationManagement_Click(object sender, EventArgs e)
        {
            new Configuration.WinForm.Occupation.Form().Show();
            this.Close();
        }

        private void btnFeeGroupManagement_Click(object sender, EventArgs e)
        {
            new Billing.WinForm.Fee.Group.Form().Show();
            this.Close();
        }

        private void btnFeeDefinitionManagement_Click(object sender, EventArgs e)
        {
            new Billing.WinForm.Fee.Definition.Form().Show();
            this.Close();
        }

        private void btnFineTypeManagement_Click(object sender, EventArgs e)
        {
            new Billing.WinForm.Fine.Type.Form().Show();
            this.Close();
        }

        private void btnFineDefinitionManagement_Click(object sender, EventArgs e)
        {
            new Billing.WinForm.Fine.Definition.Form().Show();
            this.Close();
        }

        private void btnStudentCategoryManagement_Click(object sender, EventArgs e)
        {
            new Student.WinForm.Category.Form().Show();
            this.Close();
        }

        private void btnFrequencyManagement_Click(object sender, EventArgs e)
        {
            new Configuration.WinForm.Frequency.Form().Show();
            this.Close();
        }

    }

}