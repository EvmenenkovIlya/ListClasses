using System.Collections;
using MyArrayList;

namespace MyArrayListTests.MyLinkedListTestSources;

internal class AddInTheIndexTestSource : IEnumerable
{
    public IEnumerator GetEnumerator()
    {
        int value = 3;
        int index = 3;
        LinkList list = new LinkList(new int[] { 1, 2, 3, 4, 5 });
        LinkList expectedList = new LinkList(new int[] { 1, 2, 3, 3, 4, 5});
        yield return new object[] { value, index, list, expectedList };

        value = 2;
        index = 0;
        list = new LinkList(new int[] { 1, 1 });
        expectedList = new LinkList(new int[] { 2, 1, 1 });
        yield return new object[] { value, index, list, expectedList };

        value = 10;
        index = 1;
        list = new LinkList(new int[] { 55, 12 });
        expectedList = new LinkList(new int[] { 55, 10, 12 });
        yield return new object[] { value, index, list, expectedList };
    }
}