using System.Collections;
using MyArrayList;

namespace MyArrayListTests.MyLinkedListTestSources
{
    internal class FindIndexOfMaxTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int value = 0;
            LinkList list = new LinkList(new int[] { 5, 2, 3, 4, 1 });
            yield return new object[] { value, list };

            value = 0;
            list = new LinkList(new int[] { 1 });
            yield return new object[] { value, list };

            value = 3;
            list = new LinkList(new int[] { 5, 2, 3, 7, 4, 1 });
            yield return new object[] { value, list };

            value = 3;
            list = new LinkList(new int[] { -5, -2, -3, -1, -7, -4, -1 });
            yield return new object[] { value, list };

            value = 2;
            list = new LinkList(new int[] { 1, 2, 3 });
            yield return new object[] { value, list };
        }
    }
}
