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
            int value = _valueToSearch;
            int index = value;

            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }
            if (_valueToSearch > array[array.Length - 1])
            {
                index = array.Length - 1;
                array[index] = value;    
            }
            else
            {
                array[index] = value;
            }
            
            //act
            int returned_index = SearchAlgorithm.LinearSearch(array, value);

            //assert
            Assert.AreEqual(index, returned_index);
        }

        [TestMethod]
        public void There_An_Index_In_Array_FastLinearSearch()
        {
            //arrange
            int value = _valueToSearch;
            int index = value;

            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }
            if (_valueToSearch > array[array.Length - 1])
            {
                index = array.Length - 1;
                array[index] = value;
            }
            else
            {
                array[index] = value;
            }

            //act
            int returned_index = SearchAlgorithm.FastLinearSearch(array, value);

            //assert
            Assert.AreEqual(index, returned_index);
        }

        [TestMethod]
        public void There_An_Index_In_Array_BinarySearch()
        {
            //arrange
            int value = _valueToSearch;
            int index = value;

            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }
            if (_valueToSearch > array[array.Length - 1])
            {
                index = array.Length - 1;
                array[index] = value;
            }
            else
            {
                array[index] = value;
            }

            //act
            int returned_index = SearchAlgorithm.BinarySearch(array, value);

            //assert
            Assert.AreEqual(index, returned_index);
        }

        [TestMethod]
        public void There_An_Index_In_Array_JumpSearch()
        {
            //arrange
            int value = _valueToSearch;
            int index = value;

            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }
            if (_valueToSearch > array[array.Length - 1])
            {
                index = array.Length - 1;
                array[index] = value;
            }
            else
            {
                array[index] = value;
            }

            //act
            int returned_index = SearchAlgorithm.JumpSearch(array, value);

            //assert
            Assert.AreEqual(index, returned_index);
        }

        [TestMethod]
        public void There_An_Index_In_Array_InterpolationSearch()
        {
            //arrange
            int value = _valueToSearch;
            int index = value;

            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }
            if (_valueToSearch > array[array.Length - 1])
            {
                index = array.Length - 1;
                array[index] = value;
            }
            else
            {
                array[index] = value;
            }

            //act
            int returned_index = SearchAlgorithm.InterpolationSearch(array, value);

            //assert
            Assert.AreEqual(index, returned_index);
        }

        [TestMethod]
        public void First_Index_In_Array_LinearSearch()
        {
            //arrange
            int value = 1;
            int index = 0;
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = 1;
            }

            //act
            int returned_index = SearchAlgorithm.LinearSearch(array, value);

            //assert
            Assert.AreEqual(index, returned_index);
        }

        [TestMethod]
        public void First_Index_In_Array_FastLinearSearch()
        {
            //arrange
            int value = 1;
            int index = 0;
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = 1;
            }

            //act
            int returned_index = SearchAlgorithm.FastLinearSearch(array, value);

            //assert
            Assert.AreEqual(index, returned_index);
        }

        [TestMethod]
        public void First_Index_In_Array_BinarySearch()
        {
            //arrange
            int value = 1;
            int index = 0;
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = 1;
            }

            //act
            int returned_index = SearchAlgorithm.BinarySearch(array, value);

            //assert
            Assert.AreEqual(index, returned_index);
        }

        [TestMethod]
        public void First_Index_In_Array_JumpSearch()
        {
            //arrange
            int value = 1;
            int index = 0;
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = 1;
            }

            //act
            int returned_index = SearchAlgorithm.JumpSearch(array, value);

            //assert
            Assert.AreEqual(index, returned_index);
        }

        [TestMethod]
        public void First_Index_In_Array_InterpolationSearch()
        {
            //arrange
            int value = 1;
            int index = 0;
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = 1;
            }

            //act
            int returned_index = SearchAlgorithm.InterpolationSearch(array, value);

            //assert
            Assert.AreEqual(index, returned_index);
        }

        [TestMethod]
        public void Last_Index_In_Array_LinearSearch()
        {
            //arrange
            int value = 20;
            int index = 9;
            int[] array = new int[10];
            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = i;
            }
            array[index] = value;

            //act
            int returned_index = SearchAlgorithm.LinearSearch(array, value);

            //assert
            Assert.AreEqual(index, returned_index);
        }

        [TestMethod]
        public void Last_Index_In_Array_FastLinearSearch()
        {
            //arrange
            int value = 20;
            int index = 9;
            int[] array = new int[10];
            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = i;
            }
            array[index] = value;

            //act
            int returned_index = SearchAlgorithm.FastLinearSearch(array, value);

            //assert
            Assert.AreEqual(index, returned_index);
        }

        [TestMethod]
        public void Last_Index_In_Array_BinarySearch()
        {
            //arrange
            int value = 20;
            int index = 9;
            int[] array = new int[10];
            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = i;
            }
            array[index] = value;

            //act
            int returned_index = SearchAlgorithm.BinarySearch(array, value);

            //assert
            Assert.AreEqual(index, returned_index);
        }

        [TestMethod]
        public void Last_Index_In_Array_JumpSearch()
        {
            //arrange
            int value = 20;
            int index = 9;
            int[] array = new int[10];
            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = i;
            }
            array[index] = value;

            //act
            int returned_index = SearchAlgorithm.JumpSearch(array, value);

            //assert
            Assert.AreEqual(index, returned_index);
        }

        [TestMethod]
        public void Last_Index_In_Array_InterpolationSearch()
        {
            //arrange
            int value = 20;
            int index = 9;
            int[] array = new int[10];
            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = i;
            }
            array[index] = value;

            //act
            int returned_index = SearchAlgorithm.InterpolationSearch(array, value);

            //assert
            Assert.AreEqual(index, returned_index);
        }


    }
}
