﻿using System;

namespace Sparkle.Billing.Component.Fine.Definition
{

    public class Data : BinAff.Core.Data
    {

        public String Name { get; set; }

        public Fee.Data Fee { get; set; }

    }

}