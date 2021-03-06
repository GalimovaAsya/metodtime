using System;
namespace MetodTime
{
    public class CyclesHomework
    {
        //1 возвести a в степень b
        #region ElevateAToB
        public static double ElevateAToB(double a, double b)
        {
            double x = 1;
            for (int i = 0; i < b; i++)
            {
                x *= a;
            }
            return x;
        }
        #endregion
        //2 получить делители а
        #region GetDividersA
        public static int[] GetDividersA(int a)
        {
            int[] result = new int[1000 / a];
            for (int i = a; i <= 1000; i += a)
            {
                if (i % a == 0)
                {
                    result[(i / a) - 1] = i;
                }
            }
            return result;
        }
        #endregion
        //3 найти количество чисел квадрат которых меньше а
        #region GetNumbersOfSquareLessA
        public static int GetNumbersOfSquareLessA(int a)
        {
            int b = 0;
            for (int i = 1; i < a / 2; i++)
            {
                if (i * i < a)
                {
                    b++;
                }
            }
            return b;
        }
        #endregion
        //4 получить наибольший делитель
        #region GetGreatestDivisor
        public static int GetGreatestDivisor(int a)
        {
            for (int i = a - 1; i < a; i--)
            {
                if (a % i == 0)
                {
                    return i;
                }
            }
            return -1;
        }
        #endregion
        //5 получить сумму чисел делящихся на 7
        #region GetSumNumbersDivibleBySeven
        public static int GetSumNumbersDivibleBySeven(int a, int b)
        {
            int n = 0;
            if (a < b)
            {
                for (int i = a; i < b; i++)
                {
                    if (i % 7 == 0)
                    {
                        n += i;
                    }
                }
            }
            else if (b < a)
            {
                for (int i = b; i < a; i++)
                {
                    if (i % 7 == 0)
                    {
                        n += i;
                    }
                }
            }
            return n;
        }
        #endregion
        //6 ряд фибоначи
        #region GetFibonachchi
        public static int GetFibonachchi(int number)
        {
            int pervoe = 1;
            int vtoroe = 0;
            int sum = 0;
            for (int i = 2; i <= number; i++)
            {
                sum = pervoe + vtoroe;
                vtoroe = pervoe;
                pervoe = sum;
            }
            return pervoe;
        }
        #endregion
        //7 наибольший общий делитель евклида
        #region GetGreatesDevidersEvklid
        public static int GetGreatesDevidersEvklid(int one, int two)
        {
            while (one != two)
            {
                if (one > two)
                {
                    one -= two;
                }
                else
                {
                    two -= one;
                }
            }
            return one;
        }
        #endregion
        //8 найти н методом половинного делелния
        #region RecieveNByMethodOfHalfDivision
        public static int RecieveNByMethodOfHalfDivision(int a)
        {
            int left = 1;
            int right = a;
            int n;
            do
            {
                n = (left + right) / 2;
                if (Math.Pow(n, 3) > a)
                {
                    right = n;
                }
                else
                {
                    left = n;
                }
            }
            while (Math.Pow(n, 3) != a);
            return n;
        }
        #endregion
        //9 найти количество нечетных цифр
        #region FindNumbersOfOddDigits
        public static int FindNumbersOfOddDigits(int a)
        {
            int w = 0;
            while (a != 0)
            {
                int x = a % 10;
                a /= 10;

                if (x % 2 != 0)
                {
                    w++; ;
                }
            }
            return w;
        }
        #endregion
        //10 найти зеркальное число
        #region FindMirrorNumber
        public static int FindMirrorNumber(int a)
        {
            int w = 0;
            while (a != 0)
            {
                w = w * 10 + a % 10;
                a /= 10;
            }
            return w;
        }
        #endregion
        //11 сумма четных больше суммы нечетных
        #region GetSummOfEvenIsGreaterThanSummOfOdd
        public static string GetSummOfEvenIsGreaterThanSummOfOdd(int n)
        {
            int chet = 0;
            int nechet = 0;
            while (n != 0)
            {
                int tmp = n % 10;
                if (tmp % 2 == 0)
                {
                    chet += tmp;
                }
                else
                {
                    nechet += tmp;
                }
                n /= 10;
            }
            if (chet > nechet)
            {
                return $"{chet}";
            }
            else
            {
                return $"сумма четных цифр меньше суммы нечетных";
            }
        }
        #endregion
        //12 есть ли одинаковые цифры
        #region IsThereTheSameNumbers
        public static bool IsThereTheSameNumbers(int a, int b)
        {
            bool proverka = false;
            while (a != 0)
            {
                while (b != 0)
                {
                    int tmpa = a % 10;
                    int tmpb = b % 10;
                    if (tmpb == tmpa)
                    {
                        proverka = true;
                    }
                    b /= 10;
                    a /= 10;
                }
            }
            return proverka;
        }
        #endregion
    }
}
