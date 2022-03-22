using System.Collections;
using MyArrayList;


namespace MyArrayListTests.MyArrayListTestsSources
{
    internal class DeleteInTheEndAFewElementsTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int ammount = 3;
            MyArrayList.ArrayList list = new MyArrayList.ArrayList(new int[] { 1, 2, 3, 4, 5 });
            MyArrayList.ArrayList expectedList = new MyArrayList.ArrayList(new int[] { 1, 2 });
            yield return new object[] { ammount, list, expectedList };

            ammount = 1;
            list = new MyArrayList.ArrayList(new int[] { 44 });
            expectedList = new MyArrayList.ArrayList(new int[] {});
            yield return new object[] { ammount, list, expectedList };

            ammount = 1;
            list = new MyArrayList.ArrayList(new int[] { 66, 10 });
            expectedList = new MyArrayList.ArrayList(new int[] {66});
            yield return new object[] { ammount, list, expectedList };
        }
    }
}
