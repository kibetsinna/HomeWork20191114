using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork20191114
{
    class Motorcycle:Vehicle
    {
         public int _numberOfHandBreaks;
         public Motorcycle(string model, int numberOfWheels, int numberOfHandBreaks)
             : base(model, numberOfWheels)
        {
            _numberOfHandBreaks = _numberOfHandBreaks;
        }
        public override int GetMaxNumOfPassengers()
        {
            return 2;
        }
        public override int GetMaxSpeed()
        {
            return 250;
        }
        public override string ToString()
        {
            string s =base.ToString();
            s += " .number of HandBreaks: " + _numberOfHandBreaks;
            return s;
        }
    }
}
