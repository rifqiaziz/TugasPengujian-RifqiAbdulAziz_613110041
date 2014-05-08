using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCalculatorv1;

namespace UnitTestTugas
{
    [TestClass]
    public class UnitTest1
    {
        double a=9; 
        double b=3;

        MainWindow mw = new MainWindow();
        [TestMethod]
        public void TestMethodTambah()
        {
            double actual = 12;
            double expected = mw.Penjumlahan(a, b);
            Assert.AreEqual(actual, expected);

        }

        [TestMethod]
        public void TestMethodKurang()
        {
            double actual = 6;
            double expected = mw.pengurangan(a, b);
            Assert.AreEqual(actual, expected);

        }

        [TestMethod]
        public void TestMethodKali()
        {
            double actual = 27;
            double expected = mw.perkalian(a, b);
            Assert.AreEqual(actual, expected);

        }

        [TestMethod]
        public void TestMethodBagi()
        {
            double actual = 3;
            double expected = mw.pembagian(a, b);
            Assert.AreEqual(actual, expected);

        }

    }
}
