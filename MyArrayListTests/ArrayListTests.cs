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
    }
}