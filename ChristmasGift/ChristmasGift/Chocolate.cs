using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasGift
{
    enum ChocolateTypes
    {
        White,
        Milky,
        Bitter
    }

    enum ChocolateContents
    {
        Without,
        Fondant,
        Hazelnut,
        Chocolate, 
        Butter,
        Cream,
        Jelly
    }

    enum Forms
    {
        inTiles, 
        batons
    }
    class Chocolate : Sweetness
    {
        /// <summary>
        /// Chocalate Types : White, Milky, Bitter
        /// </summary>
        private ChocolateTypes _Type;
        public ChocolateTypes Type { get { return _Type; } }
        /// <summary>
        /// Without, Fondant, Hazelnut, Chocolate, Butter, Cream, Jelly
        /// </summary>
        private ChocolateContents _Content;
        public ChocolateContents Content { get{ return _Content; } }
        /// <summary>
        ///  inTiles, batons
        /// </summary>
        private Forms _Form;
        public Forms Form { get{ return _Form; } }
        public Chocolate
           (string title,
            string countryOfManufacturer, 
            string manufacturer, 
            uint price,
            uint weight, 
            WrapperTypes typeOfAppearance, 
            uint sugar, 
            uint nutritionalValue,
            ChocolateTypes type,
            ChocolateContents content,
            Forms form)
            :base(title, countryOfManufacturer, manufacturer, price, weight, typeOfAppearance, sugar, nutritionalValue)
        {
            this._Type = type;
            this._Content = content;
            this._Form = form;
        }
    }


}
