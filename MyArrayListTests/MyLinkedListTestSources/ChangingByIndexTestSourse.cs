using System.Collections;
using MyArrayList;

namespace MyArrayListTests.MyLinkedListTestSources
{
    internal class ChangingByIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int index = 4;
            LinkList list = new LinkList(new int[] { 5, 2, 3, 4, 1 });
            yield return new object[] { index, list };

            index = 0;
            list = new LinkList(new int[] { 1 });
            yield return new object[] { index, list };

            index = 5;
            list = new LinkList(new int[] { 5, 2, 3, 7, 4, 1 });
            yield return new object[] { index, list };

            index = 0;
            list = new LinkList(new int[] { -5, -2, -3, -1, -7, -4, -1 });
            yield return new object[] { index, list };

        }
    }
}