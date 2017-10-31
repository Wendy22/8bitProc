using System;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;

namespace UnitTestProjectGates.Tests
{
    [TestClass]
    public class LogicGatesTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            AndGate andGate = new AndGate();
        }

        public static void UnitTestAnd()
        {
            const string Text = "Unit test AND # ";
            AndGate andGate = new AndGate();
            andGate.Input1 = false;
            andGate.Input2 = false;
            //should return false
            Console.WriteLine(Text + "1 " + (andGate.Output == false).ToString());

            andGate.Input1 = true;
            andGate.Input2 = false;
            //should return false
            Console.WriteLine(Text + "2 " + (andGate.Output == false).ToString());

            andGate.Input1 = false;
            andGate.Input2 = true;
            //should return false
            Console.WriteLine(Text + "3 " + (andGate.Output == false).ToString());

            andGate.Input1 = true;
            andGate.Input2 = true;
            //should return true
            Console.WriteLine(Text + "4 " + (andGate.Output == true).ToString());

        }

        public static void UnitTestOr()
        {
            const string Text = "Unit test OR # ";
            OrGate orGate = new OrGate();
            orGate.Input1 = false;
            orGate.Input2 = false;
            //should return false
            Console.WriteLine(Text + "1 " + (orGate.Output == false).ToString());

            orGate.Input1 = true;
            orGate.Input2 = false;
            //should return true
            Console.WriteLine(Text + "2 " + (orGate.Output == true).ToString());

            orGate.Input1 = false;
            orGate.Input2 = true;
            //should return true
            Console.WriteLine(Text + "3 " + (orGate.Output == true).ToString());

            orGate.Input1 = true;
            orGate.Input2 = true;
            //should return true
            Console.WriteLine(Text + "4 " + (orGate.Output == true).ToString());

        }


    }
}
