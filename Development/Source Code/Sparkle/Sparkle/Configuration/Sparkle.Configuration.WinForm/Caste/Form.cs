﻿using FacLib = Sparkle.Core.Facade;

using Fac = Sparkle.Configuration.Facade.Caste;

namespace Sparkle.Configuration.WinForm.Caste
{

    public partial class Form : Sparkle.Core.Presentation.Form
    {

        public Form()
        {
            base.FormControl = new FormControl();
            InitializeComponent();
            base.ListDisplayName = "Name";
            base.FormName = "Caste";
        }

        #region Framework

        protected override FacLib.FormDto InstantiateFormDto()
        {
            return new Fac.FormDto
            {
                Dto = new Fac.Dto(),
            };
        }

        protected override FacLib.Server InstantiateFacade()
        {
            return new Fac.Server(base.FormDto as Fac.FormDto);
        }

        #endregion

    }

}