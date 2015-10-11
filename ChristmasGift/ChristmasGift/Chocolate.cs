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

    enum ContentTypes
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
        private ChocolateTypes type;
        /// <summary>
        /// Without, Fondant, Hazelnut, Chocolate, Butter, Cream, Jelly
        /// </summary>
        private List<ContentTypes> contents;
        /// <summary>
        ///  inTiles, batons
        /// </summary>
        private Forms form;
    }
}
