using calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace calculatorTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Summa10and10return20()
        {
           int a =  10;
           int b =  10;
           int expected =  20;

            calculator_Class c = new calculator_Class();
            int actual = c.Summa(a, b);

            Assert.AreEqual(actual, expected);
        }
        
        [TestMethod]
        public void Minus10and10return0()
        {
            int a = 10;
            int b = 10;
            int expected = 0;

            calculator_Class c = new calculator_Class();
            int actual = c.minus(a, b);

            Assert.AreEqual(actual, expected);
        }
    }
}
