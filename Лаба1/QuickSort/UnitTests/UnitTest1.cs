using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickSort;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSortVal()
        {
            int[] arr = { 5, 1, 3, 2, 4 };
            QuickSort<int> qsort = new QuickSort<int>();
            qsort.QuicksortGeneric(arr, 0, 4);
            int[] expArr = { 1, 2, 3, 4, 5 };
            CollectionAssert.AreEqual(arr, expArr);
        }


        [TestMethod]
        public void TestNegativeVal()
        {
            int[] arr = { -3, -1, -7, -5, -2 };
            QuickSort<int> qsort = new QuickSort<int>();
            qsort.QuicksortGeneric(arr, 0, 4);
            int[] expArr = { -7, -5, -3, -2, -1 };
            CollectionAssert.AreEqual(arr, expArr);
        }

        [TestMethod]
        public void TestFactionalVal()
        {
            double[] arr = { 6.4, 2.3, 7.1, 1.1, 0.2 };
            QuickSort<double> qsort = new QuickSort<double>();
            qsort.QuicksortGeneric(arr, 0, 4);
            double[] expArr = {0.2, 1.1 ,2.3 ,6.4 , 7.1 };
            CollectionAssert.AreEqual(arr, expArr);
        }

        [TestMethod]
        public void TestStingVal()
        {
            string[] arr = { "b", "s", "a", "k", "d" };
            QuickSort<string> qsort = new QuickSort<string>();
            qsort.QuicksortGeneric(arr, 0, 4);
            string[] expArr = { "a", "b", "d", "k", "s" };
            CollectionAssert.AreEqual(arr, expArr);
        }

    }
}
