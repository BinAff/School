using System;

namespace Sparkle.Finance.Component.Account
{

    public class Data : BinAff.Core.Data
    {
        /// <summary>
        /// Account Id
        /// </summary>
        public Int64 Id { get; set; }


        /// <summary>
        /// Account Name
        /// </summary>
        public string Name { get; set; }

    }

}