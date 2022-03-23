using System.Collections;
using MyArrayList;

namespace MyArrayListTests.MyArrayListTestsSources
{
    internal class AddInTheStartTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int value = 3;
            MyArrayList.AList list = new MyArrayList.AList(new int[] { 1, 2, 3, 4, 5 });
            MyArrayList.AList expectedList = new MyArrayList.AList(new int[] { 3, 1, 2, 3, 4, 5 });
            yield return new object[] { value, list, expectedList };

            value = 1;
            list = new MyArrayList.AList(new int[] { });
            expectedList = new MyArrayList.AList(new int[] { 1 });
            yield return new object[] { value, list, expectedList };

            value = 10;
            list = new MyArrayList.AList(new int[] { 55 });
            expectedList = new MyArrayList.AList(new int[] { 10, 55 });
            yield return new object[] { value, list, expectedList };
        }
    }
}