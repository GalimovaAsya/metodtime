using System;
namespace MetodTime
{
    public class BranchingStructuresHomework
    {
        //1 посчитать по условиям
        #region CountByConditions
        public static double CountByConditions(double a, double b)
        {
            double result = 0;
            if (a > b)
            {
                result = a + b;
            }
            else
            {
                if (a == b)
                {
                    result = a * b;
                }
                else
                {
                    result = a - b;
                }
            }
            return result;
        }
        #endregion
        //2 найти четверть
        #region FindQuarter
        /// <summary>
        /// exception
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static int FindQuarter(double x, double y)
        {
            int quarter = 0;
            if (x > 0 && y > 0)
            {
                quarter = 1;
            }
            if (x > 0 && y < 0)
            {
                quarter = 2;
            }
            if (x < 0 && y < 0)
            {
                quarter = 3;
            }
            if (x < 0 && y > 0)
            {
                quarter = 4;
            }
            else
            {
                if (x == 0 && y == 0)
                {
                    throw new ArgumentException("point is at the origin");
                }
                if (x == 0 || y == 0)
                {
                    throw new ArgumentException("point is on the axis");
                }
            }
            return quarter;
        }
        #endregion
        //3 получить порядок по возрастанию
        #region GetAscendingOrder
        public static int[] GetAscendingOrder(int a, int b, int c)
        {
            int[] order = new int[3];
            if (a < b)
            {
                if (b < c)
                {
                    order = new int[] { a, b, c };
                }
                else
                {
                    order = new int[] { a, c, b };
                }
            }
            if (c < a)
            {
                if (a < b)
                {
                    order = new int[] { c, a, b };
                }
                else
                {
                    order = new int[] { c, b, a };
                }
            }
            if (b < a)
            {
                if (a < c)
                {
                    order = new int[] { b, a, c };
                }

                else
                {
                    order = new int[] { b, c, a };
                }
            }
            return order;
        }
        #endregion
        //4 решить квадратное уравнение
        #region SolveQuadraticEquation
        public static double[] SolveQuadraticEquation(double a, double b, double c)
        {
            double diskriminant = b * b - 4 * a * c;
            double x = 0;
            double x1 = 0;
            double x2 = 0;
            if (diskriminant == 0)
            {
                x = ((-b) / 2 * a);
                double[] result = new double[1];
                result = new double[] { x };
                return result;
            }
            if (diskriminant > 0)
            {
                x1 = ((-b) + Math.Sqrt(diskriminant)) / (2 * a);
                x2 = ((-b) - Math.Sqrt(diskriminant)) / (2 * a);
                double[] result = new double[2];
                result = new double[] { x1, x2 };
                return result;
            }
            else
            {
                double[] result = new double[1];
                result = new double[] { 0 };
                return result;
            }
        }
        #endregion
        //5 получть надпись
        #region GetAnInscription
        /// <summary>
        /// exception
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static string GetAnInscription(int a)
        {
            int q = a / 10;
            int w = a % 10;
            string s = "";
            if (q != 1)
            {
                switch (q)
                {
                    case 2:
                        s += "двадцать ";
                        break;
                    case 3:
                        s += "тридцать ";
                        break;
                    case 4:
                        s += "сорок ";
                        break;
                    case 5:
                        s += "пятьдесят ";
                        break;
                    case 6:
                        s += "шестьдесят ";
                        break;
                    case 7:
                        s += "семьдесят ";
                        break;
                    case 8:
                        s += "восемьдесят ";
                        break;
                    case 9:
                        s += "девяносто ";
                        break;
                }

                switch (w)
                {
                    case 1:
                        s += "один";
                        break;
                    case 2:
                        s += "два";
                        break;
                    case 3:
                        s += "три";
                        break;
                    case 4:
                        s += "четыре";
                        break;
                    case 5:
                        s += "пять";
                        break;
                    case 6:
                        s += "шесть";
                        break;
                    case 7:
                        s += "семь";
                        break;
                    case 8:
                        s += "восемь";
                        break;
                    case 9:
                        s += "девять";
                        break;
                }
            }
            else
            {
                switch (a)
                {
                    case 10:
                        s += "десять";
                        break;
                    case 11:
                        s += "одинадцать";
                        break;
                    case 12:
                        s += "двенадцать";
                        break;
                    case 13:
                        s += "тринадцать";
                        break;
                    case 14:
                        s += "четырнадцать";
                        break;
                    case 15:
                        s += "пятнадцать";
                        break;
                    case 16:
                        s += "шестнадцать";
                        break;
                    case 17:
                        s += "семнадцать";
                        break;
                    case 18:
                        s += "восемнадцать";
                        break;
                    case 19:
                        s += "девятнадцать";
                        break;
                }
            }
            if (a < 10 || a > 99)
            {
                throw new IndexOutOfRangeException("int a is out of range");
            }
            return $"{s}";
        }
        #endregion
    }
}
