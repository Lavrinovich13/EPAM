using ChristmasGift.Dimensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasGift
{
    interface IElementOfGift
    {
        string Title { get;}
        string Manufacturer { get;}
        string CountryOfManufacturer { get;}
        IMeasuredValue Weigth { get;}
        IMeasuredValue Price { get;}
    }
}
