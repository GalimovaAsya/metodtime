using System;
using NUnit.Framework;
using MetodTime;
namespace metodtimeTest
{
    public class BranchingStructuresHomeworkTests
    {
        //1
        #region CountByConditionsrkTest

        [TestCase(-100, -1234, -1334)]
        [TestCase(2.5, 2.5, 6.25)]
        [TestCase(-0.01, 59, -59.01)]
        [TestCase(0, 0, 0)]
        public void CountByConditionsrkTest(double a, double b, double expected)
        {
            double actual = BranchingStructuresHomework.CountByConditions(a, b);
            Assert.AreEqual(expected, actual, 0.01);
        }
        #endregion
        //2
        #region FindQuarterTest
        [TestCase(65345, 887, 1)]
        [TestCase(5435, -76, 2)]
        [TestCase(-86, -65, 3)]
        [TestCase(-0.01, 59, 4)]
        public void FindQuarterTest(double x, double y, int expected)
        {
            int actual = BranchingStructuresHomework.FindQuarter(x, y);
            Assert.AreEqual(expected, actual, 0.001);
        }
        [TestCase(0, 0)]
        public void FindQuarterTest_WhenPointIsAtTheOrigin_ShouldArgumentException(double x, double y)
        {
            double actual = VariablesHomework.GetformulaResult(x, y);
            Assert.Throws<ArgumentException>(() => BranchingStructuresHomework.FindQuarter(x, y));
        }
        [TestCase(0, 5)]
        [TestCase(0, -2.5)]
        [TestCase(-9, 0)]
        [TestCase(-89.4, 0)]
        public void FindQuarterTest_WhenPointIsAtTheAxis_ShouldArgumentException(double x, double y)
        {
            double actual = VariablesHomework.GetformulaResult(x, y);
            Assert.Throws<ArgumentException>(() => BranchingStructuresHomework.FindQuarter(x, y));
        }
        #endregion
        //3
        #region GetAscendingOrderTest
        [TestCase(1, 2, 3, new[] { 1, 2, 3 })]
        [TestCase(111, 333, 222, new[] { 111, 222, 333 })]
        [TestCase(-87, -1, -199, new[] { -199, -87, -1 })]
        [TestCase(2, -5, 39, new[] { -5, 2, 39 })]
        [TestCase(0, 0, 0, new[] { 0, 0, 0 })]
        public void GetAscendingOrderTest(int a, int b, int c, int[] expected)
        {
            int[] actual = BranchingStructuresHomework.GetAscendingOrder(a, b, c);
            Assert.AreEqual(expected, actual);
        }
        #endregion
        //4
        #region SolveQuadraticEquationTest
        [TestCase(1, -6, 9, new double[] { 3 })]
        [TestCase(1, -4, -5, new double[] { 5, -1 })]
        [TestCase(3, -4, 2, new double[] { 0 })]
        public void SolveQuadraticEquationTest(double a, double b, double c, double[] expected)
        {
            double[] actual = BranchingStructuresHomework.SolveQuadraticEquation(a, b, c);
            Assert.AreEqual(expected, actual);
        }
        #endregion
        //5
        #region GetAnInscriptionTest
        [TestCase(55, "пятьдесят пять")]
        [TestCase(15, "пятнадцать")]
        [TestCase(80, "восемьдесят ")]
        [TestCase(91, "девяносто один")]
        [TestCase(29, "двадцать девять")]
        public void GetAnInscriptionTest(int a, string expected)
        {
            string actual = BranchingStructuresHomework.GetAnInscription(a);
            Assert.AreEqual(expected, actual);
        }
        #endregion
    }
}
