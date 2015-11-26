using System;

using Lib = BinAff.Presentation.Library;
using BinAff.Presentation.Library.Extension;

using Sparkle.Core.Facade;

namespace Sparkle.Core.Presentation
{

    public partial class Form : Lib.Form
    {

        protected FormDto FormDto { get; private set; }
        protected Server Facade { get; private set; }

        protected String ListDisplayName { get; set; }
        protected String FormName { get; set; }

        private FormControl formControl;
        protected FormControl FormControl
        {
            private get
            {
                return this.formControl;
            }
            set
            {

                this.formControl = value;
                this.spcMain.Panel2.Controls.Add(this.formControl);
                this.formControl.Dock = System.Windows.Forms.DockStyle.Fill;
                this.formControl.BringToFront();
            }
        }

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
            this.FormControl.FormDto = this.FormDto;
            if (!String.IsNullOrEmpty(this.FormName))
            {
                this.Name = this.FormName.Trim() + " Manager" ;
            }
            this.Facade.LoadForm();
        }

        private void Form_Shown(object sender, System.EventArgs e)
        {
            if (DesignMode) return;
            this.Bind();
        }

        private void btnRefresh_Click(object sender, System.EventArgs e)
        {
            this.Reset();
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            if (this.ValidateForm())
            {
                this.AssignDto();
                this.FormDto.Dto.Id = 0;
                this.Facade.Add();
                if (!this.Facade.IsError)
                {
                    this.FormDto.DtoList.Add(this.FormDto.Dto);
                    if (this.cboList.Items.Count > 0)
                    {
                        this.cboList.Items.Add(this.FormDto.Dto);
                    }
                    else
                    {
                        this.cboList.Bind(this.FormDto.DtoList, this.ListDisplayName);
                    }
                    this.formControl.ResetForm();
                }
                new Lib.MessageBox().Show(this.Facade.DisplayMessageList);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (this.ValidateForm())
            {
                this.AssignDto();
                this.Facade.Change();
                if (!this.Facade.IsError)
                {
                    this.formControl.ResetForm();
                    this.cboList.Bind(this.FormDto.DtoList, this.ListDisplayName);
                }
                new Lib.MessageBox().Show(this.Facade.DisplayMessageList);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.cboList.SelectedItem == null) return;
            if (new Lib.MessageBox().Confirm("Do you wan't to delete?") == System.Windows.Forms.DialogResult.OK)
            {
                this.Facade.Delete();
                if (!this.Facade.IsError)
                {
                    this.FormDto.DtoList.Remove(this.cboList.SelectedItem as Dto);
                    this.cboList.Items.Remove(this.cboList.SelectedItem as Dto);
                    this.formControl.ResetForm();
                }
                new Lib.MessageBox().Show(this.Facade.DisplayMessageList);
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

        #endregion

        protected void Reset()
        {
            this.Bind();
            this.cboList.SelectedIndex = -1;
            this.cboList.Text = String.Empty;
            this.formControl.ResetForm();
        }

        protected void Bind()
        {
            this.formControl.Bind();
            this.cboList.Bind((this.FormDto as Facade.FormDto).DtoList, this.ListDisplayName);
        }

        protected void AssignDto()
        {
            this.formControl.AssignDto();
        }

        protected void AssignFormControls()
        {
            this.formControl.AssignFormControls();
        }

        protected Boolean ValidateForm()
        {
            return this.formControl.ValidateForm();
        }

        #region Mandatory Hook

        protected virtual FormDto InstantiateFormDto()
        {
            throw new System.NotImplementedException();
        }

        protected virtual Server InstantiateFacade()
        {
            throw new System.NotImplementedException();
        }

        #endregion

    }

}