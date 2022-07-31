using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMClassLibrary
{
    public class Cards
    {
        public int Number { get; private set; }
        public int Pincode { get; private set; }

        public Cards(int numb, int pin)
        {
            Number = numb;
            Pincode = pin;
        }
        public override string ToString() 
        {
            return $"{Number} {Pincode}";
        }
    }
}
