using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasGift
{
    enum WaferTypes
    { 
        Traditional, 
        Soft, 
        Rools 
    }

    enum WaferFillings 
    { 
        Without, 
        Fatty, 
        Fondant, 
        FruitAndBerry
    }
    class Wafer : Sweetness
    {
        /// <summary>
        /// Wafer types : Traditional, Soft, Rools
        /// </summary>
        private WaferTypes _Type;
        public WaferTypes Type { get { return _Type; } }
        /// <summary>
        /// WaferFillings : Without, Fatty, Fondant, FruitAndBerry
        /// </summary>
        private WaferFillings _Filling;
        public WaferFillings Filling { get { return _Filling; } }
        private bool _IsCoveredWithChocolate;
        public bool IsCoveredWithChocolate { get { return _IsCoveredWithChocolate; } }

        public Wafer
           (string title,
            string countryOfManufacturer, 
            string manufacturer, 
            uint price,
            uint weight, 
            WrapperTypes typeOfAppearance, 
            uint sugar, 
            uint nutritionalValue,
            bool isCoveredWithChocolate,
            WaferTypes type,
            WaferFillings filling)
            :base(title, countryOfManufacturer, manufacturer, price, weight, typeOfAppearance, sugar, nutritionalValue)
        {
            this._Type = type;
            this._IsCoveredWithChocolate = isCoveredWithChocolate;
            this._Filling = filling;
        }
    }
}
