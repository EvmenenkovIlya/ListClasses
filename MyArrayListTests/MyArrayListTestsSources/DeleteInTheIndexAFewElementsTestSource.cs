using System.Collections;
using MyArrayList;


namespace MyArrayListTests.MyArrayListTestsSources
{
    internal class DeleteInTheIndexAFewElementsTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {   
            int index = 1;
            int ammount = 3;
            MyArrayList.ArrayList list = new MyArrayList.ArrayList(new int[] { 1, 5 });
            MyArrayList.ArrayList expectedList = new MyArrayList.ArrayList(new int[] { 1, 5 });
            yield return new object[] {index, ammount, list, expectedList };

            index = 0;
            ammount = 2;
            list = new MyArrayList.ArrayList(new int[] { 44, 33, 22, 11 });
            expectedList = new MyArrayList.ArrayList(new int[] { 22, 11 });
            yield return new object[] { index, ammount, list, expectedList };

            index = 2;
            ammount = 2;
            list = new MyArrayList.ArrayList(new int[] { 44, 33, 22, 11 });
            expectedList = new MyArrayList.ArrayList(new int[] { 44, 33});
            yield return new object[] { index, ammount, list, expectedList };

            index = 0;
            ammount = 1;
            list = new MyArrayList.ArrayList(new int[] { 44 });
            expectedList = new MyArrayList.ArrayList(new int[] { });
            yield return new object[] {index, ammount, list, expectedList };

        }
    }
}
