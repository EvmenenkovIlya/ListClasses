using System.Collections;
using MyArrayList;

namespace MyArrayListTests.MyLinkedListTestSources
{ 
    internal class WhenAmmountMoreThanLengthOrLessThanZeroTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {

            int ammount = 17;
            LinkList list = new LinkList(new int[] { 1, 2, 3, 4, 5 });
            yield return new object[] { ammount, list };

            ammount = 2;
            list = new LinkList(new int[] { });
            yield return new object[] { ammount, list };

            ammount = 4;
            list = new LinkList(new int[] { 44 });
            yield return new object[] { ammount, list };

            ammount = -1;
            list = new LinkList(new int[] { 66, 10 });
            yield return new object[] { ammount, list };
        }
    }
}