using System.Collections;
using MyArrayList;
namespace MyArrayListTests.MyLinkedListTestSources;

internal class DeleteAllValueAndReturnCountTestSource : IEnumerable
{
    public IEnumerator GetEnumerator()
    {
        int value = 3;
        int expectedCount = 3;
        LinkList list = new LinkList(new int[] { 3, 1, 2, 3, 4, 5, 3 });
        LinkList expectedList = new LinkList(new int[] { 1, 2, 4, 5 });
        yield return new object[] { list, expectedList, value, expectedCount };

        value = 1;
        expectedCount = 1;
        list = new LinkList(new int[] { 1 });
        expectedList = new LinkList(new int[] { });
        yield return new object[] { list, expectedList, value, expectedCount };

        value = 11;
        expectedCount = 0;
        list = new LinkList(new int[] { 55, 10 });
        expectedList = new LinkList(new int[] { 55, 10 });
        yield return new object[] { list, expectedList, value, expectedCount };
    }
}