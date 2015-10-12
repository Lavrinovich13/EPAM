using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasGift
{
    enum HalvaTypes
    { 
        Sesame, 
        Peanuts, 
        Sunflower
    }
    class Halva : Sweetness
    {
        private bool _IsCoveredWithChocolate;
        public bool IsCoveredWithChocolate { get { return _IsCoveredWithChocolate; } }
        /// <summary>
        /// HalvaTypes : Sesame, Peanuts, Sunflower
        /// </summary>
        private HalvaTypes _Type;
        public HalvaTypes Type { get { return _Type; } }

         public Halva
           (string title,
            string countryOfManufacturer, 
            string manufacturer, 
            uint price,
            uint weight, 
            WrapperTypes typeOfAppearance, 
            uint sugar, 
            uint nutritionalValue,
            bool isCoveredWithChocolate,
            HalvaTypes type)
            :base(title, countryOfManufacturer, manufacturer, price, weight, typeOfAppearance, sugar, nutritionalValue)
        {
            this._Type = type;
            this._IsCoveredWithChocolate = isCoveredWithChocolate;
        }
    }
}
