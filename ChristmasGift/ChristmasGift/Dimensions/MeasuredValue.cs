using ChristmasGift.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ChristmasGift.Dimensions
{
    class MeasuredValue : IMeasuredValue
    {
        protected DimensionTypes _Dimension;
        public DimensionTypes Dimension 
        {
            get { return _Dimension; }
        }

        protected double _Value;

        public double Value
        {
            get { return _Value; }
        }
        public MeasuredValue(double value1, DimensionTypes dimension)
        {
            _Value = value1;
            _Dimension = dimension;
        }
    }
}
