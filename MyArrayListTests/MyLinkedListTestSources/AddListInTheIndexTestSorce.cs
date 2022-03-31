using System.Collections;
using MyArrayList;

namespace MyArrayListTests.MyLinkedListTestSources
{ 
    internal class AddListInTheIndexTestSorce : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int index = 2;
            LinkList listOne = new LinkList(new int[] { 1, 1, 1, 1 });
            LinkList listTwo = new LinkList(new int[] { 2, 2, 2, 2 });
            LinkList expectedResult = new LinkList(new int[] { 1, 1, 2, 2, 2, 2, 1, 1 });
            yield return new object[] {index, listOne, listTwo, expectedResult };

            index = 0;
            listOne = new LinkList(new int[] { 1, 1, 1, 1 });
            listTwo = new LinkList(new int[] { 2, 2, 2, 2 });
            expectedResult = new LinkList(new int[] {  2, 2, 2, 2, 1, 1, 1, 1 });
            yield return new object[] { index, listOne, listTwo, expectedResult };

            index = 3;
            listOne = new LinkList(new int[] { 1, 1, 1, 1 });
            listTwo = new LinkList(new int[] { 2, 2, 2, 2 });
            expectedResult = new LinkList(new int[] {  1, 1, 1, 2, 2, 2, 2, 1 });
            yield return new object[] { index, listOne, listTwo, expectedResult };

            index = 0;
            listOne = new LinkList(new int[] { 5 });
            listTwo = new LinkList(new int[] { 1 });
            expectedResult = new LinkList(new int[] { 1, 5});
            yield return new object[] { index, listOne, listTwo, expectedResult };
        }
    }
}