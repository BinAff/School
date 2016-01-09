using System;

namespace Sparkle.School.WinForm
{

    public partial class Menu : Sparkle.Core.Presentation.PopupMenu
    {

        public Menu()
            : base()
        {
            InitializeComponent();
        }

        private void btnSchoolInformation_Click(object sender, EventArgs e)
        {

        }

        private void btnCourseManagement_Click(object sender, EventArgs e)
        {

        }

        private void btnSyllabusManagement_Click(object sender, EventArgs e)
        {

        }

        private void btnFeeManagement_Click(object sender, EventArgs e)
        {
            new Billing.WinForm.Fee.Form().Show();
            this.Close();
        }

        private void btnFineManagement_Click(object sender, EventArgs e)
        {
            new Billing.WinForm.Fine.Form().Show();
            this.Close();
        }

        private void btnConcessionManagement_Click(object sender, EventArgs e)
        {
            new Billing.WinForm.Concession.Form().Show();
            this.Close();
        }

        private void btnLibraryManagement_Click(object sender, EventArgs e)
        {

        }

        private void btnLaboratoryManagement_Click(object sender, EventArgs e)
        {

        }

        private void btnAdmitionManagement_Click(object sender, EventArgs e)
        {

        }

        private void btnExaminationManagement_Click(object sender, EventArgs e)
        {

        }

        private void btnResultManagement_Click(object sender, EventArgs e)
        {

        }

        private void btnEventManagement_Click(object sender, EventArgs e)
        {

        }

        private void btnAnnouncementManagement_Click(object sender, EventArgs e)
        {

        }

    }

}