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
        private string title;
        /// <summary>
        /// Country of manufacturer
        /// </summary>
        private string countryOfManufacturer;
        /// <summary>
        /// Name of manufacturer
        /// </summary>
        private string manufacturer;
        /// <summary>
        /// Price in dollars
        /// </summary>
        private uint price;
        /// <summary>
        /// Weight in gramms
        /// </summary>
        private double weight;
        /// <summary>
        /// Wrapper appearance : Wrapped, NotWrapped, PartiallyWrapped,InCorrexes
        /// </summary>
        private WrapperTypes typeOfAppearance;
        #endregion

        #region NutritionCharacteristic
        /// <summary>
        /// Amount of sugar in 100 g
        /// </summary>
        private double sugar;
        /// <summary>
        /// Nutritional value in kkal/100g
        /// </summary>
        private double nutritionalValue;
        #endregion
    }
}
