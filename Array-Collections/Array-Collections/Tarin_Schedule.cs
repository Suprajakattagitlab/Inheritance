using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Collections
{
    internal class Train_Schedule

    {
        
            int PNR;
            public string to;
            public string from;
            public Train_Schedule(int PNR, string to, string from)
            {
            //  DateTime d = new DateTime();
            this. PNR = PNR;
                this.to = to;
                this.from = from;
            }
            public override string ToString() => $"{PNR}:{from}->{to}";


        

    }
}
