using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasGift.Comparators
{
    class ElementOfGiftByWeightComparer : IComparer<IElementOfGift>
    {
        public int Compare(IElementOfGift elem1, IElementOfGift elem2)
        {

            return elem1.Weigth.Value.CompareTo(elem2.Weigth.Value);
        }
    }
}
