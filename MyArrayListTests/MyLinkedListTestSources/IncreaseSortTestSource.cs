using System.Collections;
using MyArrayList;

namespace MyArrayListTests.MyLinkedListTestSources
{
    internal class IncreaseSortTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            LinkList list = new LinkList(new int[] { 1, 2, 3, 4, 5 });
            LinkList expectedResult = new LinkList(new int[] { 1, 2, 3, 4, 5 });
            yield return new object[] {list,  expectedResult };

            list = new LinkList(new int[] { -3, 0, -19, -4 });
            expectedResult = new LinkList(new int[] { -19, -4, -3, 0 });
            yield return new object[] { list, expectedResult };

            list = new LinkList(new int[] { 0 });
            expectedResult = new LinkList(new int[] { 0 });
            yield return new object[] { list, expectedResult };

            list = new LinkList(new int[] { 1, 1, 1, 1, 1 });
            expectedResult = new LinkList(new int[] { 1, 1, 1, 1, 1 });
            yield return new object[] { list, expectedResult };

            list = new LinkList(new int[] { 1, 2, 7, 3, 2, 1, 5, 7 });
            expectedResult = new LinkList(new int[] { 1, 1, 2, 2, 3, 5, 7, 7 });
            yield return new object[] { list, expectedResult };

            list = new LinkList(new int[] { });
            expectedResult = new LinkList(new int[] { });
            yield return new object[] { list, expectedResult };

        }
    }
}
