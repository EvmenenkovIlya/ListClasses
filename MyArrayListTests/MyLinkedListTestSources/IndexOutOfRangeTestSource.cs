using System.Collections;
using MyArrayList;

namespace MyArrayListTests.MyLinkedListTestSources
{

    internal class IndexOutOfRange : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int index = 7;
            LinkList list = new LinkList(new int[] { 1, 2, 3, 4, 5 });
            yield return new object[] { index, list };

            index = 0;
            list = new LinkList(new int[] { });
            yield return new object[] { index, list };

            index = -3;
            list = new LinkList(new int[] { 1, 2, 3, 4, 5 });
            yield return new object[] { index, list };
        }
    }

}