using System;
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
            AndGate andgate = new AndGate();
            andgate.Input2 = true;
            andgate.Input1 = true;
            Console.WriteLine(andgate.Output());

            Console.ReadLine();
            
        }
    }
}


