using System.Collections;
using MyArrayList;

namespace MyArrayListTests.MyArrayListTestsSources
{
    internal class AddInTheIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int value = 3;
            int index = 3;
            MyArrayList.AList list = new MyArrayList.AList(new int[] { 1, 2, 3, 4, 5 });
            MyArrayList.AList expectedList = new MyArrayList.AList(new int[] { 1, 2, 3, 3, 4, 5 });
            yield return new object[] { value, index, list, expectedList };

            value = 2;
            index = 0;
            list = new MyArrayList.AList(new int[] { 1 });
            expectedList = new MyArrayList.AList(new int[] { 2, 1 });
            yield return new object[] { value, index, list, expectedList };

            value = 10;
            index = 4;
            list = new MyArrayList.AList(new int[] { 1, 2, 3, 4, 5 });
            expectedList = new MyArrayList.AList(new int[] { 1, 2, 3, 4, 10, 5 });
            yield return new object[] { value,  index, list, expectedList };
        }
    }    
}
