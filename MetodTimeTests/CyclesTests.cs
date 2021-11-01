using System;
using NUnit.Framework;
using MetodTime;
namespace metodtimeTest
{
    public class CyclesTests
    {
        //1
        #region ElevateAToBTest
        [TestCase(2, 3, 8)]
        [TestCase(-5, 3, -125)]
        [TestCase(6, 0, 1)]
        public void ElevateAToBTest(double a, double b, double expected)
        {
            double actual = CyclesHomework.ElevateAToB(a, b);
            Assert.AreEqual(expected, actual);
        }
        #endregion
        //2
        #region GetDividersATest
        [TestCase(200, new[] { 200, 400, 600, 800, 1000 })]
        [TestCase(500, new[] { 500, 1000 })]
        public void GetDividersATest(int a, int[] expected)
        {
            int[] actual = CyclesHomework.GetDividersA(a);
            Assert.AreEqual(expected, actual);
        }
        #endregion
        //3
        #region GetNumbersOfSquareLessATest
        [TestCase(17, 4)]
        [TestCase(0, 0)]
        public void GetNumbersOfSquareLessATest(int a, int expected)
        {
            int actual = CyclesHomework.GetNumbersOfSquareLessA(a);
            Assert.AreEqual(expected, actual);
        }
        #endregion
        //4
        #region GetGreatestDivisorTest
        [TestCase(100, 50)]
        [TestCase(-100500, -1)]
        public void GetGreatestDivisorTest(int a, int expected)
        {
            int actual = CyclesHomework.GetGreatestDivisor(a);
            Assert.AreEqual(expected, actual);
        }
        #endregion
        //5
        #region GetSumNumbersDivibleBySevenTest
        [TestCase(1, 22, 42)]
        public void GetSumNumbersDivibleBySevenTest(int a, int b, int expected)
        {
            int actual = CyclesHomework.GetSumNumbersDivibleBySeven(a, b);
            Assert.AreEqual(expected, actual);
        }
        #endregion
        //6
        #region GetFibonachchiTest
        [TestCase(12, 144)]
        public void GetFibonachchiTest(int number, int expected)
        {
            int actual = CyclesHomework.GetFibonachchi(number);
            Assert.AreEqual(expected, actual);
        }
        #endregion
        //7
        #region GetGreatesDevidersEvklidTest
        [TestCase(90, 84, 6)]
        [TestCase(140, 96, 4)]
        [TestCase(64, 28, 4)]
        public void GetGreatesDevidersEvklidTest(int one, int two, int expected)
        {
            int actual = CyclesHomework.GetGreatesDevidersEvklid(one, two);
            Assert.AreEqual(expected, actual);
        }
        #endregion
        //8
        #region RecieveNByMethodOfHalfDivisionTest
        [TestCase(125, 5)]
        [TestCase(8, 2)]
        [TestCase(636056, 86)]
        public void RecieveNByMethodOfHalfDivisionTest(int a, int expected)
        {
            int actual = CyclesHomework.RecieveNByMethodOfHalfDivision(a);
            Assert.AreEqual(expected, actual);
        }
        #endregion
        //9
        #region FindNumbersOfOddDigitsTest
        [TestCase(123456789, 5)]
        [TestCase(-987453, 4)]
        [TestCase(0, 0)]
        public void FindNumbersOfOddDigitsTest(int a, int expected)
        {
            int actual = CyclesHomework.FindNumbersOfOddDigits(a);
            Assert.AreEqual(expected, actual);
        }
        #endregion
        //10
        #region FindMirrorNumberTest
        [TestCase(123, 321)]
        [TestCase(847098, 890748)]
        public void FindMirrorNumberTest(int a, int expected)
        {
            int actual = CyclesHomework.FindMirrorNumber(a);
            Assert.AreEqual(expected, actual);
        }
        #endregion
        //11
        #region GetSummOfEvenIsGreaterThanSummOfOddTest
        [TestCase(8325, "10")]
        [TestCase(98325, "сумма четных цифр меньше суммы нечетных")]
        public void GetSummOfEvenIsGreaterThanSummOfOddTest(int n, string expected)
        {
            string actual = CyclesHomework.GetSummOfEvenIsGreaterThanSummOfOdd(n);
            Assert.AreEqual(expected, actual);
        }
        #endregion
        //12
        #region IsThereTheSameNumbersTest
        [TestCase(1234, 5437876, true)]
        [TestCase(123, 999978, false)]
        public void IsThereTheSameNumbersTest(int a, int b, bool expected)
        {
            bool actual = CyclesHomework.IsThereTheSameNumbers(a, b);
            Assert.AreEqual(expected, actual);
        }
        #endregion
    }
}

