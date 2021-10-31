using System;
namespace MetodTime
{
    public class ArrayHomework
    {
        //1
        #region GetMinimumElementOfArray
        public static int GetMinimumElementOfArray(int[] array)//найти минимальный элемент массива
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
        //2
        #region GetMaximumElementOfArray
        public static int GetMaximumElementOfArray(int[] array)//найти максимальный элемент массива
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
        //3
        #region GetIndexMinimumElementOfArray
        public static int GetIndexMinimumElementOfArray(int[] array)//найти индекс минимального элемента массива
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
        //4
        #region GetIndexMaximumElementOfArray
        public static int GetIndexMaximumElementOfArray(int[] array)//найти индекс максимального элемента массива
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
        //5
        #region CalcSumOddIndexOfArray
        public static int CalcSumOddIndexOfArray(int[] array)//посчитать сумму элементов массива с нечетными индексами
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
        //6
        #region ReverseArray
        public static int[] ReverseArray(int[] array)//реверс
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
        //7
        #region CountNumberOfOddElementsInArray
        public static int CountNumberOfOddElementsInArray(int[] array)//посчитать количество нечетных элементов массива
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
        //8
        #region SwapHalfOfArray
        public static int[] SwapHalfOfArray(int[] array)//поменять местами первую и вторую половину массива
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
        //9
        #region SortTheArrayInAscendingOrder
        public static int[] SortTheArrayInAscendingOrder(int[] array)//отсортировать массив по возрастанию
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
        //10
        #region SortTheArrayInDescendingOrder
        public static int[] SortTheArrayInDescendingOrder(int[] array)//отсортировать массив по убыванию
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
