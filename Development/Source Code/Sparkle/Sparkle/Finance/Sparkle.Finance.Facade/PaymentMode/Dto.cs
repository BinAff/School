using System;

namespace Sparkle.Finance.Facade.PaymentMode
{

    public class Dto : Sparkle.Core.Facade.Dto
    {

        /// <summary>
        /// Id for Payment Mode
        /// </summary>
        public Int64 Id { get; set; }


        /// <summary>
        /// Name for Payment Mode
        /// </summary>
        public string Name { get; set; }
        
    }

}