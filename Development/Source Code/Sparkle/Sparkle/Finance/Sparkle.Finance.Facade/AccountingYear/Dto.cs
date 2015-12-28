using System;

namespace Sparkle.Finance.Facade.AccountingYear
{

    public class Dto : Sparkle.Core.Facade.Dto
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
        
    }

}