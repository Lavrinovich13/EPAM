using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasGift
{
    class ChristmasGift
    {
        private Dictionary<Sweetness, uint> _Contents;

        public ChristmasGift()
        {
            _Contents = new Dictionary<Sweetness, uint>();
        }

        public ChristmasGift(Dictionary<Sweetness, uint> contents)
        {
            this._Contents = contents;
        }

        public void Add(Sweetness sweetness, uint num = 1)
        {
            _Contents.Add(sweetness, num);
        }

        public uint Count
        {
            get { return (uint)_Contents.Sum(x => x.Value); }
        }

        public uint Price
        {
            get { return (uint)_Contents.Sum(x => x.Value * x.Key.Price); }
        }

        public uint Weight
        {
            get { return (uint)_Contents.Sum(x => x.Key.Weight); }
        }

        public Sweetness FindForSugar(uint minSugar, uint maxSugar)
        {
            return _Contents.Single(x => x.Key.Sugar >= minSugar && x.Key.Sugar <= maxSugar).Key;
        }

        public void Sort(IComparer<Sweetness> comparer)
        {
            _Contents.OrderBy(x => x.Key, comparer);
        }
    }
}
