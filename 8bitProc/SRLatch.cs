using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8bitProc
{
    public class SRLatch
    {
        NandGate nandGate1 = new NandGate();
        NandGate nandGate2 = new NandGate();
        
        public bool S{ get; set; }
        public bool R{ get; set; }

        public bool Q { get; set; }
        public bool Qbar { get; set; }

        public SRLatch()
        {
            //nandGate1.SetInputs(true, false);
            //nandGate2.SetInputs(true, true);
            //this.Q = nandGate1.Output();
            //this.Qbar = nandGate2.Output();
            
            
            
            
            //nandGate2.SetInputs(true, false);
            //Console.WriteLine("cosntructor State of Nandgate 2 is : " + nandGate2.Input1 + " "+  nandGate2.Input2 +" " + nandGate2.Output);

            //nandGate1.SetInputs(this.S, true);
            //Console.WriteLine("cosntructor State of Nandgate 1 is : " + nandGate1.Input1 + " " + nandGate1.Input2 + " " +nandGate1.Output);

        }

        public void TruthTable()
        {
            if (this.S == true && this.R == false)
            {
                this.Q = false;
                this.Qbar = true;
            }
            else if(this.S==true && this.R == true)
            {
                this.Q = false;
                this.Qbar = true;
            }
            else if (this.S == false && this.R == true)
            {
                this.Q = true;
                this.Qbar = false;
            }
            else if(this.S == true && this.R == true)
            {
                this.Q = true;
                this.Qbar = false;
            }
            else
            {
                Console.WriteLine("SR latch state is in invalid condition");
            }
        }

        public void DisplayState()
        {
            //Console.WriteLine("NandG 1");
            //nandGate1.DisplayState();
            //Console.WriteLine("NandG 2s");
            //nandGate2.DisplayState();
            Console.WriteLine("SrLatch state is: S " + this.S + " R " + this.R + " Q " + this.Q + " Qbar " + this.Qbar);
        }

    }
}
