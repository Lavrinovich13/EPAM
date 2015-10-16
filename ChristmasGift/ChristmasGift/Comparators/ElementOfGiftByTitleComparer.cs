using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasGift.Comparators
{
    class ElementOfGiftByTitleComparer : IComparer<IElementOfGift>
    {
        public int Compare(IElementOfGift elem1, IElementOfGift elem2)
        {
            return elem1.Title.CompareTo(elem2.Title);
        }
    }
}
