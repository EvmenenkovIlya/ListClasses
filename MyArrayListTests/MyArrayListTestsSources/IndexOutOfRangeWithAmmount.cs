using System.Collections;
using MyArrayList;

namespace MyArrayListTests.MyArrayListTestsSources
{
    internal class IndexOutOfRangeWithAmmount : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int ammount = 3;
            int index = 7;
            MyArrayList.AList list = new MyArrayList.AList(new int[] { 1, 2, 3, 4, 5 });        
            yield return new object[] { ammount, index, list};

            ammount = 0;
            index = 0;
            list = new MyArrayList.AList(new int[] {});
            yield return new object[] { ammount, index, list};

            ammount = 3;
            index = -3;
            list = new MyArrayList.AList(new int[] { 1, 2, 3, 4, 5 });
            yield return new object[] { ammount, index, list};
        }

    }
}
