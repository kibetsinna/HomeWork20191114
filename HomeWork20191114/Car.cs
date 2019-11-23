using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork20191114
{
    public class Car:Vehicle
    {
        public int _numberOfDoors;
        public Car(string model,int numberOfWheels,int numberOfDoors): base(model,numberOfWheels)
        {
            _numberOfDoors =numberOfDoors;
        }
        public  override int GetMaxNumOfPassengers()
        {
            return 5;
        }
        public override int GetMaxSpeed()
        {
            return 150;
        }
        public override string ToString()
        {
            string s = base.ToString();
            s += " .number of Doors: " + _numberOfDoors;
            return s;
        }
    }
}
