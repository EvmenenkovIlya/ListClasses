
using System.Collections;
using MyArrayList;

namespace MyArrayListTests.MyLinkedListTestSources
{
    internal class LengthTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {

            int expectedLength = 5;
            LinkList list = new LinkList(new int[] { 1, 2, 3, 4, 5 });
            yield return new object[] { expectedLength, list };

            expectedLength = 0;
            list = new LinkList(new int[] { });
            yield return new object[] { expectedLength, list };

            expectedLength = 1;
            list = new LinkList(new int[] { 44 });
            yield return new object[] { expectedLength, list };

            expectedLength = 2;
            list = new LinkList(new int[] { 66, 10 });
            yield return new object[] { expectedLength, list };
        }
    }
}