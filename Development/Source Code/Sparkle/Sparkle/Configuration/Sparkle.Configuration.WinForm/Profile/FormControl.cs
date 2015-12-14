using System;

using BinAff.Presentation.Library.Extension;

using Fac = Sparkle.Configuration.Facade.Profile;

namespace Sparkle.Configuration.WinForm.Profile
{

    public partial class FormControl : Sparkle.Core.Presentation.FormControl
    {

        public FormControl()
        {
            InitializeComponent();
        }

        protected override Core.Facade.Server InstantiateFacade()
        {
            return new Fac.Server(base.FormDto as Fac.FormDto);
        }

        protected override void Bind()
        {
            this.cboOccupation.Bind((this.FormDto as Fac.FormDto).OccupationList, "Name");
        }

        protected override void ClearForm()
        {
            this.txtFirstName.Text = String.Empty;
            this.txtFirstName.Focus();
        }

        protected override void AssignDto()
        {
            Fac.Dto dto = base.FormDto.Dto as Fac.Dto;
            //dto.Name = this.txtFirstName.Text;
        }

        protected override void AssignFormControls()
        {
            Fac.Dto dto = base.FormDto.Dto as Fac.Dto;
            //this.txtFirstName.Text = dto.Name;
        }

        protected override Boolean ValidateForm()
        {

            return true;
        }

    }

}