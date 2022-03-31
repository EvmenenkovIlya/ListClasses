using System.Collections;
using MyArrayList;

namespace MyArrayListTests.MyLinkedListTestSources;

internal class DeleteFirstValueAndReturnIndexTestSource : IEnumerable
{
    public IEnumerator GetEnumerator()
    {
        int value = 3;
        int expectedIndex = 2;
        LinkList list = new LinkList(new int[] { 1, 2, 3, 4, 5 });
        LinkList expectedList = new LinkList(new int[] { 1, 2, 4, 5 });
        yield return new object[] { list, expectedList, value, expectedIndex };

        value = 1;
        expectedIndex = 0;
        list = new LinkList(new int[] { 1 });
        expectedList = new LinkList(new int[] { });
        yield return new object[] { list, expectedList, value, expectedIndex };

        value = 11;
        expectedIndex = -1;
        list = new LinkList(new int[] { 55, 10 });
        expectedList = new LinkList(new int[] { 55, 10 });
        yield return new object[] { list, expectedList, value, expectedIndex };
    }
}