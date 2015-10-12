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
        #region BaseInfo
        /// <summary>
        /// Title of product
        /// </summary>
        private string _Title;
        public string Title { get { return _Title; } }
        /// <summary>
        /// Country of manufacturer
        /// </summary>
        private string _CountryOfManufacturer;
        public string CountryOfManufacturer { get { return _CountryOfManufacturer; } }
        /// <summary>
        /// Name of manufacturer
        /// </summary>
        private string _Manufacturer;
        public string Manufacturer { get { return _Manufacturer; } }
        /// <summary>
        /// Price in dollars
        /// </summary>
        private uint _Price;
        public uint Price { get { return _Price; } }
        /// <summary>
        /// Weight in gramms
        /// </summary>
        private uint _Weight;
        public uint Weight { get { return _Weight; } }
        /// <summary>
        /// Wrapper appearance : Wrapped, NotWrapped, PartiallyWrapped,InCorrexes
        /// </summary>
        private WrapperTypes _TypeOfAppearance;
        public WrapperTypes TypeOfAppearance { get { return _TypeOfAppearance; } }
        #endregion

        #region NutritionCharacteristic
        /// <summary>
        /// Amount of sugar in 100 g
        /// </summary>
        private uint _Sugar;
        public uint Sugar { get { return _Sugar; } }
        /// <summary>
        /// Nutritional value in kkal/100g
        /// </summary>
        private uint _NutritionalValue;
        public uint NutritionalValue { get { return _NutritionalValue; } }
        #endregion

        public Sweetness
           (string title,
            string countryOfManufacturer, 
            string manufacturer, 
            uint price,
            uint weight, 
            WrapperTypes typeOfAppearance, 
            uint sugar, 
            uint nutritionalValue)
        {
            this._Title = title;
            this._CountryOfManufacturer = countryOfManufacturer;
            this._Manufacturer = manufacturer;
            this._Price = price;
            this._Weight = weight;
            this._TypeOfAppearance = typeOfAppearance;
            this._Sugar = sugar;
            this._NutritionalValue = nutritionalValue;
        }
    }
}
