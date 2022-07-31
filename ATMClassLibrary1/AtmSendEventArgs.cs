using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMClassLibrary
{
    public class AtmSendEventArgs :EventArgs
    {
        public bool Result { get; private set; }
        public AtmSendEventArgs(bool res)
        {
            Result = res;
        }
    }
}
