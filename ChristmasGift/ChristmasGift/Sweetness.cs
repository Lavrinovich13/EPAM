using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasGift
{
    enum WrapperTypes
    {
        Wrapped,
        NotWrapped,
        PartiallyWrapped,
        InCorrexes
    }
    abstract class Sweetness
    {
        private string title;
        private string countryOfManufacturer;
        private string manufacturer;
        private uint price;
        private WrapperTypes typeOfAppearance;
        private double weight;
        private double sugar;
    }
}
