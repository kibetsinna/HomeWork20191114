using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork20191114
{
    public abstract class Vehicle
    {
        public int _numberOfWheels;
        public string _model;
        protected Vehicle(string model,int numberOfWheels)
        {
            _numberOfWheels=numberOfWheels;
            _model=model;
        }
        public abstract int GetMaxNumOfPassengers();
        public abstract int GetMaxSpeed();
        public override string ToString()
        {
            string s="Model: "+_model+" number Of Wheels: "+_numberOfWheels+" . Max Number Of Passengers: "+GetMaxNumOfPassengers();
            s += " .Max Speed: " + GetMaxSpeed();
            return s;
        }
     
    }
}
