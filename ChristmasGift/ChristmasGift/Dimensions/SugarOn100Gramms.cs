using ChristmasGift.Dimensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChristmasGift.Interfaces
{
    [Serializable]
    class SugarOn100Gramms : MeasuredValue
    {
        public SugarOn100Gramms(double value)
            : base(value, DimensionTypes.On100GrammsProduct)
        { }
    }
}
