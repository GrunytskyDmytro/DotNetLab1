using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMClassLibrary
{
    public class AtmWithdrawEventArgs : EventArgs
    {
        public bool Result { get; private set; }
        public int Sum { get; private set; }
        public AtmWithdrawEventArgs(bool res, int sum)
        {
            Result = res;
            Sum = sum;
        }
    }
}
