using HelloCalculator;
using HelloCalculator.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloTest
{
    [TestClass]
    public class UnitTest1
    {
        Calculator mcalculator;

        [TestInitialize]
        public void init()
        {
            mcalculator = new Calculator();   
        }

        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(1, 1);

        }

        [TestMethod]
        public void TestPenjumlahan()
        {
            Assert.AreEqual(2, mcalculator.Jumlah(1, 1));
            Assert.AreEqual(3, mcalculator.Jumlah(2, 1));
            
        }

        [TestMethod]
        public void TestPenjumlahanDecimal()
        {
            Assert.AreEqual(2.7f, mcalculator.Jumlah(1.2f, 1.5f));
            Assert.AreEqual(3, mcalculator.Jumlah(2, 1));
        }

        [TestMethod]
        [ExpectedException(typeof(DivisionbyZeroException), "Tidak boleh pembagian dengan 0")]
        
        public void TestExpectedDivbyZeroException()
        {
            mcalculator.Bagi(1, 0);
        }

        [TestMethod]
        public void TestDecimal2()
        {
            Assert.AreEqual(2.7f, mcalculator.Jumlah(1.2f, 1.5f));
            Assert.AreEqual(3, mcalculator.Jumlah(2, 1));
        }

        [TestMethod]
        public void TestDecimal3()
        {
            Assert.AreEqual(2.7f, mcalculator.Jumlah(1.2f, 1.5f));
            Assert.AreEqual(3, mcalculator.Jumlah(2, 1));
        }

    }
}
