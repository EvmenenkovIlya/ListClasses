using System;
using NUnit.Framework;
using MyArrayList;
using MyArrayListTests.MyArrayListTestsSources;

namespace MyArrayListTests
{
    public class TestForArrayList
    {

        [TestCaseSource(typeof(AddInTheEndTestSource))]
        public void AddInTheEndTest(int value, AList list, AList expectedList)
        {
            list.AddInTheEnd(value);
            AList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(AddInTheStartTestSource))]
        public void AddInTheStartTest(int value, AList list, AList expectedList)
        {
            list.AddInTheStart(value);
            AList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(AddInTheIndexTestSource))]
        public void AddInTheIndexTest(int value, int index, AList list, AList expectedList)
        {
            list.AddInTheIndex(value, index);
            AList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(IndexOutOfRange))]
        public void AddInTheIndexTest_WhenIndexOutOfRange_ShouldThrowExeption(int value, int index, AList list)
        {
            Assert.Throws<IndexOutOfRangeException>(() => list.AddInTheIndex(value, index));
        }

        [TestCaseSource(typeof(DeleteLastTestSource))]
        public void DeleteLastTest(AList list, AList expectedList)
        {
            list.DeleteLast();
            AList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [Test]
        public void DeleteLastTest_WhenListIsEmpty_ShouldThrowException()
        {
            AList list = new AList();
            Assert.Throws<Exception>(() => list.DeleteLast());
        }

        [TestCaseSource(typeof(DeleteFirstTestSource))]
        public void DeleteFirstTest(AList list, AList expectedList)
        {
            list.DeleteFirst();
            AList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [Test]
        public void DeleteFirstTest_WhenListIsEmpty_ShouldThrowException()
        {
            AList list = new AList();
            Assert.Throws<Exception>(() => list.DeleteFirst());
        }

        [TestCaseSource(typeof(DeleteInTheIndexTestSource))]
        public void DeleteInTheIndexTest(int index, AList list, AList expectedList)
        {
            list.DeleteInTheIndex(index);
            AList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(IndexOutOfRange))]
        public void DeleteInTheIndexTest_WhenIndexOutOfRange_ShouldThrowExeption(int value, int index, AList list)
        {
            Assert.Throws<IndexOutOfRangeException>(() => list.DeleteInTheIndex(index));
        }

        [TestCaseSource(typeof(DeleteInTheEndAFewElementsTestSource))]
        public void DeleteInTheEndAFewElementsTest(int ammount, AList list, AList expectedList)
        {
            list.DeleteInTheEndAFewElements(ammount);
            AList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(AmmountMoreThanLengthOrLessThenZero))]
        public void DeleteInTheEndAFewElementsTest_WhenAmmountOutOfLength_ShouldThrowExeption(int ammount, AList list)
        {
            Assert.Throws<Exception>(() => list.DeleteInTheEndAFewElements(ammount));
        }

        [TestCaseSource(typeof(DeleteInTheStartAFewElementsTestSource))]
        public void DeleteInTheStartAFewElementsTest(int ammount, AList list, AList expectedList)
        {
            list.DeleteInTheStartAFewElements(ammount);
            AList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(AmmountMoreThanLengthOrLessThenZero))]
        public void DeleteInTheStartAFewElementsTest_WhenAmmountOutOfLength_ShouldThrowExeption(int ammount, AList list)
        {
            Assert.Throws<Exception>(() => list.DeleteInTheStartAFewElements(ammount));
        }

        [TestCaseSource(typeof(DeleteInTheIndexAFewElementsTestSource))]
        public void DeleteInTheIndexAFewElementsTest(int index, int ammount, AList list, AList expectedList)
        {
            list.DeleteInTheIndexAFewElements(index, ammount);
            AList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(AmmountMoreThanLengthOrLessThenZeroWithIndex))]
        public void DeleteInTheIndexAFewElementsTest_WhenAmmountOutOfLength_ShouldThrowExeption(int ammount, int index, AList list)
        {
            Assert.Throws<Exception>(() => list.DeleteInTheIndexAFewElements(index, ammount));
        }
        [TestCaseSource(typeof(IndexOutOfRangeWithAmmount))]
        public void DeleteInTheEndAFewElementsTest_WhenWhenIndexOutOfRange_ShouldThrowExeption(int ammount, int index, AList list)
        {
            Assert.Throws<IndexOutOfRangeException>(() => list.DeleteInTheIndexAFewElements(index, ammount));
        }

        [TestCaseSource(typeof(ReturnLengthTestSource))]
        public void ReturnLengthTest(int expectedLength, AList list)
        {
            int actualLength = list.ReturnLength();
            Assert.AreEqual(expectedLength, actualLength);
        }

        [TestCaseSource(typeof(GetByIndexPositiveTestSource))]
        public void GetByIndexTest(int index, int value, AList list)
        {
            int actualValue = list[index];
            Assert.AreEqual(value, actualValue);
        }

        [TestCaseSource(typeof(GetByIndexNegativeTestSource))]
        public void GetByIndexTest_WhenIndexOutOfRangeOfList_ShouldThrowIndexOutOfRangeException(int index, AList list)
        {
            int a;
            Assert.Throws<IndexOutOfRangeException>(() => a = list[index]);
        }

        [TestCaseSource(typeof(FindFirstIndexOfValueTestSource))]
        public void FindFirstIndexOfValueTest(int expectedIndex, int value, AList list)
        {
            int actualIndex = list.FindFirstIndexOfValue(value);
            Assert.AreEqual(expectedIndex, actualIndex);
        }

        [Test]
        public void FindFirstIndexOfValue_WhenListIsEmpty_ShouldThrowException()
        {
            AList list = new AList();
            Assert.Throws<Exception>(() => list.FindFirstIndexOfValue(0));
        }

        [TestCaseSource(typeof(ChangingByIndexTestSource))]
        public void ChangingByIndexTest(int index, AList list)
        {
            list[index] = 5;
            int actualValue = list[index];
            Assert.AreEqual(5, actualValue);
        }

        [TestCaseSource(typeof(IndexOutOfRange))]
        public void ChangingByIndexTest_WhenIndexOutOfRange_ShouldThrowIndexOutOfRangeException(int some, int index, AList list)
        {
            Assert.Throws<IndexOutOfRangeException>(() => list[index] = 0);
        }

        [TestCaseSource(typeof(ReverseTestSource))]
        public void ReverseTest(AList expectedResult, AList list)
        {
            AList actualResult = new AList();
            actualResult = actualResult.CopyAList(list);
            actualResult.Reverse();
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCaseSource(typeof(FindMaxTestSource))]
        public void FindMaxTest(int expectedMax, AList list)
        {
            int actualMax = list.FindMax();
            Assert.AreEqual(expectedMax, actualMax);
        }

        [Test]
        public void FindMax_WhenListIsEmpty_ShouldThrowException()
        {
            AList list = new AList();
            Assert.Throws<Exception>(() => list.FindMax());
        }

        [TestCaseSource(typeof(FindMinTestSource))]
        public void FindMinTest(int expectedMin, AList list)
        {
            int actualMin = list.FindMin();
            Assert.AreEqual(expectedMin, actualMin);
        }

        [Test]
        public void FindMin_WhenListIsEmpty_ShouldThrowException()
        {
            AList list = new AList();
            Assert.Throws<Exception>(() => list.FindMin());
        }

        [TestCaseSource(typeof(FindIndexOfMaxTestSource))]
        public void FindIndexOfMaxTest(int expectedIndex, AList list)
        {
            int actualIndex = list.FindIndexOfMax();
            Assert.AreEqual(expectedIndex, actualIndex);
        }

        [Test]
        public void FindIndexOfMax_WhenListIsEmpty_ShouldThrowException()
        {
            AList list = new AList();
            Assert.Throws<Exception>(() => list.FindIndexOfMax());
        }

        [TestCaseSource(typeof(FindIndexOfMinTestSource))]
        public void FindIndexOfMinTest(int expectedIndex, AList list)
        {
            int actualIndex = list.FindIndexOfMin();
            Assert.AreEqual(expectedIndex, actualIndex);
        }

        [Test]
        public void FindIndexOfMin_WhenListIsEmpty_ShouldThrowException()
        {
            AList list = new AList();
            Assert.Throws<Exception>(() => list.FindIndexOfMin());
        }

        [TestCaseSource(typeof(IncreaseSortTestSource))]
        public void BubbleSortTest(AList list, AList expectedList)
        {
            list.BubbleSort();
            AList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DecreaseSortTestSource))]
        public void BubbleSortDecriseTest(AList list, AList expectedList)
        {
            list.BubbleSort(true);
            AList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }
        [TestCaseSource(typeof(DeleteFirstValueAndReturnIndexTestSource))]
        public void DeleteFirstValueAndReturnIndexTest(AList list, AList expectedList, int value, int expectedIndex)
        {
            int actualIndex = list.DeleteFirstValueAndReturnIndex(value);
            AList actualList = list;
            Assert.AreEqual(expectedList, actualList);
            Assert.AreEqual(expectedIndex, actualIndex);
        }
        [TestCaseSource(typeof(DeleteAllValueAndReturnCountTestSource))]
        public void DeleteAllValueAndReturnCountTest(AList list, AList expectedList, int value, int expectedIndex)
        {
            int actualCount = list.DeleteAllValueAndReturnCount(value);
            AList actualList = list;
            Assert.AreEqual(expectedList, actualList);
            Assert.AreEqual(expectedIndex, actualCount);
        }
        [TestCaseSource(typeof(AddListInTheEndTestSorce))]
        public void AddListInTheEndTest(AList listOne, AList listTwo, AList expectedResult)
        {
            listOne.AddListInTheEnd(listTwo);
            AList actualList = listOne;
            Assert.AreEqual(expectedResult, actualList);
        }

        [TestCaseSource(typeof(AddListInTheStartTestSorce))]
        public void AddListInTheStartTest(AList listOne, AList listTwo, AList expectedResult)
        {
            listOne.AddListInTheStart(listTwo);
            AList actualList = listOne;
            Assert.AreEqual(expectedResult, actualList);
        }

        [TestCaseSource(typeof(AddListInTheIndexTestSorce))]
        public void AddListInTheIndexTest(int index, AList listOne, AList listTwo, AList expectedResult)
        {
            listOne.AddListInTheIndex(listTwo, index);
            AList actualList = listOne;
            Assert.AreEqual(expectedResult, actualList);
        }
        [TestCaseSource(typeof(IndexOutOfRange))]
        public void AddListInTheIndexTest_WhenIndexOutOfRange_ShouldThrowExeption(int some, int index, AList list)
        {
            Assert.Throws<IndexOutOfRangeException>(() => list.AddListInTheIndex(list, index));
        }



    }
}