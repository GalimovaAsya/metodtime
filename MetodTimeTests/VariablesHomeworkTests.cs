using System;
using NUnit.Framework;
using MetodTime;
namespace metodtimeTest
{
    public class VariablesHomeworkTests
    {
        //1
        #region GetFormulaResultTest
        [TestCase(-6, 0, -5)]
        [TestCase(0, 8, 8)]
        [TestCase(3, 6, 17)]
        [TestCase(2, -4, -4.333)]
        public void GetFormulaResultTest(double a, double b, double expected)
        {
            double actual = VariablesHomework.GetformulaResult(a, b);
            Assert.AreEqual(expected, actual, 0.001);
        }
        [TestCase(5, 5)]
        [TestCase(-9, -9)]
        public void GetFormulaResultTest_WhenOneOfDoubleIsEqualAnotherDouble_ShouldThrousArgumentException(double a, double b)
        {
            Assert.Throws<ArgumentException>(() => VariablesHomework.GetformulaResult(a, b));
        }
        #endregion
        //2
        #region ChangeTheContentOfTheNumbersTest
        [TestCase("kek", "lol", "lol kek")]
        [TestCase("kot", "pes", "pes kot")]
        [TestCase("PokaNaChile", "NaRasslabone", "NaRasslabone PokaNaChile")]
        [TestCase("MozhnoPivko", "Figachit", "Figachit MozhnoPivko")]
        public void ChangeTheContentOfTheNumbersTest(ref string a, ref string b, string expected)
        {
            string actual = VariablesHomework.ChangeTheContentOfTheNumbers(ref a, ref b);
            Assert.AreEqual(expected, actual);
        }
        #endregion
        //3
        #region CalcQuotientTest
        [TestCase(6, 2, 3)]
        [TestCase(-3, 6, -0.5)]
        [TestCase(-100, 50, -2)]
        [TestCase(1.25, 1.25, 1)]
        [TestCase(15.85, -1.25, -12.68)]
        public void CalcQuotientTest(double a, double b, double expected)
        {
            double actual = VariablesHomework.CalcQuotient(a, b);
            Assert.AreEqual(expected, actual);
        }
        #endregion
        //3
        #region CalcRemainderTest
        [TestCase(6, 5, 1)]
        [TestCase(-77, 10, -7)]
        [TestCase(6.25, -1.25, 0)]
        [TestCase(500, 100, 0)]
        [TestCase(2, 5, 2)]
        public void CalcRemainderTest(double a, double b, double expected)
        {
            double actual = VariablesHomework.CalcRemainder(a, b);
            Assert.AreEqual(expected, actual);
        }
        #endregion
        //4
        #region SolveLinearEquationTest
        [TestCase(5, 5, 10, 1)]
        [TestCase(3, 394, -500, -298)]
        [TestCase(9, 100, 99.73, -0.03)]
        [TestCase(0.9, 100, 99.73, -0.3)]
        public void SolveLinearEquationTest(double a, double b, double c, double expected)
        {
            double actual = VariablesHomework.SolveLinearEquation(a, b, c);
            Assert.AreEqual(expected, actual, 0.001);
        }
        #endregion
        //5
        #region GetEquationStraightTest
        [TestCase(7, 5, 9, 3, "y = 1 * x + -12")]
        [TestCase(0, 16, -4, 8, "y = -2 * x + -16")]
        public void GetEquationStraightTest(double x1, double y1, double x2, double y2, string expected)
        {
            string actual = VariablesHomework.GetEquationStraight(x1, y1, x2, y2);
            Assert.AreEqual(expected, actual);
        }
        #endregion
    }
}
