using ChristmasGift.Dimensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChristmasGift
{
    [Serializable]
    class PriceBelRubles : MeasuredValue
    {
        public PriceBelRubles(double value)
            : base(value, DimensionTypes.BelRubles)
        { }
    }
}
