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
            //new Sparkle.Configuration.WinForm.State().Show();
            this.Close();
        }

        private void btnCountryManagement_Click(object sender, EventArgs e)
        {
            new Sparkle.Configuration.WinForm.Country.Form().Show();
            this.Close();
        }

    }

}