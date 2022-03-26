using System.Collections;
using MyArrayList;


namespace MyArrayListTests.MyLinkedListTestSources
{
    internal class DeleteInTheEndTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            LinkList list = new LinkList(new int[] { 1, 2, 3, 4, 5 });
            LinkList expectedList = new LinkList(new int[] { 1, 2, 3, 4 });
            yield return new object[] {list, expectedList };
            
            list = new LinkList(new int[] { 1 });
            expectedList = new LinkList(new int[] {});
            yield return new object[] {list, expectedList };

            list = new LinkList(new int[] { 55, 10 });
            expectedList = new LinkList(new int[] {55 });
            yield return new object[] {list, expectedList };
        }
    }
}