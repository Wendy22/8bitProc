﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8bitProc
{
    class Program
    {
        static void Main(string[] args)
        {
            SRLatch srlatch = new SRLatch();
            srlatch.S = false;
            srlatch.R = true;
            srlatch.TruthTable();
            srlatch.DisplayState();
            Console.ReadKey();
                
        }
    }
}


