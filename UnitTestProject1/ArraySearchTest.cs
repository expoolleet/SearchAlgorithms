using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Reflection;

namespace SearchAlgorithms.Tests
{
    [TestClass]
    public class ArraySearchTest
    {
        private int _valueToSearch = 10;

        [TestMethod]
        public void There_An_Index_In_Array_LinearSearch()
        {
            //arrange
            int[] array = { -3, 0, 1, 3, 4, 5, 7, 8, 12 };
            int index = 4;
            var value = 4;
            
            //act
            int returned_index = SearchAlgorithm.LinearSearch(array, value);

            //assert
            Assert.AreEqual(index, returned_index);
        }

        [TestMethod]
        public void There_An_Index_In_Array_FastLinearSearch()
        {
            //arrange
            int[] array = { -3, 0, 1, 3, 4, 5, 7, 8, 12 };
            int index = 4;
            var value = 4;

            //act
            int returned_index = SearchAlgorithm.FastLinearSearch(array, value);

            //assert
            Assert.AreEqual(index, returned_index);
        }

        [TestMethod]
        public void There_An_Index_In_Array_BinarySearch()
        {
            //arrange
            int[] array = { -3, 0, 1, 3, 4, 5, 7, 8, 12 };

            int index = 4;
            var value = 4;

            //act
            int returned_index = SearchAlgorithm.BinarySearch(array, value);
            int returned_index_recursive = SearchAlgorithm.BinarySearchRecursive(array, value, 0, array.Length);

            //assert
            Assert.AreEqual(index, returned_index);
            Assert.AreEqual(returned_index, returned_index_recursive);
        }

        [TestMethod]
        public void There_An_Index_In_Array_JumpSearch()
        {
            //arrange
            int[] array = { -3, 0, 1, 3, 4, 5, 7, 8, 12 };
            int index = 4;
            var value = 4;

            //act
            int returned_index = SearchAlgorithm.JumpSearch(array, value);

            //assert
            Assert.AreEqual(index, returned_index);
        }

        [TestMethod]
        public void There_An_Index_In_Array_InterpolationSearch()
        {
            //arrange
            int[] array = { -3, 0, 1, 3, 4, 5, 7, 8, 12 };
            int index = 4;
            var value = 4;

            //act
            int returned_index = SearchAlgorithm.InterpolationSearch(array, value);

            //assert
            Assert.AreEqual(index, returned_index);
        }

        [TestMethod]
        public void First_Index_In_Array_LinearSearch()
        {
            //arrange
            int[] array = { -2, -1, -1, 3, 4, 5, 7, 8, 12 };
            int index = 1;
            var value = -1;

            //act
            int returned_index = SearchAlgorithm.LinearSearch(array, value);

            //assert
            Assert.AreEqual(index, returned_index);
        }

        [TestMethod]
        public void First_Index_In_Array_FastLinearSearch()
        {
            //arrange
            int[] array = { -2, -1, -1, 3, 4, 5, 7, 8, 12 };
            int index = 1;
            var value = -1;

            //act
            int returned_index = SearchAlgorithm.FastLinearSearch(array, value);

            //assert
            Assert.AreEqual(index, returned_index);
        }

        [TestMethod]
        public void First_Index_In_Array_BinarySearch()
        {
            //arrange
            int[] array = { -1, -1, -1, -1, -1, -1, -1, -1, -1 };
            int index = 0;
            var value = -1;

            //act
            int returned_index = SearchAlgorithm.BinarySearch(array, value);
            int returned_index_recursive = SearchAlgorithm.BinarySearchRecursive(array, value, 0, array.Length);

            //assert
            Assert.AreEqual(index, returned_index);
            Assert.AreEqual(returned_index, returned_index_recursive);
        }

        [TestMethod]
        public void First_Index_In_Array_JumpSearch()
        {
            //arrange
            int[] array = { -2, -1, -1, 3, 4, 5, 7, 8, 12 };
            int index = 1;
            var value = -1;

            //act
            int returned_index = SearchAlgorithm.JumpSearch(array, value);

            //assert
            Assert.AreEqual(index, returned_index);
        }

