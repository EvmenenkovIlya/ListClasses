using System;
using NUnit.Framework;
using MyArrayList;
using MyArrayListTests.MyArrayListTestsSources;

namespace MyArrayListTests
{
    public class Tests
    {

        [TestCaseSource(typeof(AddInTheEndTestSource))]
        public void AddInTheEndTest(int value, ArrayList list, ArrayList expectedList)
        {
            list.AddInTheEnd(value);
            ArrayList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(AddInTheStartTestSource))]
        public void AddInTheStartTest(int value, ArrayList list, ArrayList expectedList)
        {
            list.AddInTheStart(value);
            ArrayList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(AddInTheIndexTestSource))]
        public void AddInTheIndexTest(int value, int index , ArrayList list, ArrayList expectedList)
        {
            list.AddInTheIndex(value, index);
            ArrayList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(IndexOutOfRange))]
        public void AddInTheIndexTest_WhenIndexOutOfRange_ShouldThrowExeption(int value, int index, ArrayList list)
        {
            {
                Assert.Throws<IndexOutOfRangeException>(() => list.AddInTheIndex(value, index));
            }
        }

        [TestCaseSource(typeof(DeleteLastTestSource))]
        public void DeleteLastTest(ArrayList list, ArrayList expectedList)
        {
            list.DeleteLast();
            ArrayList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteFirstTestSource))]
        public void DeleteFirstTest(ArrayList list, ArrayList expectedList)
        {
            list.DeleteFirst();
            ArrayList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteInTheIndexTestSource))]
        public void DeleteInTheIndexTest(int index, ArrayList list, ArrayList expectedList)
        {
            list.DeleteInTheIndex(index);
            ArrayList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(IndexOutOfRange))]
        public void DeleteInTheIndexTest_WhenIndexOutOfRange_ShouldThrowExeption(int value, int index, ArrayList list)
        {
            {
                Assert.Throws<IndexOutOfRangeException>(() => list.DeleteInTheIndex(index));
            }
        }

        [TestCaseSource(typeof(DeleteInTheEndAFewElementsTestSource))]
        public void DeleteInTheEndAFewElementsTest(int ammount, ArrayList list, ArrayList expectedList)
        {
            list.DeleteInTheEndAFewElements(ammount);
            ArrayList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(AmmountMoreThanLengthOrLessThenZero))]
        public void DeleteInTheEndAFewElementsTest_WhenWhenAmmountOutOfLength_ShouldThrowExeption(int ammount, ArrayList list)
        {
            {
                Assert.Throws<Exception>(() => list.DeleteInTheEndAFewElements(ammount));
            }
        }

        [TestCaseSource(typeof(DeleteInTheStartAFewElementsTestSource))]
        public void DeleteInTheStartAFewElementsTest(int ammount, ArrayList list, ArrayList expectedList)
        {
            list.DeleteInTheStartAFewElements(ammount);
            ArrayList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(AmmountMoreThanLengthOrLessThenZero))]
        public void DeleteInTheStartAFewElementsTest_WhenWhenAmmountOutOfLength_ShouldThrowExeption(int ammount, ArrayList list)
        {
            {
                Assert.Throws<Exception>(() => list.DeleteInTheStartAFewElements(ammount));
            }
        }

        [TestCaseSource(typeof(DeleteInTheIndexAFewElementsTestSource))]
        public void DeleteInTheIndexAFewElementsTest(int index, int ammount, ArrayList list, ArrayList expectedList)
        {
            list.DeleteInTheIndexAFewElements(index, ammount);
            ArrayList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }
        /*[TestCaseSource(typeof(AmmountMoreThanLengthOrLessThenZero))]
        public void DeleteInTheEndAFewElementsTest_WhenWhenAmmountOutOfLength_ShouldThrowExeption( int ammount, int index, ArrayList list)
        {
            {
                Assert.Throws<Exception>(() => list.DeleteInTheIndexAFewElements( index , ammount));
            }
        }*/
        /* [TestCaseSource(typeof(IndexOutOfRange))]
         public void DeleteInTheEndAFewElementsTest_WhenWhenIndexOutOfRange_ShouldThrowExeption(  int index, int ammount, ArrayList list)
         {
             {
                 Assert.Throws<IndexOutOfRangeException>(() => list.DeleteInTheIndexAFewElements(index, ammount));
             }
         }*/

    }
}