﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasGift
{
    class OrdinaryGiftBuilder : IGiftBuilder
    {
        public ChristmasGift Build()
        {
            return new ChristmasGift();
        }
    }
}
