using ChristmasGift.Dimensions;
using ChristmasGift.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ChristmasGift.GiftElements
{
    internal abstract class ElementOfGift : IElementOfGift
    {
        protected string _Title;
        public string Title
        {
            get { return _Title; }
        }

        protected string _Manufacturer;
        public string Manufacturer
        {
            get { return _Manufacturer; }
        }

        protected string _CountryOfManufacturer;
        public string CountryOfManufacturer
        {
            get { return _CountryOfManufacturer; }
        }

        protected IMeasuredValue _Weigth;
        public IMeasuredValue Weigth
        {
            get { return _Weigth; }
        }

        protected IMeasuredValue _Price;
        public IMeasuredValue Price
        {
            get { return _Price; }
        }

        protected ElementOfGift
            (string title, string manufacterer, string countryOfManufacturer, IMeasuredValue weight, IMeasuredValue price)
        {
            _Title = title;
            _Manufacturer = manufacterer;
            _CountryOfManufacturer = countryOfManufacturer;
            _Weigth = weight;
            _Price = price;
        }

        public virtual void Print()
        {
            Console.Write(String.Format("Title: {0}, Manufacturer: {1}, Country: {2}, Weight: {3}{4}, Price: {5}{6}, ", 
                Title, Manufacturer, CountryOfManufacturer, Weigth.Value, Weigth.Dimension, Price.Value, Price.Dimension));
        }
    }
}
