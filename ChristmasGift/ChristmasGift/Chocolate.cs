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

    enum ProcessingMethod
    {
        Dessert,
        Ordinary,
        Porous
    }

    enum Forms
    {
        inTiles, 
        figural, 
        patterned,
        medals, 
        batons,
        tablets
    }
    class Chocolate : Sweetness
    {
        private ChocolateTypes type;
        private List<ContentTypes> contents;
        private ProcessingMethod processingMethod;
    }
}
