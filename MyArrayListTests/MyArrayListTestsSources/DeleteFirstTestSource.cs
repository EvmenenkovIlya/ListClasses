using System.Collections;
using MyArrayList;


namespace MyArrayListTests.MyArrayListTestsSources
{
    internal class DeleteFirstTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            MyArrayList.AList list = new MyArrayList.AList(new int[] { 1, 2, 3, 4, 5 });
            MyArrayList.AList expectedList = new MyArrayList.AList(new int[] {2, 3, 4, 5});
            yield return new object[] { list, expectedList };

            list = new MyArrayList.AList(new int[] { 1 });
            expectedList = new MyArrayList.AList(new int[] { });
            yield return new object[] { list, expectedList };

            list = new MyArrayList.AList(new int[] { 55, 10 });
            expectedList = new MyArrayList.AList(new int[] { 10 });
            yield return new object[] { list, expectedList };
        }
    }
}
