using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyChart
{
    class Rate
    {
        public string Moment { get; private set; }
        public double Value { get; private set; }

        public Rate(string moment, string value)
        {
            Moment = moment;
            Value = double.Parse(value, CultureInfo.InvariantCulture);
        }
    }
}