        [TestMethod]
        public void First_Index_In_Array_InterpolationSearch()
        {
            //arrange
            int[] array = { -2, -1, -1, 3, 4, 5, 7, 8, 12 };
            int index = 1;
            var value = -1;

            //act
            int returned_index = SearchAlgorithm.InterpolationSearch(array, value);

            //assert
            Assert.AreEqual(index, returned_index);
        }

        [TestMethod]
        public void Last_Index_In_Array_LinearSearch()
        {
            //arrange
            int[] array = { -3, 0, 1, 3, 4, 5, 7, 8, 12 };
            int index = array.Length - 1;
            var value = 12;

            //act
            int returned_index = SearchAlgorithm.LinearSearch(array, value);

            //assert
            Assert.AreEqual(index, returned_index);
        }

        [TestMethod]
        public void Last_Index_In_Array_FastLinearSearch()
        {
            //arrange
            int[] array = { -3, 0, 1, 3, 4, 5, 7, 8, 12 };
            int index = array.Length - 1;
            var value = 12;

            //act
            int returned_index = SearchAlgorithm.FastLinearSearch(array, value);

            //assert
            Assert.AreEqual(index, returned_index);
        }

        [TestMethod]
        public void Last_Index_In_Array_BinarySearch()
        {
            //arrange
            int[] array = { -3, 0, 1, 3, 4, 5, 7, 8, 12 };
            int index = array.Length - 1;
            var value = 12;

            //act
            int returned_index = SearchAlgorithm.BinarySearch(array, value);
            int returned_index_recursive = SearchAlgorithm.BinarySearchRecursive(array, value, 0, array.Length);

            //assert
            Assert.AreEqual(index, returned_index);
            Assert.AreEqual(returned_index, returned_index_recursive);
        }

        [TestMethod]
        public void Last_Index_In_Array_JumpSearch()
        {
            //arrange
            int[] array = { -3, 0, 1, 3, 4, 5, 7, 8, 12 };
            int index = array.Length - 1;
            var value = 12;

            //act
            int returned_index = SearchAlgorithm.JumpSearch(array, value);

            //assert
            Assert.AreEqual(index, returned_index);
        }

        [TestMethod]
        public void Last_Index_In_Array_InterpolationSearch()
        {
            //arrange
            int[] array = { -3, 0, 1, 3, 4, 5, 7, 8, 12 };
            int index = array.Length - 1;
            var value = 12;

            //act
            int returned_index = SearchAlgorithm.InterpolationSearch(array, value);

            //assert
            Assert.AreEqual(index, returned_index);
        }

        [TestMethod]
        public void There_Is_No_Index_In_Array_LinearSearch()
        {
            //arange
            int[] array = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int index = -1;
            var value = 11;

            //act
            int returned_index = SearchAlgorithm.LinearSearch(array, value);

            //assert
            Assert.AreEqual(index, returned_index);
        }

        [TestMethod]
        public void There_Is_No_Index_In_Array_FastLinearSearch()
        {
            //arange
            int[] array = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int index = -1;
            var value = 11;

            //act
            int returned_index = SearchAlgorithm.FastLinearSearch(array, value);

            //assert
            Assert.AreEqual(index, returned_index);
        }

        [TestMethod]
        public void There_Is_No_Index_In_Array_BinarySearch()
        {
            //arange
            int[] array = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int index = -1;
            var value = 11;

            //act
            int returned_index = SearchAlgorithm.BinarySearch(array, value);
            int returned_index_recursive = SearchAlgorithm.BinarySearchRecursive(array, value, 0, array.Length - 1);

            //assert
            Assert.AreEqual(index, returned_index);
            Assert.AreEqual(returned_index, returned_index_recursive);
        }

        [TestMethod]
        public void There_Is_No_Index_In_Array_JumpSearch()
        {
            //arange
            int[] array = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int index = -1;
            var value = 11;

            //act
            int returned_index = SearchAlgorithm.JumpSearch(array, value);

            //assert
            Assert.AreEqual(index, returned_index);
        }

        [TestMethod]
        public void There_Is_No_Index_In_Array_InterpolationSearch()
        {
            //arange
            int[] array = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int index = -1;
            var value = 11;

            //act
            int returned_index = SearchAlgorithm.InterpolationSearch(array, value);

            //assert
            Assert.AreEqual(index, returned_index);
        }
    }
}
