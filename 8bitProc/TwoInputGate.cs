using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8bitProc
{
    public class TwoInputGate
    {
        private bool input1;
        private bool input2;
        
        public bool Input1{ get; set; }
        public bool Input2{ get; set; }
        //public bool Output { get; set; }
        
        public bool Output()
        {
            return TruthTable();
        }


        public void SetInputs(bool input1, bool input2)
        {
            this.Input1 = input1;
            this.Input2 = input2;
        }

        public virtual bool TruthTable()
        {
            return true;
        }
    }
}
