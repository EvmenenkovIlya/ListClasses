using System.Collections;
using MyArrayList;

namespace MyArrayListTests.MyLinkedListTestSources
{
    internal class DeleteInTheIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int index = 2;
            LinkList list = new LinkList(new int[] { 1, 2, 3, 4, 5 });
            LinkList expectedList = new LinkList(new int[] { 1, 2, 4, 5 });
            yield return new object[] { index, list, expectedList };

            index = 0;
            list = new LinkList(new int[] { 1 });
            expectedList = new LinkList(new int[] { });
            yield return new object[] { index, list, expectedList };

            index = 4;
            list = new LinkList(new int[] { 1, 2, 3, 4, 5 });
            expectedList = new LinkList(new int[] { 1, 2, 3, 4 });
            yield return new object[] { index, list, expectedList };
        }
    }
}
