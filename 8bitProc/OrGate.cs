using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8bitProc
{
    public class OrGate: TwoInputGate
    {

        public void DisplayState()
        {
            Console.WriteLine("Input1 of OR gate is " + Input1.ToString());
            Console.WriteLine("Input2 of OR gate is " + Input2.ToString());
            Console.WriteLine("Output of OR gate is " + Output().ToString());
        }

        public override bool TruthTable()
        {
            if (this.Input1 == false && this.Input2 == false){return false;}
            else{return true;}
        }


    }


}
