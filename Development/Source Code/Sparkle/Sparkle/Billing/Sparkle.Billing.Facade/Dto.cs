using System;

namespace Sparkle.Billing.Facade
{

    public class Dto : Sparkle.Core.Facade.Dto
    {

        public Int64 Id { get; set; }

        public DateTime Date { get; set; }

        public Int32 Installment { get; set; }

        public Double FeeAmount { get; set; }

        public Double FineAmount { get; set; }

        public Double TotalAmount { get; set; }

        public Double AmountPaid { get; set; }

    }

}