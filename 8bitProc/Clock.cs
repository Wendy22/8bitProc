using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8bitProc
{
    public class Clock
    {
        public long TimeStep { get; set; }
        public bool Output{ get; set; }

        public void NextTimeStep()
        {
            this.TimeStep += 1;
            this.Output = !this.Output;
        }

        public void DisplayClockState()
        {
            Console.WriteLine("Clock state is " + this.Output + " at time step " + this.TimeStep);
        }

    }
}
