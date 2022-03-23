using System;
using NUnit.Framework;
using MyArrayList;
using MyArrayListTests.MyArrayListTestsSources;

namespace MyArrayListTests
{
    public class Tests
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
        public void AddInTheIndexTest(int value, int index , AList list, AList expectedList)
        {
            list.AddInTheIndex(value, index);
            AList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(IndexOutOfRange))]
        public void AddInTheIndexTest_WhenIndexOutOfRange_ShouldThrowExeption(int value, int index, AList list)
        {
            {
                Assert.Throws<IndexOutOfRangeException>(() => list.AddInTheIndex(value, index));
            }
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
            {
                Assert.Throws<IndexOutOfRangeException>(() => list.DeleteInTheIndex(index));
            }
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
            {
                Assert.Throws<Exception>(() => list.DeleteInTheEndAFewElements(ammount));
            }
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
            {
                Assert.Throws<Exception>(() => list.DeleteInTheStartAFewElements(ammount));
            }
        }

        [TestCaseSource(typeof(DeleteInTheIndexAFewElementsTestSource))]
        public void DeleteInTheIndexAFewElementsTest(int index, int ammount, AList list, AList expectedList)
        {
            list.DeleteInTheIndexAFewElements(index, ammount);
            AList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(AmmountMoreThanLengthOrLessThenZeroWithIndex))]
        public void DeleteInTheIndexAFewElementsTest_WhenAmmountOutOfLength_ShouldThrowExeption( int ammount, int index, AList list)
        {
            {
                Assert.Throws<Exception>(() => list.DeleteInTheIndexAFewElements(index , ammount));
            }
        }
        [TestCaseSource(typeof(IndexOutOfRangeWithAmmount))]
        public void DeleteInTheEndAFewElementsTest_WhenWhenIndexOutOfRange_ShouldThrowExeption(int ammount, int index,  AList list)
        {
            {
                 Assert.Throws<IndexOutOfRangeException>(() => list.DeleteInTheIndexAFewElements(index, ammount));
            }
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
    }
}