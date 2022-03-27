using System;
using System.Collections;
using MyArrayList;

namespace MyArrayListTests.MyLinkedListTestSources
{
    internal class GetByIndexPositiveTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int index = 0;
            int value = 1;
            LinkList list = new LinkList(new int[] { 1, 2, 3, 4, 5 });
            yield return new object[] { index, value, list };

            index = 4;
            value = 5;
            list = new LinkList(new int[] { 1, 2, 3, 4, 5 });
            yield return new object[] { index, value, list };

            index = 0;
            value = 1;
            list = new LinkList(new int[] { 1 });
            yield return new object[] { index, value, list };
        }
    }
}
