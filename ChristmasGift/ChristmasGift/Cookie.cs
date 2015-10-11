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
        private CookieTypes cookieType;
        /// <summary>
        /// Cookie filling : Chocolate, Cream, CondensedMilk, Raisins, Nuts, PoppySeeds, Cheese, Fruit
        /// </summary>
        private CookieFillings cookieFilling;
    }
}
