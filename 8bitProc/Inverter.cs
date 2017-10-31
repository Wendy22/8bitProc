using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8bitProc
{
    public class Inverter
    {
        private bool input;
        private bool output;
        
        public bool Input
        {
            get { return input; }
            set
            {
                input = value;
                output = !input;
            }
        }

        public bool Output()
        {
            return output;
        }

    }
}
