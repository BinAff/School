using System;

namespace Sparkle.Student.WinForm
{

    public partial class Menu : Sparkle.Core.Presentation.PopupMenu
    {

        public Menu()
            :base()
        {
            InitializeComponent();
        }

        private void btnStudentInformation_Click(object sender, EventArgs e)
        {
            new StudentForm().Show();
            this.Close();
        }

        private void btnAttendenceManagement_Click(object sender, EventArgs e)
        {

        }

    }

}