using System.Collections;
using MyArrayList;


namespace MyArrayListTests.MyLinkedListTestSources
{
    internal class DeleteInTheStartTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            LinkList list = new LinkList(new int[] { 1, 2, 3, 4, 5 });
            LinkList expectedList = new LinkList(new int[] { 2, 3, 4, 5 });
            yield return new object[] { list, expectedList };

            list = new LinkList(new int[] { 1 });
            expectedList = new LinkList(new int[] { });
            yield return new object[] { list, expectedList };

            list = new LinkList(new int[] { 55, 10 });
            expectedList = new LinkList(new int[] { 10 });
            yield return new object[] { list, expectedList };
        }
    }
}