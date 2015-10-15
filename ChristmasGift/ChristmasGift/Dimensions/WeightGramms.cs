using ChristmasGift.Dimensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChristmasGift
{
    [Serializable]
    class WeightGramms : MeasuredValue
    {
        public WeightGramms(double value)
            : base(value, DimensionTypes.Gramms)
        { }
    }
}
