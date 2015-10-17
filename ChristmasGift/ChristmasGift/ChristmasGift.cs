using ChristmasGift.Dimensions;
using ChristmasGift.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasGift 
{
    class ChristmasGift : IPrintableInConsole
    {
        private IEnumerable<KeyValuePair<IElementOfGift, uint>> _Contents;

        public ChristmasGift()
        {
            _Contents = new Dictionary<IElementOfGift, uint>();
        }

        public ChristmasGift(Dictionary<IElementOfGift, uint> contents)
        {
            this._Contents = contents;
        }

        public void Add(IElementOfGift sweetness, uint num = 1)
        {
            _Contents = _Contents.Concat(new[] { new KeyValuePair<IElementOfGift, uint>(sweetness, num) });
        }

        public IEnumerator<KeyValuePair<IElementOfGift, uint>> GetEnumerator()
        {
            return _Contents.GetEnumerator();
        }

        public uint Count
        {
            get { return (uint)_Contents.Sum(x => x.Value); }
        }

        public IMeasuredValue Price
        {
            get 
            {
                double value = 0;
                DimensionTypes dimension = _Contents.ElementAt(0).Key.Price.Dimension;

                if (_Contents.All(x => x.Key.Price.Dimension == dimension))
                {
                    value = _Contents.Sum(x => x.Value * x.Key.Price.Value);
                }

                return new MeasuredValue(value, dimension);
            }
        }

        public IMeasuredValue Weight
        {
            get
            {
                double value = 0;
                DimensionTypes dimension = _Contents.ElementAt(0).Key.Weigth.Dimension;

                if (_Contents.All(x => x.Key.Weigth.Dimension == dimension))
                {
                    value = _Contents.Sum(x => x.Value * x.Key.Weigth.Value);
                }

                return new MeasuredValue(value, dimension);
            }
        }

        public IHaveSugar FindForSugar(IMeasuredValue minSugar, IMeasuredValue maxSugar)
        {
            IHaveSugar item = null;
            if (minSugar.Dimension == maxSugar.Dimension)
            {
                item = _Contents.Where(x => x.Key is IHaveSugar).Select(x => x.Key).Cast<IHaveSugar>().FirstOrDefault(x => x.SugarValue.Value >= minSugar.Value && x.SugarValue.Value <= maxSugar.Value);
            }
            return item;
        }

        public void Sort(IComparer<IElementOfGift> comparer)
        {
           _Contents = _Contents.OrderBy(x => x.Key, comparer);
        }

        public void Print()
        {
            Console.WriteLine("---Ordinary Christmas Gift---");
            foreach(var item in _Contents)
            {
                item.Key.Print();
                Console.Write(" " + item.Value + " el;");
                Console.WriteLine();
            }
        }
    }
}
