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
        public void ConvertToByteTruthyness()
        {

        }
    }
}
