using System.Collections;
using MyArrayList;

namespace MyArrayListTests.MyLinkedListTestSources
{

    internal class DeleteInTheStartAFewElementsTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int ammount = 3;
            LinkList list = new LinkList(new int[] { 1, 2, 3, 4, 5 });
            LinkList expectedList = new LinkList(new int[] { 4, 5});
            yield return new object[] { ammount, list, expectedList };

            ammount = 1;
            list = new LinkList(new int[] { 44 });
            expectedList = new LinkList(new int[] { });
            yield return new object[] { ammount, list, expectedList };

            ammount = 1;
            list = new LinkList(new int[] { 66, 10 });
            expectedList = new LinkList(new int[] { 10 });
            yield return new object[] { ammount, list, expectedList };
        }
    }
}