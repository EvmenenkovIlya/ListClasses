using System;
using NUnit.Framework;
using MyArrayLists;
using MyArrayList;
using MyArrayListTests;


namespace MyArrayListTests
{
    public class IListTests
    {
        [TestCaseSource(typeof(MyArrayListTestsSources.AddInTheEndTestSource))]
        [TestCaseSource(typeof(MyLinkedListTestSources.AddInTheEndTestSource))]
        public void AddInTheEndTest(int value, IMyList list, IMyList expectedList)
        {
            list.AddInTheEnd(value);
            IMyList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

    }
}
