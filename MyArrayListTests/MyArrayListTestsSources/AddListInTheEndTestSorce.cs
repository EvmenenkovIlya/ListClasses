using System.Collections;
using MyArrayList;

namespace MyArrayListTests.MyArrayListTestsSources
{
    internal class AddListInTheEndTestSorce : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            AList listOne = new AList(new int[] { 5, 4, 3, 2, 1 });
            AList listTwo = new AList(new int[] { 1, 2, 3, 4, 5 });
            AList expectedResult = new AList(new int[] { 5, 4, 3, 2, 1, 1, 2, 3, 4, 5 });
            yield return new object[] { listOne, listTwo, expectedResult };

            listOne = new AList(new int[] { 5, 4, 3, 2, 1 });
            listTwo = new AList(new int[] { 1, 2, 3, 4, 5 });
            expectedResult = new AList(new int[] { 5, 4, 3, 2, 1, 1, 2, 3, 4, 5 });
            yield return new object[] { listOne, listTwo, expectedResult };

            listOne = new AList(new int[] { 5 });
            listTwo = new AList(new int[] { 1 });
            expectedResult = new AList(new int[] { 5, 1 });
            yield return new object[] { listOne, listTwo, expectedResult };

            listOne = new AList(new int[] { 5, 4 });
            listTwo = new AList(new int[] { 1, 2 });
            expectedResult = new AList(new int[] { 5, 4, 1, 2 });
            yield return new object[] { listOne, listTwo, expectedResult };
        }
    }
}