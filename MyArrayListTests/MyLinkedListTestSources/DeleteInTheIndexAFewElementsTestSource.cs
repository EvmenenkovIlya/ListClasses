using System.Collections;
using MyArrayList;


namespace MyArrayListTests.MyLinkedListTestSources

{
    internal class DeleteInTheIndexAFewElementsTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int index = 1;
            int ammount = 3;
            LinkList list = new LinkList(new int[] { 1, 2, 3, 4, 5 });
            LinkList expectedList = new LinkList(new int[] { 1, 5 });
            yield return new object[] { index, ammount, list, expectedList };

            index = 0;
            ammount = 2;
            list = new LinkList(new int[] { 44, 33, 22, 11 });
            expectedList = new LinkList(new int[] { 22, 11 });
            yield return new object[] { index, ammount, list, expectedList };

            index = 2;
            ammount = 2;
            list = new LinkList(new int[] { 44, 33, 22, 11 });
            expectedList = new LinkList(new int[] { 44, 33 });
            yield return new object[] { index, ammount, list, expectedList };

            index = 0;
            ammount = 1;
            list = new LinkList(new int[] { 44 });
            expectedList = new LinkList(new int[] { });
            yield return new object[] { index, ammount, list, expectedList };

        }
    }
}
