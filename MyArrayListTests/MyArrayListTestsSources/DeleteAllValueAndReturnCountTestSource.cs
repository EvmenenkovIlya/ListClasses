using System.Collections;
using MyArrayList;
namespace MyArrayListTests.MyArrayListTestsSources;

internal class DeleteAllValueAndReturnCountTestSource : IEnumerable
{
    public IEnumerator GetEnumerator()
    {
        int value = 3;
        int expectedCount = 3;
        AList list = new AList(new int[] { 3, 1, 2, 3, 4, 5, 3});
        AList expectedList = new AList(new int[] { 1, 2, 4, 5 });
        yield return new object[] { list, expectedList, value, expectedCount };

        value = 1;
        expectedCount = 1;
        list = new AList(new int[] { 1 });
        expectedList = new AList(new int[] { });
        yield return new object[] { list, expectedList, value, expectedCount };

        value = 11;
        expectedCount = 0;
        list = new AList(new int[] { 55, 10 });
        expectedList = new AList(new int[] { 55, 10 });
        yield return new object[] { list, expectedList, value, expectedCount };
    }
}