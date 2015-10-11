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
        private bool IsCoveredByChocolate;
        /// <summary>
        /// HalvaTypes : Sesame, Peanuts, Sunflower
        /// </summary>
        private HalvaTypes halvaType;

    }
}
