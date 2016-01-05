using Comp = Sparkle.Billing.Component;

using FacLib = Sparkle.Core.Facade;

namespace Sparkle.Billing.Facade
{

    public class Server : Sparkle.Core.Facade.Server
    {

        public Server(FormDto formDto)
            : base(formDto)
        {

        }

        #region Framework

        protected override FacLib.FormDto InstantiateFormDto()
        {
            return new FormDto
            {
                Dto = new Dto(),
            };
        }

        protected override FacLib.Server InstantiateFacade()
        {
            return new Server(base.FormDto as FormDto);
        }

        protected override void Instantiate()
        {
            base.ComponentData = new Comp.Data();
            base.ComponentServer = new Comp.Server(base.ComponentData as Comp.Data);
        }

        public override void AssignDto()
        {
            Dto dto = (base.FormDto as FormDto).Dto as Dto;
            Comp.Data data = base.ComponentData as Comp.Data;
            base.ComponentData.Id = data.Id;
            dto.Date = data.Date;
            dto.Installment = data.Installment;
            dto.FeeAmount = data.FeeAmount;
            dto.FineAmount = data.FineAmount;
            dto.TotalAmount = data.TotalAmount;
            dto.AmountPaid = data.AmountPaid;
        }

        public override void AssignData()
        {
            Dto dto = (base.FormDto as FormDto).Dto as Dto;
            Comp.Data data = base.ComponentData as Comp.Data;
            data.Id = dto.Id;
            data.Date = dto.Date;
            data.Installment = dto.Installment;
            data.FeeAmount = dto.FeeAmount;
            data.FineAmount = dto.FineAmount;
            data.TotalAmount = dto.TotalAmount;
            data.AmountPaid = dto.AmountPaid;
        }

        public override BinAff.Facade.Library.Dto Convert(BinAff.Core.Data data)
        {
            Comp.Data dt = data as Comp.Data;
            return new Dto
            {
                Id = dt.Id,
                Date = dt.Date,
                Installment = dt.Installment,
                FeeAmount = dt.FeeAmount,
                FineAmount = dt.FineAmount,
                TotalAmount = dt.TotalAmount,
                AmountPaid = dt.AmountPaid,
            };
        }

        public override BinAff.Core.Data Convert(BinAff.Facade.Library.Dto dto)
        {
            Dto dt = dto as Dto;
            return new Comp.Data
            {
                Id = dt.Id,
                Date = dt.Date,
                Installment = dt.Installment,
                FeeAmount = dt.FeeAmount,
                FineAmount = dt.FineAmount,
                TotalAmount = dt.TotalAmount,
                AmountPaid = dt.AmountPaid,
            };
        }

        #endregion

    }

}