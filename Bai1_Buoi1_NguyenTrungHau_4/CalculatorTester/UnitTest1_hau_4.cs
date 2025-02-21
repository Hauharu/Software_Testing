using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Calculator;

namespace CalculatorTester
{
    [TestClass]
    public class UnitTest1_hau_4
    {
        private Caculation_hau_4 c;
        [TestInitialize]
        public void SetUp()
        {
            c = new Caculation_hau_4(10, 5);
        }
        [TestMethod] //TC1: a =10, b = 5, kq= 15
        // 
        public void Test1_Cong_hau_4()
        {
            int expected, actual;
            expected = 15;
            actual = c.Execute("+");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod] //TC1: a =10, b = 5, kq= 5
        public void Test2_Tru_hau_4()
        {
            int expected, actual;
            expected = 5;
            actual = c.Execute("-");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod] //TC1: a =10, b = 5, kq= 50
        public void Test3_Nhan_hau_4()
        {
            int expected, actual;
            expected = 50;
            actual = c.Execute("*");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod] //TC1: a =10, b = 5, kq= 2
        public void Test4_Chia_hau_4()
        {
            int expected, actual;
            expected = 2;
            actual = c.Execute("/");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod] 
        [ExpectedException(typeof(DivideByZeroException))]
        public void Test5_ChiaZero_hau_4()
        {
            c = new Caculation_hau_4(10, 0);
            c.Execute("/");
        }
    }
}