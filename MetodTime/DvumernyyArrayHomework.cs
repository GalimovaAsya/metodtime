using System;
namespace MetodTime
{
    public class DvumernyyArrayHomework
    {
        //1 найти минимальный элемент двумерного массива
        #region GetMinimumElementOfDvumernyyArray
        /// <summary>
        /// exception
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int GetMinimumElementOfDvumernyyArray(int[,] array)
        {
            int min = array[0,0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] < min)
                    {
                        min = array[i, j];
                    }
                    if (array.GetLength(0) == 0 || array.GetLength(1) == 0)
                    {
                        throw new IndexOutOfRangeException("array is empty");
                    }
                }
            }
            return min;
        }
        #endregion
        //2 найти максимальный элемент двумерного массива
        #region GetMaximumElementOfDvumernyyArray
        /// <summary>
        /// exception
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int GetMaximumElementOfDvumernyyArray(int[,] array)
        {
            int max = array[0, 0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > max)
                    {
                        max = array[i, j];
                    }
                    if (array.GetLength(0) == 0 || array.GetLength(1) == 0)
                    {
                        throw new IndexOutOfRangeException("array is empty");
                    }
                }
            }
            return max;
        }
        #endregion GetIndexMinimumElementOfDvumeryyArray
        //3 найти индекс минимального элемента массива
        #region GetIndexMinimumElementOfDvumeryyArray
        /// <summary>
        /// exception
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int[] GetIndexMinimumElementOfDvumeryyArray(int[,] array)
        {
            int min = array[0, 0];
            int[] indexmin = new int[2];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] < min)
                    {
                        min = array[i, j];
                        indexmin[0] = i;
                        indexmin[1] = j;
                    }
                    if (array.GetLength(0) == 0 || array.GetLength(1) == 0)
                    {
                        throw new IndexOutOfRangeException("array is empty");
                    }
                }
            }
            return indexmin;
        }
        #endregion
        //4 найти индекс минимального элемента массива
        #region GetIndexMaximumElementOfDvumeryyArray
        /// <summary>
        /// exception
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int[] GetIndexMaximumElementOfDvumeryyArray(int[,] array)
        {
            int max = array[0, 0];
            int[] indexmax = new int[2];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > max)
                    {
                        max = array[i, j];
                        indexmax[0] = i;
                        indexmax[1] = j;
                    }
                    if (array.GetLength(0) == 0 || array.GetLength(1) == 0)
                    {
                        throw new IndexOutOfRangeException("array is empty");
                    }
                }
            }
            return indexmax;
        }
        #endregion
        //5 найти количество элементов массива, которые больше всех своих соседей одновременно
        #region GetNumberElementsMoreThanNeighborsOfArray
        public static int GetNumberElementsMoreThanNeighborsOfArray(int[,] array)
        {
            int number = 0;
            for (int i = 0; i<array.GetLength(0); i++)
            {
                for (int j = 0; j<array.GetLength(1); j++)
                {
                    if ((i == 0 || array[i, j] > array[i - 1, j])
                        && (j == 0 || array[i, j] > array[i, j - 1])
                        && (i == array.GetLength(0) - 1 || array[i, j] > array[i + 1, j])
                        && (i == array.GetLength(1) - 1 || array[i, j] > array[i, j + 1]))
                    {
                        number++;
                    }
                }
            }
            return number;
        }
        #endregion
        //6 отразите массив относительно его главной диагонали
        #region FlipArrayRelativeToMainDiagonal
        public static int[,] FlipArrayRelativeToMainDiagonal(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    int tmp = array[i, j];
                    array[i, j] = array[j, i];
                    array[j, i] = tmp;
                }
            }
            return array;
        }
        #endregion
    }
}
