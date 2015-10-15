using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasGift
{
    interface IMeasuredValue
    {
        DimensionTypes Dimension { get;}
        double Value { get;}
    }
}
