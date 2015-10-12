using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasGift
{
    enum CookieTypes 
    { 
        Sugar,
        Butter, 
        Biscuit, 
        Flaky, 
        Shortbread 
    }
    enum CookieFillings 
    { 
        Chocolate, 
        Cream, 
        CondensedMilk, 
        Raisins, 
        Nuts, 
        PoppySeeds, 
        Cheese, 
        Fruit 
    }
    class Cookie : Sweetness
    {
        /// <summary>
        /// Cookie types : Sugar, Butter, Biscuit, Flaky
        /// </summary>
        private CookieTypes _Type;
        public CookieTypes CookieType { get { return _Type;}}

        /// <summary>
        /// Cookie filling : Chocolate, Cream, CondensedMilk, Raisins, Nuts, PoppySeeds, Cheese, Fruit
        /// </summary>
        private CookieFillings _Filling;
        public CookieFillings Filling { get { return _Filling; } }

        public Cookie
           (string title,
            string countryOfManufacturer, 
            string manufacturer, 
            uint price,
            uint weight, 
            WrapperTypes typeOfAppearance, 
            uint sugar, 
            uint nutritionalValue,
            CookieTypes type,
            CookieFillings filling)
            :base(title, countryOfManufacturer, manufacturer, price, weight, typeOfAppearance, sugar, nutritionalValue)
        {
            this._Type = type;
            this._Filling = filling;
        }
    }
}
