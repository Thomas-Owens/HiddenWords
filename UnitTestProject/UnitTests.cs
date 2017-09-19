using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using HiddenWordsLibrary;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Improper Number of bits!")]
        public void ConvertToByteBitTooSmallTest()
        {
            BitArray TestBob = new BitArray(7, false);
            byte[] Bishop = Functions.ConvertToByte(TestBob);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Improper Number of bits!")]
        public void ConvertToByteBitTooBigTest()
        {
            BitArray TestBob = new BitArray(9, false);
            byte[] Bishop = Functions.ConvertToByte(TestBob);
        }

        [TestMethod]
        public void ConvertToByteTruthyness1()
        {
            // soon TM
            BitArray TestBob = new BitArray(8, false);
            byte[] Bishop = Functions.ConvertToByte(TestBob);
            byte zeros = 0b0000_0000;
            Assert.AreEqual(zeros, Bishop[0]);
        }

        [TestMethod]
        public void ConvertToByteTruthyness2()
        {
            // soon TM
            bool[] testBill = new bool[] { false, false, true, true, false, false, true, true };
            BitArray TestBob = new BitArray(testBill);
            byte[] Bishop = Functions.ConvertToByte(TestBob);
            byte beeps = 0b1100_1100;
            Assert.AreEqual(beeps, Bishop[0]);
        }
    }
}
