using System;

using Lib = BinAff.Presentation.Library;
using BinAff.Presentation.Library.Extension;

using Sparkle.Core.Facade;

namespace Sparkle.Core.Presentation
{

    public partial class Form : Lib.Form
    {

        protected FormDto FormDto { get; private set; }

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
            if (!String.IsNullOrEmpty(this.FormName))
            {
                this.Name = this.FormName.Trim() + " Manager";
            }
        }

        #region Events

        private void Form_Load(object sender, System.EventArgs e)
        {
            if (DesignMode) return;
            this.InstantiateFormControl();
        }

        private void Form_Shown(object sender, System.EventArgs e)
        {
            if (DesignMode) return;
            this.formControl.LoadForm();
            this.formControl.Facade.LoadForm();
            this.FormDto = this.FormControl.FormDto as FormDto;
            this.Bind();
        }

        private void btnRefresh_Click(object sender, System.EventArgs e)
        {
            this.Reset();
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            if (!this.formControl.Save()) return;
            if (!this.formControl.Facade.IsError)
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
            new Lib.MessageBox().Show(this.formControl.Facade.DisplayMessageList);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!this.formControl.Change()) return;
            if (!this.formControl.Facade.IsError)
            {
                this.formControl.ResetForm();
                this.cboList.Bind(this.FormDto.DtoList, this.ListDisplayName);
                this.cboList.Text = String.Empty;
                this.cboList.SelectedIndex = -1;
            }
            new Lib.MessageBox().Show(this.formControl.Facade.DisplayMessageList);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.cboList.SelectedItem == null) return;
            if (new Lib.MessageBox().Confirm("Do you wan't to delete?") == System.Windows.Forms.DialogResult.OK)
            {
                this.formControl.Facade.Delete();
                if (!this.formControl.Facade.IsError)
                {
                    this.FormDto.DtoList.Remove(this.cboList.SelectedItem as Dto);
                    this.cboList.Items.Remove(this.cboList.SelectedItem as Dto);
                    this.formControl.ResetForm();
                }
                new Lib.MessageBox().Show(this.formControl.Facade.DisplayMessageList);
            }
        }

        private void cboList_Click(object sender, EventArgs e)
        {
            if (this.cboList.SelectedItem != null)
            {
                this.FormDto.Dto = this.cboList.SelectedItem as Dto;
                this.formControl.AssignFormControls();
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
            this.cboList.Bind((this.FormDto as Facade.FormDto).DtoList, this.ListDisplayName);
        }
        
        #region Mandatory Hook

        protected virtual void InstantiateFormControl()
        {
            throw new NotImplementedException();
        }

        #endregion

    }

}