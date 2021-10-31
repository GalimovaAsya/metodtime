using System;
using NUnit.Framework;
using MetodTime;
namespace metodtimeTest
{
    public class ArrayHomeworkTests
    {
        //1
        #region GetMinimumElementOfArrayTest
        [TestCase(new int[] { 0, 1, 2, 3, 4, 5 }, 0)]
        [TestCase(new int[] { 0, -1, -2, -3, -4, -5 }, -5)]
        [TestCase(new int[] { 8576, 8780, 6987, 6364, 47680, 50987 }, 6364)]
        [TestCase(new int[] { -87, 64, 0 }, -87)]
        [TestCase(new int[] { 0, 0 }, 0)]
        public void GetMinimumElementOfArrayTest(int[] array, int expected)
        {
            int actual = ArrayHomework.GetMinimumElementOfArray(array);
            Assert.AreEqual(expected, actual);
        }
        #endregion
        //2
        #region GetMinMaximumElementOfArrayTest
        [TestCase(new int[] { 0, 1, 2, 3, 4, 5 }, 5)]
        [TestCase(new int[] { 0, -1, -2, -3, -4, -5 }, 0)]
        [TestCase(new int[] { 8576, 8780, 6987, 6364, 47680, 50987 }, 50987)]
        [TestCase(new int[] { -87, 64, 0 }, 64)]
        [TestCase(new int[] { 0, 0 }, 0)]
        public void GetMinMaximumElementOfArrayTest(int[] array, int expected)
        {
            int actual = ArrayHomework.GetMaximumElementOfArray(array);
            Assert.AreEqual(expected, actual);
        }
        #endregion
        //3
        #region GetIndexMinimumElementOfArrayTest
        [TestCase(new int[] { 0, 1, 2, 3, 4, 5 }, 0)]
        [TestCase(new int[] { 0, -1, -2, -3, -4, -5 }, 5)]
        [TestCase(new int[] { 8576, 8780, 6987, 6364, 47680, 50987 }, 3)]
        [TestCase(new int[] { -87, 64, 0 }, 0)]
        [TestCase(new int[] { 0, 0 }, 0)]
        public void GetIndexMinimumElementOfArrayTest(int[] array, int expected)
        {
            int actual = ArrayHomework.GetIndexMinimumElementOfArray(array);
            Assert.AreEqual(expected, actual);
        }
        #endregion
        //4
        #region GetIndexMaximumElementOfArrayTest
        [TestCase(new int[] { 0, 1, 2, 3, 4, 5 }, 5)]
        [TestCase(new int[] { 0, -1, -2, -3, -4, -5 }, 0)]
        [TestCase(new int[] { 8576, 8780, 6987, 6364, 47680, 50987 }, 5)]
        [TestCase(new int[] { -87, 64, 0 }, 1)]
        [TestCase(new int[] { 0, 0 }, 0)]
        public void GetIndexMaximumElementOfArrayTest(int[] array, int expected)
        {
            int actual = ArrayHomework.GetIndexMaximumElementOfArray(array);
            Assert.AreEqual(expected, actual);
        }
        #endregion
        //5
        #region CalcSumOddIndexOfArrayTest
        [TestCase(new int[] { 3, 2, 4, 0, 13 }, 2)]
        [TestCase(new int[] { -49, -5, -2, -21, -56 }, -26)]
        [TestCase(new int[] { -3, 2, -497, 0, 13, -95 }, -93)]
        [TestCase(new int[] { 0, 0, 0 }, 0)]
        public void CalcSumOddIndexOfArrayTest(int[] array, int expected)
        {
            int actual = ArrayHomework.CalcSumOddIndexOfArray(array);
            Assert.AreEqual(expected, actual);
        }
        #endregion
        //6
        #region ReverseArrayTest
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 5, 4, 3, 2, 1 })]
        [TestCase(new int[] { -15, -4, -1, 376 }, new int[] { 376, -1, -4, -15 })]
        [TestCase(new int[] { 0, 0, 0 }, new int[] { 0, 0, 0 })]
        public void ReverseArrayTest(int[] array, int[] expected)
        {
            int[] actual = ArrayHomework.ReverseArray(array);
            Assert.AreEqual(expected, actual);
        }
        #endregion
        //7
        #region CountNumberOfOddElementsInArrayTest
        [TestCase(new int[] { 3, 2, 4, 0, 13 }, 2)]
        [TestCase(new int[] { -49, -5, -2, -21, -56 }, 3)]
        [TestCase(new int[] { -3, 2, -497, 0, 13, -95 }, 4)]
        [TestCase(new int[] { 0, 0, 0 }, 0)]
        public void CountNumberOfOddElementsInArrayTest(int[] array, int expected)
        {
            int actual = ArrayHomework.CountNumberOfOddElementsInArray(array);
            Assert.AreEqual(expected, actual);
        }
        #endregion
        //8
        #region SwapHalfOfArrayTest
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 4, 5, 3, 1, 2 })]
        [TestCase(new int[] { -15, -4, -1, 376 }, new int[] { -1, 376, -15, -4 })]
        [TestCase(new int[] { 0, 0, 0 }, new int[] { 0, 0, 0 })]
        public void SwapHalfOfArrayTest(int[] array, int[] expected)
        {
            int[] actual = ArrayHomework.SwapHalfOfArray(array);
            Assert.AreEqual(expected, actual);
        }
        #endregion
        //9
        #region SortTheArrayInAscendingOrderTest
        [TestCase(new int[] { 3, 2, 4, 0, 13 }, new int[] { 0, 2, 3, 4, 13 })]
        [TestCase(new int[] { -49, -5, -2, -21, -56 }, new int[] { -56, -49, -21, -5, -2 })]
        [TestCase(new int[] { -3, 2, -497, 0, 13, -95 }, new int[] { -497, -95, -3, 0, 2, 13 })]
        [TestCase(new int[] { 0, 0, 0 }, new int[] { 0, 0, 0 })]
        public void SortTheArrayInAscendingOrderTest(int[] array, int[] expected)
        {
            int[] actual = ArrayHomework.SortTheArrayInAscendingOrder(array);
            Assert.AreEqual(expected, actual);
        }
        #endregion
        //10
        #region SortTheArrayInDescendingOrderTest
        [TestCase(new int[] { 3, 2, 4, 0, 13 }, new int[] { 13, 4, 3, 2, 0 })]
        [TestCase(new int[] { -49, -5, -2, -21, -56 }, new int[] { -2, -5, -21, -49, -56 })]
        [TestCase(new int[] { -3, 2, -497, 0, 13, -95 }, new int[] { 13, 2, 0, -3, -95, -497 })]
        [TestCase(new int[] { 0, 0, 0 }, new int[] { 0, 0, 0 })]
        public void SortTheArrayInDescendingOrderTest(int[] array, int[] expected)
        {
            int[] actual = ArrayHomework.SortTheArrayInDescendingOrder(array);
            Assert.AreEqual(expected, actual);
        }
        #endregion
    }
}

