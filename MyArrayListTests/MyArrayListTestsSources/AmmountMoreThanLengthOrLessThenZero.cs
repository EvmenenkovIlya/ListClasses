using System.Collections;
using MyArrayList;


namespace MyArrayListTests.MyArrayListTestsSources
{
    internal class AmmountMoreThanLengthOrLessThenZero : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {

            int ammount = 17;
            MyArrayList.AList list = new MyArrayList.AList(new int[] { 1, 2, 3, 4, 5 });
            yield return new object[] { ammount, list };

            ammount = 2;
            list = new MyArrayList.AList(new int[] { });
            yield return new object[] { ammount, list};

            ammount = 4;
            list = new MyArrayList.AList(new int[] { 44 });
            yield return new object[] { ammount, list};

            ammount = -1;
            list = new MyArrayList.AList(new int[] { 66, 10 });
            yield return new object[] { ammount, list};
        }
    }
}