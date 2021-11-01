using System;
namespace MetodTime
{
    public class VariablesHomework
    {
        //1
        #region GetformulaResult
        /// <summary>
        /// a!=b
        /// </summary>
        /// <param name = "a" ></ param >
        /// < param name="b"></param>
        /// <returns></returns>
        public static double GetformulaResult(double a, double b)
        {
            double result = ((a * 5) + (b * b)) / (b - a);
            if (a == b)
            {
                throw new ArgumentException("double a should not be equal to double b");
            }
            return result;
        }
        #endregion
        //2
        #region ChangeTheContentOfTheNumbers
        public static string ChangeTheContentOfTheNumbers(ref string a, ref string b)
        {
            string tmp = a;
            a = b;
            b = tmp;
            return $"{a} {b}";
        }
        #endregion
        //3
        #region CalcQuotient
        public static double CalcQuotient(double a, double b)
        {
            double result = a / b;
            return result;
        }
        //3
        public static double CalcRemainder(double a, double b)
        {
            double result = a % b;
            return result;
        }
        #endregion
        //4
        #region SolveLinearEquation
        public static double SolveLinearEquation(double a, double b, double c)
        {
            double x = (c - b) / a;
            return x;

        }
        #endregion
        //5
        #region GetEquationStraight
        public static string GetEquationStraight(double x1, double y1, double x2, double y2)
        {
            double a;
            double b;
            a = (y1 - y2) / (x2 - x1);
            b = (x1 * y2 - x2 * y1) / (x2 - x1);
            return $"y = {a} * x + {b}";
        }
        #endregion
    }
}
