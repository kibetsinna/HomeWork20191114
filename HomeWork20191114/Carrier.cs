using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork20191114
{
    class Carrier
    {
        public Vehicle[] v;
        public override string ToString()
        {
            string s="";
            foreach (Vehicle item in v)
                s += item.ToString() + "\n";
            return s;
        }
    }
}
