using System;

using BinAff.Presentation.Library.Extension;

using Sparkle.Core.Facade;

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
            if (this.ValidateForm())
            {
                this.AssignDto();
                this.FormDto.Dto.Id = 0;
                this.Facade.Add();
                new BinAff.Presentation.Library.MessageBox().Show(this.Facade.DisplayMessageList);
                this.FormDto.DtoList.Add(this.FormDto.Dto);
                if (this.cboList.Items.Count > 0)
                {
                    this.cboList.Items.Add(this.FormDto.Dto);
                }
                else
                {
                    this.cboList.Bind(this.FormDto.DtoList, this.ListDisplayName);
                }
            }
        }

        private void cboList_Click(object sender, EventArgs e)
        {
            if (this.cboList.SelectedItem != null)
            {
                this.FormDto.Dto = this.cboList.SelectedItem as Dto;
                this.AssignFormControls();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (this.ValidateForm())
            {
                this.AssignDto();
                this.Facade.Change();
                new BinAff.Presentation.Library.MessageBox().Show(this.Facade.DisplayMessageList);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Facade.Delete();
            new BinAff.Presentation.Library.MessageBox().Show(this.Facade.DisplayMessageList);
            this.cboList.Items.Remove(this.cboList.SelectedItem as Dto);
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

        protected virtual Boolean ValidateForm()
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