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
        [TestCaseSource(typeof(DeleteInTheIndexTestSource))]
        public void DeleteInTheIndexTest(int index, LinkList list, LinkList expectedList)
        {
            list.DeleteInTheIndex(index);
            LinkList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }
        [TestCaseSource(typeof(DeleteInTheEndAFewElementsTestSource))]
        public void DeleteInTheEndAFewElementsTest(int ammount, LinkList list, LinkList expectedList)
        {
            list.DeleteInTheEnd(ammount);
            LinkList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }
        [Test]
        public void DeleteInTheEndAFewElementsTest_WhenListIsEmpty_ShouldThrowException()
        {
            LinkList list = new LinkList();
            Assert.Throws<Exception>(() => list.DeleteInTheStart(2));
        }       
        [TestCaseSource(typeof(WhenAmmountMoreThanLengthOrLessThanZeroTestSource))]
        public void DeleteInTheEndAFewElementsTest_WhenAmmountMoreThanLengthOrLessThanZero_ShouldThrowException(int ammount, LinkList list)
        {
          
            Assert.Throws<Exception>(() => list.DeleteInTheEnd(ammount));
        }
        [TestCaseSource(typeof(DeleteInTheStartAFewElementsTestSource))]
        public void DeleteInTheStartAFewElementsTest(int ammount, LinkList list, LinkList expectedList)
        {
            list.DeleteInTheStart(ammount);
            LinkList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }
        [Test]
        public void DeleteInTheStartAFewElementsTest_WhenListIsEmpty_ShouldThrowException()
        {
            LinkList list = new LinkList();
            Assert.Throws<Exception>(() => list.DeleteInTheStart(2));
        }
        [TestCaseSource(typeof(WhenAmmountMoreThanLengthOrLessThanZeroTestSource))]
        public void DeleteInTheStartAFewElementsTest_WhenAmmountMoreThanLengthOrLessThanZero_ShouldThrowException(int ammount, LinkList list)
        {

            Assert.Throws<Exception>(() => list.DeleteInTheStart(ammount));
        }       
        [TestCaseSource(typeof(DeleteInTheIndexAFewElementsTestSource))]
        public void DeleteInTheIndexAFewElementsTest(int index, int ammount, LinkList list, LinkList expectedList)
        {
            list.DeleteInTheIndex(index, ammount);
            LinkList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }
        [TestCaseSource(typeof(WhenAmmountMoreThanLengthOrLessThanZeroTestSource))]
        public void DeleteInTheIndexAFewElementsTest_WhenAmmountOutOfLength_ShouldThrowExeption(int ammount,  LinkList list)
        {
            Assert.Throws<Exception>(() => list.DeleteInTheIndex(0, ammount));
        }
        [TestCaseSource(typeof(IndexOutOfRange))]
        public void DeleteInTheIndexAFewElementsTest_WhenIndexOutOfRange_ShouldThrowIndexOutOfRangeException( int index, LinkList list)
        {
            Assert.Throws<IndexOutOfRangeException>(() => list.DeleteInTheIndex(index, 0));
        }
        [TestCaseSource(typeof(LengthTestSource))]
        public void LengthTest(int expectedLength, LinkList list)
        {
            int actualLength = list.Length;                       
            Assert.AreEqual(expectedLength, actualLength);

        }
        [TestCaseSource(typeof(GetByIndexPositiveTestSource))]
        public void GetByIndexTest(int index, int value, LinkList list )
        {
            int actualValue = list[index];
            Assert.AreEqual(value, actualValue);
        }
        [TestCaseSource(typeof(GetByIndexNegativeTestSource))]
        public void GetByIndexTest_WhenIndexOutOfRangeOfList_ShouldThrowIndexOutOfRangeException(int index, LinkList list)
        {
            int a;
            Assert.Throws<IndexOutOfRangeException>(() => a = list[index]);
        }
        [TestCaseSource(typeof(ChangingByIndexTestSource))]
        public void ChangingByIndexTest(int index, LinkList list)
        {
            list[index] = 5;
            int actualValue = list[index];
            Assert.AreEqual(5, actualValue);
        }      
        [TestCaseSource(typeof(FindFirstIndexOfValueTestSource))]
        public void FindFirstIndexOfValueTest(int expectedIndex, int value, LinkList list)
        {
            int actualIndex = list.FindFirstIndexOfValue(value);
            Assert.AreEqual(expectedIndex, actualIndex);
        }
        [Test]
        public void FindFirstIndexOfValue_WhenListIsEmpty_ShouldThrowException()
        {
            LinkList list = new LinkList();
            Assert.Throws<Exception>(() => list.FindFirstIndexOfValue(0));
        }
        [TestCaseSource(typeof(ReverseTestSource))]
        public void ReverseTest(LinkList expectedResult, LinkList list)
        {
            list.Reverse();
            LinkList actualResult = list;
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void ReverseTest_WhenListIsEmpty_ShouldThrowException()
        {
            LinkList list = new LinkList();
            Assert.Throws<Exception>(() => list.Reverse());
        }
        [TestCaseSource(typeof(FindMaxTestSource))]
        public void FindMaxTest(int expectedMax, LinkList list)
        {
            int actualMax = list.FindMax();
            Assert.AreEqual(expectedMax, actualMax);
        }
        [Test]
        public void FindMax_WhenListIsEmpty_ShouldThrowException()
        {
            LinkList list = new LinkList();
            Assert.Throws<Exception>(() => list.FindMax());
        }
        [TestCaseSource(typeof(FindMinTestSource))]
        public void FindMinTest(int expectedMax, LinkList list)
        {
            int actualMax = list.FindMin();
            Assert.AreEqual(expectedMax, actualMax);
        }
        [Test]
        public void FindMin_WhenListIsEmpty_ShouldThrowException()
        {
            LinkList list = new LinkList();
            Assert.Throws<Exception>(() => list.FindMin());
        }
        [TestCaseSource(typeof(FindIndexOfMaxTestSource))]
        public void FindIndexOfMaxTest(int expectedIndex, LinkList list)
        {
            int actualIndex = list.FindIndexOfMax();
            Assert.AreEqual(expectedIndex, actualIndex);
        }
        [Test]
        public void FindIndexOfMax_WhenListIsEmpty_ShouldThrowException()
        {
            LinkList list = new LinkList();
            Assert.Throws<Exception>(() => list.FindIndexOfMax());
        }
        [TestCaseSource(typeof(FindIndexOfMinTestSource))]
        public void FindIndexOfMinTest(int expectedIndex, LinkList list)
        {
            int actualIndex = list.FindIndexOfMin();
            Assert.AreEqual(expectedIndex, actualIndex);
        }
        [Test]
        public void FindIndexOfMin_WhenListIsEmpty_ShouldThrowException()
        {
            LinkList list = new LinkList();
            Assert.Throws<Exception>(() => list.FindIndexOfMin());
        }
        [TestCaseSource(typeof(AddListInTheEndTestSorce))]
        public void AddListInTheEndTest(LinkList listOne, LinkList listTwo, LinkList expectedResult)
        {
            listOne.AddListInTheEnd(listTwo);
            LinkList actualList = listOne;
            Assert.AreEqual(expectedResult, actualList);
        }
        [TestCaseSource(typeof(AddListInTheStartTestSorce))]
        public void AddListInTheStartTest(LinkList listOne, LinkList listTwo, LinkList expectedResult)
        {
            listOne.AddListInTheStart(listTwo);
            LinkList actualList = listOne;
            Assert.AreEqual(expectedResult, actualList);
        }
        [TestCaseSource(typeof(AddListInTheIndexTestSorce))]
        public void AddListInTheIndexTest(int index, LinkList listOne, LinkList listTwo, LinkList expectedResult)
        {
            listOne.AddListInTheIndex(listTwo, index);
            LinkList actualList = listOne;
            Assert.AreEqual(expectedResult, actualList);
        }
        [TestCaseSource(typeof(IndexOutOfRange))]
        public void AddListInTheIndexTest_WhenIndexOutOfRange_ShouldThrowExeption( int index, LinkList list)
        {
            Assert.Throws<IndexOutOfRangeException>(() => list.AddListInTheIndex(list, index));
        }

        [TestCaseSource(typeof(DeleteFirstValueAndReturnIndexTestSource))]
        public void DeleteFirstValueAndReturnIndexTest(LinkList list, LinkList expectedList, int value, int expectedIndex)
        {
            int actualIndex = list.DeleteFirstValueAndReturnIndex(value);
            LinkList actualList = list;
            Assert.AreEqual(expectedList, actualList);
            Assert.AreEqual(expectedIndex, actualIndex);
        }
        [TestCaseSource(typeof(DeleteAllValueAndReturnCountTestSource))]
        public void DeleteAllValueAndReturnCountTest(LinkList list, LinkList expectedList, int value, int expectedIndex)
        {
            int actualCount = list.DeleteAllValueAndReturnCount(value);
            LinkList actualList = list;
            Assert.AreEqual(expectedList, actualList);
            Assert.AreEqual(expectedIndex, actualCount);
        }
    }
}