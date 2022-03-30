using System.Collections;
using MyArrayList;
namespace MyArrayListTests.MyArrayListTestsSources;

internal class DeleteFirstValueAndReturnIndexTestSource : IEnumerable
{
    public IEnumerator GetEnumerator()
    {
        int value = 3;
        int expectedIndex = 2;
        AList list = new AList(new int[] { 1, 2, 3, 4, 5 });
        AList expectedList = new AList(new int[] { 1, 2, 4, 5});
        yield return new object[] { list, expectedList, value, expectedIndex};

        value = 1;
        expectedIndex = 0;
        list = new AList(new int[] { 1 });
        expectedList = new AList(new int[] { });
        yield return new object[] { list, expectedList, value, expectedIndex };

        value = 11;
        expectedIndex = -1;
        list = new AList(new int[] { 55, 10 });
        expectedList = new AList(new int[] { 55, 10 });
        yield return new object[] { list, expectedList, value, expectedIndex };
    }
}