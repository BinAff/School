using System;

namespace Sparkle.Finance.Component.PaymentMode
{

    public class Data : BinAff.Core.Data
    {
        /// <summary>
        /// Id for Payment Mode
        /// </summary>
        public Int64 Id { get; set; }


        /// <summary>
        /// Name for Payment Mode
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Flag to activate / deactivate Payment Mode
        /// </summary>
        public Boolean IsActive { get; set; }
    }

}