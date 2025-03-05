using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Calculator;

namespace CalculatorTester
{
    [TestClass]
    public class UnitTest1_hau_4
    {
        private Caculation_hau_4 c;
        public TestContext TestContext { get; set; }
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
        [TestMethod] //TC2: a =10, b = 5, kq= 5
        public void Test2_Tru_hau_4()
        {
            int expected, actual;
            expected = 5;
            actual = c.Execute("-");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod] //TC3: a =10, b = 5, kq= 50
        public void Test3_Nhan_hau_4()
        {
            int expected, actual;
            expected = 50;
            actual = c.Execute("*");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod] //TC4: a =10, b = 5, kq= 2
        public void Test4_Chia_hau_4()
        {
            int expected, actual;
            expected = 2;
            actual = c.Execute("/");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod] //TC5: a =10, b = 0
        [ExpectedException(typeof(DivideByZeroException))]
        public void Test5_ChiaZero_hau_4()
        {
            c = new Caculation_hau_4(10, 0);
            c.Execute("/");
        }

        //TC6: Test data 3 cot, 5 hang du lieu 
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @".\Data_hau_4\TestData_hau_4_1.csv", "TestData_hau_4_1#csv", DataAccessMethod.Sequential)]
        public void TestWithDataSource1()
        {

            int a = int.Parse(TestContext.DataRow[0].ToString());
            int b = int.Parse(TestContext.DataRow[1].ToString());
            int expected = int.Parse(TestContext.DataRow[2].ToString());
            Caculation_hau_4 c = new Caculation_hau_4(a,b);
            int actual =c.Execute("+");
            Assert.AreEqual(expected, actual);
        }

        //TC7: Test data 4 cot, 5 hang du lieu 
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
             @".\Data_hau_4\TestData_hau_4_2.csv", "TestData_hau_4_2#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void TestWithDataSource2()
        {
            int a = int.Parse(TestContext.DataRow[0].ToString());
            int b = int.Parse(TestContext.DataRow[1].ToString());
            string operation = TestContext.DataRow[2].ToString();
            operation = operation.Remove(0, 1);
            int expected = int.Parse(TestContext.DataRow[3].ToString());

            Caculation_hau_4 c = new Caculation_hau_4(a, b);
            int actual = c.Execute(operation);
            Assert.AreEqual(expected, actual);

        }
    }
}