using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasGift
{
    enum CandyTypes 
    { 
        Fondant, 
        Fruit, 
        Jelly, 
        Marzipan,
        Pralines, 
        Roasting,
        Cream,
        Liqueur,
        Lollipop
    }

    class Candy : Sweetness
    {
        private bool _IsCoveredWithChocolate;
        public bool IsCoveredWithChocolate { get { return _IsCoveredWithChocolate; } }
        /// <summary>
        /// CandyTypes : Fondant, Fruit, Jelly, Marzipan, Pralines, Roasting, Cream, Liqueur, Lollipop
        /// </summary>
        private CandyTypes _CandyType;
        public CandyTypes CandyType { get { return _CandyType; } }

        public Candy
            (string title,
            string countryOfManufacturer, 
            string manufacturer, 
            uint price,
            uint weight, 
            WrapperTypes typeOfAppearance, 
            uint sugar, 
            uint nutritionalValue,
            bool isCoveredWithChocolate,
            CandyTypes candyType)
            :base(title, countryOfManufacturer, manufacturer, price, weight, typeOfAppearance, sugar, nutritionalValue)
        {
            this._IsCoveredWithChocolate = isCoveredWithChocolate;
            this._CandyType = candyType;
        }
    }
}
