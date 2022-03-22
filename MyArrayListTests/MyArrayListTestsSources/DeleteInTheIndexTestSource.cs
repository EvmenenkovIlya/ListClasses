using System.Collections;
using MyArrayList;

namespace MyArrayListTests.MyArrayListTestsSources
{
    internal class DeleteInTheIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int index = 2;
            MyArrayList.ArrayList list = new MyArrayList.ArrayList(new int[] { 1, 2, 3, 4, 5 });
            MyArrayList.ArrayList expectedList = new MyArrayList.ArrayList(new int[] { 1, 2, 4, 5 });
            yield return new object[] { index, list, expectedList };

            index = 0;
            list = new MyArrayList.ArrayList(new int[] { 1 });
            expectedList = new MyArrayList.ArrayList(new int[] { });
            yield return new object[] { index, list, expectedList };

            index = 4;
            list = new MyArrayList.ArrayList(new int[] { 1, 2, 3, 4, 5 });
            expectedList = new MyArrayList.ArrayList(new int[] { 1, 2, 3, 4,});
            yield return new object[] {index, list, expectedList };
        }
    }
}
