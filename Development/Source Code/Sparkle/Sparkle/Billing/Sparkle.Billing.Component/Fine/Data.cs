﻿using System;

namespace Sparkle.Billing.Component.Fine
{

    public class Data : BinAff.Core.Data
    {

        public Int64 Id { get; set; }

        public Double Amount { get; set; }

        public Boolean IsActive { get; set; }

    }

}