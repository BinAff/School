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
            new Sparkle.Configuration.WinForm.State.Form().Show();
            this.Close();
        }

        private void btnCountryManagement_Click(object sender, EventArgs e)
        {
            new Sparkle.Configuration.WinForm.Country.Form().Show();
            this.Close();
        }

        private void btnCasteManagement_Click(object sender, EventArgs e)
        {
            new Sparkle.Configuration.WinForm.Caste.Form().Show();
            this.Close();
        }

        private void btnSubCasteManagement_Click(object sender, EventArgs e)
        {
            new Sparkle.Configuration.WinForm.SubCaste.Form().Show();
            this.Close();
        }

        private void btnGenderManagement_Click(object sender, EventArgs e)
        {
            new Sparkle.Configuration.WinForm.Gender.Form().Show();
            this.Close();
        }

        private void btnReligionManagement_Click(object sender, EventArgs e)
        {
            new Sparkle.Configuration.WinForm.Religion.Form().Show();
            this.Close();
        }

        private void btnDistrictManagement_Click(object sender, EventArgs e)
        {
            new Sparkle.Configuration.WinForm.District.Form().Show();
            this.Close();
        }

        private void btnRelationshipManagement_Click(object sender, EventArgs e)
        {
            new Sparkle.Configuration.WinForm.Relationship.Form().Show();
            this.Close();
        }

        private void btnMotherTongueManagement_Click(object sender, EventArgs e)
        {
            new Sparkle.Configuration.WinForm.MotherTongue.Form().Show();
            this.Close();
        }

    }

}