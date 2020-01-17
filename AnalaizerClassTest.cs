using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BaseCalculator;
using System.Collections;

namespace IntegrationTesting
{
    [TestClass]
    public class AnalaizerClassTest
    {
        ArrayList arr;
        public TestContext TestContext { set; get; }
        private String actual;

        [TestInitialize]
        public void InitializeMethod()
        {
            switch (TestContext.TestName)
            {
                case "TestMethod1":
                    this.IntializeTestMethod1();
                    break;
                case "TestMethod2":
                    this.IntializeTestMethod2();
                    break;
                case "TestMethod3":
                    this.IntializeTestMethod3();
                    break;
                case "TestMethod4":
                    this.IntializeTestMethod4();
                    break;
                case "TestMethod5":
                    this.IntializeTestMethod5();
                    break;
                case "TestMethod6":
                    this.IntializeTestMethod6();
                    break;
                case "TestMethod7":
                    this.IntializeTestMethod7();
                    break;
                case "TestMethod8":
                    this.IntializeTestMethod8();
                    break;
                case "TestMethod9":
                    this.IntializeTestMethod9();
                    break;
                case "TestMethod10":
                    this.IntializeTestMethod10();
                    break;
                case "TestMethod11":
                    this.InitializeTestMethod11();
                    break;
                default:
                    break;
            }
            
        }

        public void IntializeTestMethod1()
        {
            AnalaizerClass.expression = "4 + 4 ";
            actual = "8";
        }

        public void IntializeTestMethod2()
        {
            AnalaizerClass.expression = "16 - 3 ";
            actual = "13";
        }

        public void IntializeTestMethod3()
        {
            AnalaizerClass.expression = "39 / 3 ";
            actual = "13";
        }

        public void IntializeTestMethod4()
        {
            AnalaizerClass.expression = "4 * 12 ";
            actual = "48";
        }

        public void IntializeTestMethod5()
        {
            AnalaizerClass.expression = "50 mod 12 ";
            actual = "2";
        }

        public void IntializeTestMethod6()
        {
            AnalaizerClass.expression = "m 50 ";
            actual = "-50";
        }
        public void IntializeTestMethod7()
        {
            AnalaizerClass.expression = "p 100 ";
            actual = "100";
        }

        public void IntializeTestMethod8()
        {
            AnalaizerClass.expression = "20 / 0 ";
            actual = "Error 09";
        }

        public void IntializeTestMethod9()
        {
            AnalaizerClass.expression = Int32.MaxValue.ToString() + " + 1 ";
            actual = "Error 06";
        }

        public void IntializeTestMethod10()
        {
            AnalaizerClass.expression = Int32.MinValue.ToString() + " - 1 ";
            actual = "Error 06";
        }

        public void InitializeTestMethod11()
        {
            AnalaizerClass.expression = "12 - 3 + ( 11 * 7 ) ";
            actual = "86";
        }
        private void Test()
        {
            arr = AnalaizerClass.CreateStack();
            AnalaizerClass.opz = arr;
            String result = AnalaizerClass.RunEstimate();
            Assert.AreEqual(result, actual);
        }
        [TestMethod]
        public void TestMethod1()
        {
            Test();
        }
        [TestMethod]
        public void TestMethod2()
        {
            Test();
        }
        [TestMethod]
        public void TestMethod3()
        {
            Test();
        }
        [TestMethod]
        public void TestMethod4()
        {
            Test();
        }
        [TestMethod]
        public void TestMethod5()
        {
            Test();
        }
        [TestMethod]
        public void TestMethod6()
        {
            Test();
        }
        [TestMethod]
        public void TestMethod7()
        {
            Test();
        }
        [TestMethod]
        public void TestMethod8()
        {
            Test();
        }
        [TestMethod]
        public void TestMethod9()
        {
            Test();
        }
        [TestMethod]
        public void TestMethod10()
        {
            Test();
        }
        [TestMethod]
        public void TestMethod11()
        {
            Test();
        } 
    }
}
