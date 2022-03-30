using System.Collections;
using MyArrayList;

namespace MyArrayListTests.MyArrayListTestsSources
{
    internal class AddListInTheIndexTestSorce : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int index = 2;
            AList listOne = new AList(new int[] { 1, 1, 1, 1 });
            AList listTwo = new AList(new int[] { 2, 2, 2, 2 });
            AList expectedResult = new AList(new int[] { 1, 1, 2, 2, 2, 2, 1, 1 });
            yield return new object[] {index, listOne, listTwo, expectedResult };

            index = 0;
            listOne = new AList(new int[] { 1, 1, 1, 1 });
            listTwo = new AList(new int[] { 2, 2, 2, 2 });
            expectedResult = new AList(new int[] {  2, 2, 2, 2, 1, 1, 1, 1 });
            yield return new object[] { index, listOne, listTwo, expectedResult };

            index = 3;
            listOne = new AList(new int[] { 1, 1, 1, 1 });
            listTwo = new AList(new int[] { 2, 2, 2, 2 });
            expectedResult = new AList(new int[] {  1, 1, 1, 2, 2, 2, 2, 1 });
            yield return new object[] { index, listOne, listTwo, expectedResult };

            index = 0;
            listOne = new AList(new int[] { 5 });
            listTwo = new AList(new int[] { 1 });
            expectedResult = new AList(new int[] { 1, 5});
            yield return new object[] { index, listOne, listTwo, expectedResult };
        }
    }
}