using System;

namespace Sparkle.Finance.Facade.Account
{

    public class Dto : Sparkle.Core.Facade.Dto
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