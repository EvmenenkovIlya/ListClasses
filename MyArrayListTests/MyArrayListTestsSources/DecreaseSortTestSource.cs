using System.Collections;
using MyArrayList;

namespace MyArrayListTests.MyArrayListTestsSources
{
    internal class DecreaseSortTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            AList list = new AList(new int[] { 1, 2, 3, 4, 5 });
            AList expectedResult = new AList(new int[] { 5, 4, 3, 2, 1 });
            yield return new object[] { list, expectedResult };

            list = new AList(new int[] { -3, 0, -19, -4 });
            expectedResult = new AList(new int[] { 0, -3, -4, -19 });
            yield return new object[] { list, expectedResult };

            list = new AList(new int[] { 0 });
            expectedResult = new AList(new int[] { 0 });
            yield return new object[] { list, expectedResult };

            list = new AList(new int[] { 1, 1, 1, 1, 1 });
            expectedResult = new AList(new int[] { 1, 1, 1, 1, 1 });
            yield return new object[] { list, expectedResult };

            list = new AList(new int[] { 1, 2, 7, 3, 2, 1, 5, 7 });
            expectedResult = new AList(new int[] { 7, 7, 5, 3, 2, 2, 1, 1 });
            yield return new object[] { list, expectedResult };

            list = new AList(new int[] { });
            expectedResult = new AList(new int[] { });
            yield return new object[] { list, expectedResult };

        }
    }
}
