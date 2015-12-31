using System;

namespace Sparkle.Finance.Component.AccountingYear
{

    public class Data : BinAff.Core.Data
    {
        /// <summary>
        /// ID for Accounting Year
        /// </summary>
        public Int64 Id { get; set; }

        /// <summary>
        /// Name for Accounting Year
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Flag for Current Accounting Year
        /// </summary>
        public Boolean CurrentFlag { get; set; }

        /// <summary>
        /// Flag to activate / deactivate Accounting Year
        /// </summary>
        public Boolean IsActive { get; set; }
    }

}