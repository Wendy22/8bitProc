﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8bitProc
{
    public class NorGate : TwoInputGate
    {

        public void DisplayState()
        {
            Console.WriteLine("Input1 of NAND gate is " + Input1.ToString());
            Console.WriteLine("Input2 of NAND gate is " + Input2.ToString());
            Console.WriteLine("Output of NAND gate is " + Output().ToString());
        }

        public override bool TruthTable()
        {
            if (this.Input1 == false && this.Input2 == false) { return true; }
            else { return false; }
        }


    }


}
