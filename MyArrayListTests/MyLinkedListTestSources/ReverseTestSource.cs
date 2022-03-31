using System.Collections;
using MyArrayList;

namespace MyArrayListTests.MyLinkedListTestSources
{
    internal class ReverseTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            LinkList expectedResult = new LinkList(new int[] { 1, 2, 3, 4, 5 });
            LinkList list = new LinkList(new int[] { 5, 4, 3, 2, 1 });
            yield return new object[] { expectedResult, list };

            expectedResult = new LinkList(new int[] { 1 });
            list = new LinkList(new int[] { 1 });
            yield return new object[] { expectedResult, list };

            expectedResult = new LinkList(new int[] { 2, 1, 2, 1 });
            list = new LinkList(new int[] { 1, 2, 1, 2 });
            yield return new object[] { expectedResult, list };
        }
    }
}