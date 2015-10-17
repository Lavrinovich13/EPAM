using ChristmasGift.Dimensions;
using ChristmasGift.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasGift.GiftElements
{
    class Sweetness : ElementOfGift, ISweetness, IHaveSugar
    {
        protected SweetnessTypes _Type;
        public SweetnessTypes Type
        {
            get { return _Type; }
        }

        protected IMeasuredValue _SugarValue;
        public IMeasuredValue SugarValue
        {
            get { return _SugarValue; }
        }

        public Sweetness
           (string title,
            string manufacterer,
            string countryOfManufacturer,
            IMeasuredValue weight,
            IMeasuredValue price,
            IMeasuredValue sugarValue,
            SweetnessTypes type)
            : base(title, manufacterer, countryOfManufacturer, weight, price)
        {
            _SugarValue = sugarValue;
            _Type = type;
        }

        public override void Print()
        {
            Console.WriteLine();
            Console.WriteLine("----Sweetnes----");
            base.Print();
            Console.Write(String.Format("Sugar value: {0}{1}, Type: {2}, ", SugarValue.Value, SugarValue.Dimension, Type));
            Console.WriteLine();
        }
    }
}
