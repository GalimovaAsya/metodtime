using System;
namespace MetodTime
{
    public class ArrayHomework
    {
        //1 найти минимальный элемент массива
        #region GetMinimumElementOfArray
        public static int GetMinimumElementOfArray(int[] array)
        {
            int min = array[0];
            for (int i = 0; i < array.Length; i++)//1
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            return min;
        }
        #endregion
        //2 найти максимальный элемент массива
        #region GetMaximumElementOfArray
        public static int GetMaximumElementOfArray(int[] array)
        {
            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }
        #endregion
        //3 найти индекс минимального элемента массива
        #region GetIndexMinimumElementOfArray
        public static int GetIndexMinimumElementOfArray(int[] array)
        {
            int min = array[0];
            int indexmin = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    indexmin = i;
                }
            }
            return indexmin;
        }
        #endregion
        //4 найти индекс максимального элемента массива
        #region GetIndexMaximumElementOfArray
        public static int GetIndexMaximumElementOfArray(int[] array)
        {
            int max = array[0];
            int indexmax = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    indexmax = i;
                }
            }
            return indexmax;
        }
        #endregion
        //5 посчитать сумму элементов массива с нечетными индексами
        #region CalcSumOddIndexOfArray
        public static int CalcSumOddIndexOfArray(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 != 0)
                {
                    sum += array[i];
                }
            }
            return sum;
        }
        #endregion
        //6 реверс
        #region ReverseArray
        public static int[] ReverseArray(int[] array)
        {
            int max = array[0];
            int tmp = 0;
            int x = 0;
            int y = array.Length - 1;
            while (x < y)
            {
                tmp = array[x];
                array[x] = array[y];
                array[y] = tmp;
                x++;
                y--;
            }
            for (x = 0; x < array.Length; x++)
            {
            }
            return array;
        }
        #endregion
        //7 посчитать количество нечетных элементов массива
        #region CountNumberOfOddElementsInArray
        public static int CountNumberOfOddElementsInArray(int[] array)
        {
            int kolich = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    kolich++;
                }
            }
            return kolich;
        }
        #endregion
        //8 поменять местами первую и вторую половину массива
        #region SwapHalfOfArray
        public static int[] SwapHalfOfArray(int[] array)
        {
            int k = array.Length % 2;
            for (int i = 0; i < array.Length / 2; i++)
            {
                int tmp = array[i];
                array[i] = array[array.Length / 2 + i + k];
                array[array.Length / 2 + i + k] = tmp;
            }
            for (int i = 0; i < array.Length; i++)
            {
            }
            return array;
        }
        #endregion
        //9 отсортировать массив по возрастанию
        #region SortTheArrayInAscendingOrder
        public static int[] SortTheArrayInAscendingOrder(int[] array)
        {
            int tmp = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        tmp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = tmp;
                    }
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                //Console.Write($"{array[i]} ");
            }
            return array;
        }
        #endregion
        //10 отсортировать массив по убыванию
        #region SortTheArrayInDescendingOrder
        public static int[] SortTheArrayInDescendingOrder(int[] array)
        {
            int tmp = 0;
            for (int i = 0; i < array.Length; i++)
            {
                int index = 0;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        tmp = array[i];
                        array[i] = array[j];
                        array[j] = tmp;
                    }
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                //Console.Write($"{array[i]} ");
            }
            return array;
        }
        #endregion
    }
}
