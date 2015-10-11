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
        private WaferTypes type;
        /// <summary>
        /// WaferFillings : Without, Fatty, Fondant, FruitAndBerry
        /// </summary>
        private WaferFillings filling;
        private bool isCoveredWithChocolate;
    }
}
