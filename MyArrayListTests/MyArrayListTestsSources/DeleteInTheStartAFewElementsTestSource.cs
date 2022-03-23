using System.Collections;
using MyArrayList;


namespace MyArrayListTests.MyArrayListTestsSources
{
    internal class DeleteInTheStartAFewElementsTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int ammount = 3;
            MyArrayList.AList list = new MyArrayList.AList(new int[] { 1, 2, 3, 4, 5 });
            MyArrayList.AList expectedList = new MyArrayList.AList(new int[] { 4, 5 });
            yield return new object[] { ammount, list, expectedList };

            ammount = 1;
            list = new MyArrayList.AList(new int[] { 44 });
            expectedList = new MyArrayList.AList(new int[] {});
            yield return new object[] { ammount, list, expectedList };

            ammount = 1;
            list = new MyArrayList.AList(new int[] { 66, 10 });
            expectedList = new MyArrayList.AList(new int[] {10});
            yield return new object[] { ammount, list, expectedList };
        }
    }
}
