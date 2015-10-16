using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasGift.Comparators
{
    class ElementOfGiftByPriceComparer:IComparer<IElementOfGift>
    {
        public int Compare(IElementOfGift elem1, IElementOfGift elem2)
        {

            return elem1.Price.Value.CompareTo(elem2.Price.Value); 
        }
    }
}
