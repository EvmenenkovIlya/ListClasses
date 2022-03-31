using System.Collections;
using MyArrayList;

namespace MyArrayListTests.MyLinkedListTestSources
{
    internal class AddListInTheEndTestSorce : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            LinkList listOne = new LinkList(new int[] { 5, 4, 3, 2, 1 });
            LinkList listTwo = new LinkList(new int[] { 1, 2, 3, 4, 5 });
            LinkList expectedResult = new LinkList(new int[] { 5, 4, 3, 2, 1, 1, 2, 3, 4, 5 });
            yield return new object[] { listOne, listTwo, expectedResult };

            listOne = new LinkList(new int[] { 5, 4, 3, 2, 1 });
            listTwo = new LinkList(new int[] { 1, 2, 3, 4, 5 });
            expectedResult = new LinkList(new int[] { 5, 4, 3, 2, 1, 1, 2, 3, 4, 5 });
            yield return new object[] { listOne, listTwo, expectedResult };

            listOne = new LinkList(new int[] { 5 });
            listTwo = new LinkList(new int[] { 1 });
            expectedResult = new LinkList(new int[] { 5, 1 });
            yield return new object[] { listOne, listTwo, expectedResult };

            listOne = new LinkList(new int[] { 5, 4 });
            listTwo = new LinkList(new int[] { 1, 2 });
            expectedResult = new LinkList(new int[] { 5, 4, 1, 2 });
            yield return new object[] { listOne, listTwo, expectedResult };
        }
    }
}