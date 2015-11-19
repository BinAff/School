using System;
using System.Windows.Forms;

using Sparkle.Core.Facade;

namespace Sparkle.Core.Presentation
{

    public partial class FormControl : UserControl
    {

        protected internal FormDto FormDto { get; internal set; }

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

        protected internal virtual void Bind()
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