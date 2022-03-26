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

        [TestCaseSource(typeof(AddInTheIndexTestSource))]
        public void AddInTheIndexTest(int value, int index, LinkList list, LinkList expectedList)
        {
            list.AddInTheIndex(value, index);
            LinkList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }
        [TestCaseSource(typeof(IndexOutOfRange))]
        public void AddInTheIndexTest_WhenIndexOutOfRange_ShouldThrowExeption( int index, LinkList list)
        {
            Assert.Throws<IndexOutOfRangeException>(() => list.AddInTheIndex(5, index));
        }

        [TestCaseSource(typeof(DeleteInTheEndTestSource))]
        public void DeleteInTheEndTest(LinkList list, LinkList expectedList)
        {
            list.DeleteInTheEnd();
            LinkList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [Test]
        public void DeleteInTheEndTest_WhenListIsEmpty_ShouldThrowException()
        {
            LinkList list = new LinkList();
            Assert.Throws<Exception>(() => list.DeleteInTheEnd());
        }

        [TestCaseSource(typeof(DeleteInTheStartTestSource))]
        public void DeleteInTheStartTest(LinkList list, LinkList expectedList)
        {
            list.DeleteInTheStart();
            LinkList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [Test]
        public void DeleteInTheStartTest_WhenListIsEmpty_ShouldThrowException()
        {
            LinkList list = new LinkList();
            Assert.Throws<Exception>(() => list.DeleteInTheStart());
        }

        [TestCaseSource(typeof(DeleteInTheEndAFewElementsTestSource))]
        public void DeleteInTheEndAFewElementsTest(int ammount, LinkList list, LinkList expectedList)
        {
            list.DeleteInTheEndAFewElements(ammount);
            LinkList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [Test]
        public void DeleteInTheEndAFewElementsTest_WhenListIsEmpty_ShouldThrowException()
        {
            LinkList list = new LinkList();
            Assert.Throws<Exception>(() => list.DeleteInTheStartAFewElements(2));
        }
        
        [TestCaseSource(typeof(WhenAmmountMoreThanLengthOrLessThanZeroTestSource))]
        public void DeleteInTheEndAFewElementsTest_WhenAmmountMoreThanLengthOrLessThanZero_ShouldThrowException(int ammount, LinkList list)
        {
          
            Assert.Throws<Exception>(() => list.DeleteInTheEndAFewElements(ammount));
        }

        [TestCaseSource(typeof(DeleteInTheStartAFewElementsTestSource))]
        public void DeleteInTheStartAFewElementsTest(int ammount, LinkList list, LinkList expectedList)
        {
            list.DeleteInTheStartAFewElements(ammount);
            LinkList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [Test]
        public void DeleteInTheStartAFewElementsTest_WhenListIsEmpty_ShouldThrowException()
        {
            LinkList list = new LinkList();
            Assert.Throws<Exception>(() => list.DeleteInTheStartAFewElements(2));
        }

        [TestCaseSource(typeof(WhenAmmountMoreThanLengthOrLessThanZeroTestSource))]
        public void DeleteInTheStartAFewElementsTest_WhenAmmountMoreThanLengthOrLessThanZero_ShouldThrowException(int ammount, LinkList list)
        {

            Assert.Throws<Exception>(() => list.DeleteInTheStartAFewElements(ammount));
        }

    }
}