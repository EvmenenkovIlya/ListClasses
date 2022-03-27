using System.Collections;
using MyArrayList;

namespace MyArrayListTests.MyLinkedListTestSources
{
    internal class FindFirstIndexOfValueTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int expectedIndex = 0;
            int value = 1;
            LinkList list = new LinkList(new int[] { 1, 2, 3, 4, 5 });
            yield return new object[] { expectedIndex, value, list };

            expectedIndex = 4;
            value = 5;
            list = new LinkList(new int[] { 1, 2, 3, 4, 5 });
            yield return new object[] { expectedIndex, value, list };

            expectedIndex = -1;
            value = 7;
            list = new LinkList(new int[] { 1, 2, 3, 4, 5 });
            yield return new object[] { expectedIndex, value, list };

            expectedIndex = -1;
            value = 7;
            list = new LinkList(new int[] { 0 });
            yield return new object[] { expectedIndex, value, list };

            expectedIndex = 0;
            value = 7;
            list = new LinkList(new int[] { 7 });
            yield return new object[] { expectedIndex, value, list };

        }
    }
}