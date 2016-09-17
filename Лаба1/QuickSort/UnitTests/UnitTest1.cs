using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickSort;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPivotElem()
        {
            QuickSort<int> qSort = new QuickSort<int>();
            qSort.QuicksortGeneric(new int[6] { 5, 4, 3, 2, 1, 0 }, 0, 5);
            int Pivot = 6;
            Assert.AreEqual(Pivot, qSort.pivot);
        }
    }
}
