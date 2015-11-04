

using BinAff.Presentation.Library.Extension;

using Sparkle.Core.Facade;
using System;

namespace Sparkle.Core.Presentation
{

    public partial class Form : BinAff.Presentation.Library.Form
    {

        protected FormDto FormDto { get; private set; }
        protected Server Facade { get; private set; }

        protected String ListDisplayName { get; set; }

        public Form()
            : base()
        {
            InitializeComponent();
        }

        #region Events

        private void Form_Load(object sender, System.EventArgs e)
        {
            if (DesignMode) return;
            this.FormDto = this.InstantiateFormDto();
            this.Facade = this.InstantiateFacade();
            this.Facade.LoadForm();
        }
        
        private void Form_Shown(object sender, System.EventArgs e)
        {
            if (DesignMode) return;
            this.Bind();
            this.cboList.Bind((this.FormDto as Facade.FormDto).DtoList, this.ListDisplayName);
        }

        private void btnRefresh_Click(object sender, System.EventArgs e)
        {

        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            //Validate
            this.AssignDto();
            this.Facade.Add();
        }

        private void cboList_Click(object sender, EventArgs e)
        {
            if (this.cboList.SelectedItem != null)
            {
                this.FormDto.Dto = this.cboList.SelectedItem as Dto;
                this.AssignFormControls();
            }
        }

        #endregion

        #region Mandatory Hook

        protected virtual FormDto InstantiateFormDto()
        {
            throw new System.NotImplementedException();
        }

        protected virtual Server InstantiateFacade()
        {
            throw new System.NotImplementedException();
        }

        protected virtual void Bind()
        {
            throw new System.NotImplementedException();
        }

        protected virtual void AssignDto()
        {
            throw new System.NotImplementedException();
        }

        protected virtual void AssignFormControls()
        {
            throw new System.NotImplementedException();
        }

        #endregion

    }

}