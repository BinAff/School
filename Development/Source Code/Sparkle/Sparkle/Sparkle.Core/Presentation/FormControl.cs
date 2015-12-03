using System;
using System.Windows.Forms;

using Sparkle.Core.Facade;

namespace Sparkle.Core.Presentation
{

    public partial class FormControl : UserControl
    {

        protected internal FormDto FormDto { get; set; }
        protected internal Server Facade { get; set; }

        protected ErrorProvider ErrorProvider
        {
            get
            {
                return this.errorProvider;
            }
        }

        public FormControl()
        {
            InitializeComponent();
        }

        private void FormControl_Load(object sender, EventArgs e)
        {

        }

        public void LoadForm()
        {
            this.InistantiateControls(this);
        }

        private void InistantiateControls(System.Windows.Forms.Control ctrl)
        {
            FormControl frmCtrl = ctrl as FormControl;
            if (frmCtrl != null)
            {
                frmCtrl.Facade = frmCtrl.InstantiateFacade();
                frmCtrl.FormDto = frmCtrl.Facade.FormDto as FormDto;
                frmCtrl.Facade.LoadControl();
                frmCtrl.Bind();
            }
            Control.ControlCollection colection = ctrl.Controls;
            if (colection.Count > 0)
            {
                foreach (Control ctrl1 in colection)
                {
                    this.InistantiateControls(ctrl1);
                }
            }
            else
            {
                return;
            }
        }

        internal Boolean Save()
        {
            if (this.ValidateForm())
            {
                this.AssignDto();
                this.FormDto.Dto.Id = 0;
                this.Facade.Add();
                return true;
            }
            return false;
        }

        internal Boolean Change()
        {
            if (this.ValidateForm())
            {
                this.AssignDto();
                this.Facade.Change();
                return true;
            }
            return false;
        }

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

        protected internal virtual void ResetForm()
        {
            throw new System.NotImplementedException();
        }

    }

}