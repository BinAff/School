﻿namespace Sparkle.Billing.WinForm.Fine
{

    public partial class Form : Sparkle.Core.Presentation.Form
    {

        public Form()
        {
            InitializeComponent();
            base.ListDisplayName = "Name";
            base.FormName = "Fine";
        }

        #region Framework

        protected override void InstantiateFormControl()
        {
            base.FormControl = new FormControl();
        }

        #endregion

    }

}