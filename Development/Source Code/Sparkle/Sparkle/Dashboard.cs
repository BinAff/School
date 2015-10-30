using System;
using System.Windows.Forms;

namespace Sparkle
{

    public partial class Dashboard : Form
    {

        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            //Authenticate
        }

        private void btnSchoolAddminstration_Click(object sender, EventArgs e)
        {
            new Sparkle.School.WinForm.Menu().ShowDialog(this);
        }

        private void btnOfficeAdministration_Click(object sender, EventArgs e)
        {
            new Sparkle.Office.WinForm.Menu().ShowDialog(this);
        }

        private void btnStudentAdminstration_Click(object sender, EventArgs e)
        {
            new Sparkle.Student.WinForm.Menu().ShowDialog(this);
        }

        private void btnHRAdministration_Click(object sender, EventArgs e)
        {
            new Sparkle.HR.WinForm.Menu().ShowDialog(this);
        }

        private void btnITAdministration_Click(object sender, EventArgs e)
        {
            new Sparkle.IT.WinForm.Menu().ShowDialog(this);
        }

        private void btnAdmitionManagement_Click(object sender, EventArgs e)
        {

        }

        private void btnFeeCollection_Click(object sender, EventArgs e)
        {

        }

        private void btnStudentRegistration_Click(object sender, EventArgs e)
        {

        }

    }

}