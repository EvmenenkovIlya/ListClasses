using System;
using NUnit.Framework;
using MyArrayList;
using MyArrayListTests.MyLinkedListTestSources;

namespace MyArrayListTests
{
    public class TestsForLinkList
    {
        [TestCaseSource(typeof(AddInTheEndTestSource))]
        public void AddInTheEndTest(int value, LinkList list, LinkList expectedList)
        {
            list.AddInTheEnd(value);
            LinkList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }
        [TestCaseSource(typeof(AddInTheStartTestSource))]
        public void AddInTheStartTest(int value, LinkList list, LinkList expectedList)
        {
            list.AddInTheStart(value);
            LinkList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

    }
}