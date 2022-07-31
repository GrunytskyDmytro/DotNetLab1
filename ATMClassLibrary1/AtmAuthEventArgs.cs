using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMClassLibrary
{
    public class AtmAuthEventArgs : EventArgs
    {
        public string Result { get; private set; }
        
        public AtmAuthEventArgs(string res)
        {
            Result = res;
        }
    }
}
