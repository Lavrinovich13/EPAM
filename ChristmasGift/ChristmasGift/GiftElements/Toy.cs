using ChristmasGift.Dimensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasGift.GiftElements
{
    class Toy : ElementOfGift, IToy
    {
        protected ToyTypes _Type;
        public ToyTypes Type
        {
            get { return _Type; }
        }

        public Toy
           (string title,
            string manufacterer,
            string countryOfManufacturer,
            IMeasuredValue weight,
            IMeasuredValue price,
            ToyTypes type)
            : base(title, manufacterer, countryOfManufacturer, weight, price)
        {
            _Type = type;
        }
    }
}
