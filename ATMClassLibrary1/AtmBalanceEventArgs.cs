using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMClassLibrary
{
    public class AtmBalanceEventArgs :EventArgs
    {
        public int Balance { get; private set; }
        
        public AtmBalanceEventArgs(int balance) 
        { 
            Balance = balance;
        }
    }
}
