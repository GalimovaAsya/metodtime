using System;
using NUnit.Framework;
using MetodTime;
namespace metodtimeTest
{
    public class DvumernyyArrayHomeworkTest
    {
        //mock
        #region Mock
        public int[,] GetDvumeryyArrayMock(string arrayType)
        {
            switch (arrayType)
            {
                case "Usual1":
                    return new int[,] {
                        { 1, 2, 3, 4 },
                        { 1, 2, 3, 4 }
                    };
                case "Usual2":
                    return new int[,] {
                        {-5, -2 },
                        {-8, -9 }
                    };
                case "Usual3":
                    return new int[,] {
                        {6, 1, -2, 3, 9 },
                        {-4, -6, -9, 1, -5 }
                    };
                case "Empty":
                    return new int[,] { };
                default:
                    return new int[,] { };
            }
        }
        #endregion
        //1
        #region GetMinimumElementOfDvumernyyArrayTest
        [TestCase("Usual1", 1)]
        [TestCase("Usual2", -9)]
        [TestCase("Usual3", -9)]
        public void GetMinimumElementOfDvumernyyArrayTest(string arrayType, int expected)
        {
            int[,] array = GetDvumeryyArrayMock(arrayType);
            int actual = DvumernyyArrayHomework.GetMinimumElementOfDvumernyyArray(array);
            Assert.AreEqual(expected, actual);
        }
        [TestCase("Empty")]
        public void GetMinimumElementOfDvumernyyArrayTest_WhenArrayIsEmpty_ShouldThrowsArgumentException(string arrayType)
        {
            int[,] array = GetDvumeryyArrayMock(arrayType);
            Assert.Throws<IndexOutOfRangeException>(()=>DvumernyyArrayHomework.GetMinimumElementOfDvumernyyArray(array)) ;
        }
        #endregion
        //2
        #region GetMaximumElementOfDvumernyyArrayTest
        [TestCase("Usual1", 4)]
        [TestCase("Usual2", -2)]
        [TestCase("Usual3", 9)]
        public void GetMaximumElementOfDvumernyyArrayTest(string arrayType, int expected)
        {
            int[,] array = GetDvumeryyArrayMock(arrayType);
            int actual = DvumernyyArrayHomework.GetMaximumElementOfDvumernyyArray(array);
            Assert.AreEqual(expected, actual);
        }
        [TestCase("Empty")]
        public void GetMaximumElementOfDvumernyyArrayTest_WhenArrayIsEmpty_ShouldThrowsArgumentException(string arrayType)
        {
            int[,] array = GetDvumeryyArrayMock(arrayType);
            Assert.Throws<IndexOutOfRangeException>(() => DvumernyyArrayHomework.GetMaximumElementOfDvumernyyArray(array));
        }
        #endregion
        //3
        #region GetIndexMinimumElementOfDvumeryyArrayTest
        [TestCase("Usual1", new int[] { 0, 0 })]
        [TestCase("Usual2", new int[] { 1, 1 })]
        [TestCase("Usual3", new int[] { 1, 2 })]
        public void GetIndexMinimumElementOfDvumeryyArrayTest(string arrayType, int[] expected)
        {
            int[,] array = GetDvumeryyArrayMock(arrayType);
            int[] actual = DvumernyyArrayHomework.GetIndexMinimumElementOfDvumeryyArray(array);
            Assert.AreEqual(expected, actual);
        }
        [TestCase("Empty")]
        public void GetIndexMinimumElementOfDvumeryyArrayTest_WhenArrayIsEmpty_ShouldThrowsArgumentException(string arrayType)
        {
            int[,] array = GetDvumeryyArrayMock(arrayType);
            Assert.Throws<IndexOutOfRangeException>(() => DvumernyyArrayHomework.GetIndexMinimumElementOfDvumeryyArray(array));
        }
        #endregion
        //4
        #region GetIndexMaximumElementOfDvumeryyArrayTest
        [TestCase("Usual1", new int[] { 0, 3 })]
        [TestCase("Usual2", new int[] { 0, 1 })]
        [TestCase("Usual3", new int[] { 0, 4 })]
        //[TestCase("Empty", new int[] { 0, 0 })]
        public void GetIndexMaximumElementOfDvumeryyArrayTest(string arrayType, int[] expected)
        {
            int[,] array = GetDvumeryyArrayMock(arrayType);
            int[] actual = DvumernyyArrayHomework.GetIndexMaximumElementOfDvumeryyArray(array);
            Assert.AreEqual(expected, actual);
        }
        [TestCase("Empty")]
        public void GetIndexMaximumElementOfDvumeryyArrayTest_WhenArrayIsEmpty_ShouldThrowsArgumentException(string arrayType)
        {
            int[,] array = GetDvumeryyArrayMock(arrayType);
            Assert.Throws<IndexOutOfRangeException>(() => DvumernyyArrayHomework.GetIndexMaximumElementOfDvumeryyArray(array));
        }
        #endregion
        //5
        #region
        [TestCase("Usual1", 0)]
        [TestCase("Usual2", 1)]
        [TestCase("Usual3", 2)]
        public void GetNumberElementsMoreThanNeighborsOfArrayTest(string arrayType, int expected)
        {
            int[,] array = GetDvumeryyArrayMock(arrayType);
            int actual = DvumernyyArrayHomework.GetNumberElementsMoreThanNeighborsOfArray(array);
            Assert.AreEqual(expected, actual);
        }
        [TestCase("Empty")]
        public void GetNumberElementsMoreThanNeighborsOfArrayTest_WhenArrayIsEmpty_ShouldThrowsArgumentException(string arrayType)
        {
            int[,] array = GetDvumeryyArrayMock(arrayType);
            Assert.Throws<IndexOutOfRangeException>(() => DvumernyyArrayHomework.GetNumberElementsMoreThanNeighborsOfArray(array));
        }
        //тут будет тест
        #endregion
        //6
        #region
        //и тут тоже он будет
        #endregion
       
    }
}
