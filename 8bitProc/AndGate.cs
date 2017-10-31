using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8bitProc
{
    public class AndGate : TwoInputGate
    {

        public void DisplayState()
        {
            Console.WriteLine("Input1 of and gate is " + Input1.ToString());
            Console.WriteLine("Input2 of and gate is " + Input2.ToString());
            Console.WriteLine("Output of and gate is " + Output().ToString());
        }

        public override bool TruthTable()
        {
            Console.WriteLine("Input1 " + this.Input1);

            if (this.Input1 == true && this.Input2 == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        
    }

        
}
