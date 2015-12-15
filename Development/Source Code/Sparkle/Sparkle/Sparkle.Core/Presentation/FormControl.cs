using System;
using System.Windows.Forms;

using Sparkle.Core.Facade;

namespace Sparkle.Core.Presentation
{

    public partial class FormControl : UserControl
    {

        public FormDto FormDto { get; protected internal set; }
        protected internal Server Facade { get; set; }

        protected ErrorProvider ErrorProvider
        {
            get
            {
                return this.errorProvider;
            }
        }

        private delegate void F(FormControl formControl);

        public FormControl()
        {
            InitializeComponent();
        }

        private void FormControl_Load(object sender, EventArgs e)
        {

        }

        public void LoadForm()
        {
            this.InistantiateControls();
            this.BindDataToControls();
        }

        internal Boolean Save()
        {
            if (this.ValidateForm())
            {
                this.AssignDtoFromControls();
                this.FormDto.Dto.Id = 0;
                this.Facade.Add();
                return !this.Facade.IsError;
            }
            return false;
        }

        internal Boolean Change()
        {
            if (this.ValidateForm())
            {
                this.AssignDtoFromControls();
                this.Facade.Change();
                return !this.Facade.IsError;
            }
            return false;
        }

        internal void ResetForm()
        {
            this.RecurseFormControls(this, delegate(FormControl frmCtrl)
            {
                frmCtrl.ClearForm();
            });
        }

        public void PopulateDtoToFormControl()
        {
            this.RecurseFormControls(this, delegate(FormControl frmCtrl)
            {
                frmCtrl.AttachDtoToChildControl();
                frmCtrl.AssignFormControls();
            });
        }

        private void InistantiateControls()
        {
            this.RecurseFormControls(this, delegate(FormControl frmCtrl)
            {
                frmCtrl.Facade = frmCtrl.InstantiateFacade();
                frmCtrl.FormDto = frmCtrl.Facade.FormDto as FormDto;
            });
        }

        private void BindDataToControls()
        {
            this.RecurseFormControls(this, delegate(FormControl frmCtrl)
            {
                frmCtrl.AttachDtoToChildControl();
                frmCtrl.Facade.LoadListForControl();
                frmCtrl.Bind();
            });
        }

        private void AssignDtoFromControls()
        {
            this.RecurseFormControls(this, delegate(FormControl frmCtrl)
            {
                frmCtrl.AssignDto();
            });
        }

        private void RecurseFormControls(System.Windows.Forms.Control ctrl, F action)
        {
            FormControl frmCtrl = ctrl as FormControl;
            if (frmCtrl != null)
            {
                action(frmCtrl);
            }
            Control.ControlCollection colection = ctrl.Controls;
            if (colection.Count > 0)
            {
                foreach (Control ctrl1 in colection)
                {
                    this.RecurseFormControls(ctrl1, action);
                }
            }
            else
            {
                return;
            }
        }

        #region Mandatory Hook

        protected internal virtual void Bind()
        {
            throw new System.NotImplementedException();
        }

        protected internal virtual Server InstantiateFacade()
        {
            throw new System.NotImplementedException();
        }

        protected internal virtual void AssignDto()
        {
            throw new System.NotImplementedException();
        }

        protected internal virtual void AssignFormControls()
        {
            throw new System.NotImplementedException();
        }

        protected internal virtual Boolean ValidateForm()
        {
            throw new System.NotImplementedException();
        }

        protected internal virtual void ClearForm()
        {
            throw new System.NotImplementedException();
        }

        #endregion

        protected internal virtual void AttachDtoToChildControl()
        {

        }

    }

}