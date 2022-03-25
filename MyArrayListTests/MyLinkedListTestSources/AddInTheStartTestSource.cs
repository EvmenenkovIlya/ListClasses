using System.Collections;
using MyArrayList;
namespace MyArrayListTests.MyLinkedListTestSources;

internal class AddInTheStartTestSource : IEnumerable
{
    public IEnumerator GetEnumerator()
    {
        int value = 3;
        LinkList list = new LinkList(new int[] { 1, 2, 3, 4, 5 });
        LinkList expectedList = new LinkList(new int[] { 3, 1, 2, 3, 4, 5});
        yield return new object[] { value, list, expectedList };

        value = 1;
        list = new LinkList(new int[] { });
        expectedList = new LinkList(new int[] { 1 });
        yield return new object[] { value, list, expectedList };

        value = 10;
        list = new LinkList(new int[] { 55 });
        expectedList = new LinkList(new int[] { 10, 55 });
        yield return new object[] { value, list, expectedList };
    }
}
