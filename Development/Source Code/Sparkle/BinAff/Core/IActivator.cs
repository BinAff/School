using System;
using System.Collections.Generic;

namespace BinAff.Core
{

    interface IActivator
    {

        /// <summary>
        /// Activate the record
        /// </summary>
        /// <returns></returns>
        ReturnObject<Boolean> Activate();

        /// <summary>
        /// Deactivate the record
        /// </summary>
        /// <returns></returns>
        ReturnObject<Boolean> Deactivate();

        /// <summary>
        /// Read all activated record
        /// </summary>
        /// <returns></returns>
        ReturnObject<List<Data>> ReadAllActivate();

    }

}