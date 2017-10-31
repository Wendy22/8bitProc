using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _8bitProc;

namespace _8BitProc.Tests
{
    [TestClass]
    public class ANDGateTests
    {
        [TestMethod]
        public void ANDGate00()
        {
            AndGate andGate = new AndGate();
            andGate.SetInputs(false, false);
            //should return false
            Assert.AreEqual(false, andGate.Output(), "AND gate with 0 and 0 should return 0");
        }
        [TestMethod]
        public void ANDGate01()
        {
            AndGate andGate = new AndGate();
            andGate.SetInputs(false, true);
            //should return false
            Assert.AreEqual(false, andGate.Output(), "AND gate with 0 and 1 should return 0");
        }
        [TestMethod]
        public void ANDGate10()
        {
            AndGate andGate = new AndGate();
            andGate.SetInputs(true, false);
            //should return false
            Assert.AreEqual(false, andGate.Output(), "AND gate with 1 and 0 should return 0");
        }
        [TestMethod]
        public void ANDGate11()
        {
            AndGate andGate = new AndGate();
            andGate.SetInputs(true, true);
            //should return true
            Assert.AreEqual(true, andGate.Output(), "AND gate with 1 and 1 should return 1");
        }
      }

    [TestClass]
    public class ORGateTests
    {
        [TestMethod]
        public void ORGate00()
        {
            OrGate orGate = new OrGate();
            orGate.SetInputs(false, false);
            //should return false
            Assert.AreEqual(false, orGate.Output(), "OR gate with 0 and 0 should return 0");
        }
        [TestMethod]
        public void ORGate01()
        {
            OrGate orGate = new OrGate();
            orGate.SetInputs(false, true);
            //should return false
            Assert.AreEqual(true, orGate.Output(), "OR gate with 0 and 1 should return 1");
        }
        [TestMethod]
        public void ORGate10()
        {
            OrGate orGate = new OrGate();
            orGate.SetInputs(true, false);
            //should return false
            Assert.AreEqual(true, orGate.Output(), "OR gate with 1 and 0 should return 1");
        }
        [TestMethod]
        public void ORGate11()
        {
            OrGate orGate = new OrGate();
            orGate.SetInputs(true, true);
            //should return true
            Assert.AreEqual(true, orGate.Output(), "OR gate with 1 and 1 should return 1");
        }
    }


    [TestClass]
    public class NandGateTests
    {
        [TestMethod]
        public void NandGate00()
        {
            NandGate nandGate = new NandGate();
            nandGate.SetInputs(false, false);
            Assert.AreEqual(true, nandGate.Output(), "NAND gate with 0 and 0 should return 1");
        }
        [TestMethod]
        public void NandGate01()
        {
            NandGate nandGate = new NandGate();
            nandGate.SetInputs(false, true);
            Assert.AreEqual(true, nandGate.Output(), "NAND gate with 0 and 1 should return 1");
        }
        [TestMethod]
        public void NandGate10()
        {
            NandGate nandGate = new NandGate();
            nandGate.SetInputs(true, false);
            Assert.AreEqual(true, nandGate.Output(), "NAND gate with 1 and 0 should return 1");
        }
        [TestMethod]
        public void NandGate11()
        {
            NandGate nandGate = new NandGate();
            nandGate.SetInputs(true, true);
            Assert.AreEqual(false, nandGate.Output(), "NAND gate with 1 and 1 should return 0");
        }
    }

    [TestClass]
    public class NorGateTests
    {
        [TestMethod]
        public void NorGate00()
        {
            NorGate norGate = new NorGate();
            norGate.SetInputs(false, false);
            Assert.AreEqual(true, norGate.Output(), "NOR gate with 0 and 0 should return 1");
        }
        [TestMethod]
        public void NorGate01()
        {
            NorGate norGate = new NorGate();
            norGate.SetInputs(false, true);
            Assert.AreEqual(false, norGate.Output(), "NOR gate with 0 and 1 should return 0");
        }
        [TestMethod]
        public void NorGate10()
        {
            NorGate norGate = new NorGate();
            norGate.SetInputs(true, false);
            Assert.AreEqual(false, norGate.Output(), "NOR gate with 1 and 0 should return 0");
        }
        [TestMethod]
        public void NorGate()
        {
            NorGate norGate = new NorGate();
            norGate.SetInputs(true, true);
            Assert.AreEqual(false, norGate.Output(), "NOR gate with 1 and 1 should return 0");
        }
    }

    [TestClass]
    public class InverterTests
    {
        [TestMethod]
        public void Inverter1()
        {
            Inverter inverter = new Inverter();
            inverter.Input = true;
            Assert.AreEqual(false, inverter.Output(), "Inverter gate with 1 should return 0");
        }

        [TestMethod]
        public void Inverter0()
        {
            Inverter inverter = new Inverter();
            inverter.Input = false;
            Assert.AreEqual(true, inverter.Output(), "Inverter gate with 0 should return 1");
        }
    }

    [TestClass]
    public class SrLatchTests
    {
        [TestMethod]
        public void SrLatchS1R1()
        {
            SRLatch srLatch = new SRLatch();
            srLatch.S = true;
            srLatch.R = true;
            srLatch.TruthTable();
            Assert.AreEqual(true, srLatch.Q, "S1R1 with SR latch should give Q true Qar false");

        }
    }
}
