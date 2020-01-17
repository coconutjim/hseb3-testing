using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BaseCalculator;

namespace UnitTestProjectCalc
{
    [TestClass]
    public class AnalaizerClassTest
    {

        /** Constants */
        long MAXINT = 2147483647;

        /// <summary>
        /// Основной метод для тестирования.
        /// Метод тестирует взаимодействие между методами
        /// CreateStack и RunEstimate класса AnalaizerClass.
        /// Так как для остальных модулей мы должны поставить заглушки,
        /// на вход этих методов будут поступать выражения, которые соотвествуют
        /// проверкам методов CheckCurrency и Format класса AnalaizerClass.
        /// ПРИМЕЧАНИЕ. Тесты на случаи, когда после выполнения CreateStack
        /// поле opz класса AnalaizerClass будет равно null,  мы не пишем,
        /// так как структура программы не предусматривает взаимодействия
        /// этих методов при таких входных данных.
        /// </summary>
        /// <param name="expression">входное выражение, удовлетворяющее
        /// постусловиям методов CheckCurrency и Format, после обработки
        /// этого выражения в методе CreateStack поле opz не должно быть null</param>
        /// <param name="expected">ожидаемый результат</param>
        private void Test_CreateStack_RunEstimate(string expression, string expected)
        {
            AnalaizerClass.expression = expression;
            AnalaizerClass.opz = AnalaizerClass.CreateStack();
            string actual = AnalaizerClass.RunEstimate();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Addition()
        {
            Test_CreateStack_RunEstimate("5 + 50 ", Convert.ToString(5 + 50));
        }

        [TestMethod]
        public void Test_Substraction()
        {
            Test_CreateStack_RunEstimate("123 - 11 ", Convert.ToString(112));
        }

        [TestMethod]
        public void Test_Multiplication()
        {
            Test_CreateStack_RunEstimate("45 * 9 ", Convert.ToString(45 * 9));
        }

        [TestMethod]
        public void Test_Division()
        {
            Test_CreateStack_RunEstimate("100 / 10 ", Convert.ToString(100 / 10));
        }

        [TestMethod]
        public void Test_Modulo()
        {
            Test_CreateStack_RunEstimate("34 mod 5 ", Convert.ToString(34 % 5));
        }

        [TestMethod]
        public void Test_Unary_Plus()
        {
            Test_CreateStack_RunEstimate("p 378 ", Convert.ToString(378));
        }

        [TestMethod]
        public void Test_Unary_Minus()
        {
            Test_CreateStack_RunEstimate("m 721 ", Convert.ToString(-721));
        }

        [TestMethod]
        public void Test_Braces()
        {
            Test_CreateStack_RunEstimate("( 45 - 25 ) / 4 ", Convert.ToString((45 - 25) / 4));
        }

        [TestMethod]
        public void Test_Overflow()
        {
            Test_CreateStack_RunEstimate(Convert.ToString(MAXINT) + " + 100 ", "Error 06");
        }

        [TestMethod]
        public void Test_Zero_Division()
        {
            Test_CreateStack_RunEstimate("25 / 0 ", "Error 09");
        }

        [TestMethod]
        public void Test_Empty_Expression()
        {
            Test_CreateStack_RunEstimate("", "Error 03"); // этот случай проходит через 
                                  // проверки методов CheckCurrency и Format
        }

        [TestMethod]
        public void Test_Numbers_Only()
        {
            Test_CreateStack_RunEstimate("6456 ", "6456"); // этот случай проходит через 
                                   // проверки методов CheckCurrency и Format
        }

        [TestMethod]
        public void Test_One_Space_Expression()
        {
            Test_CreateStack_RunEstimate(" ", ""); // этот случай проходит через 
                           // проверки методов CheckCurrency и Format
        }
    }
}
