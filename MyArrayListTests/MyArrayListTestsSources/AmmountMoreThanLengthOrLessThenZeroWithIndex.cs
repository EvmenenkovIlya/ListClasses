using System.Collections;
using MyArrayList;


namespace MyArrayListTests.MyArrayListTestsSources
{
    internal class AmmountMoreThanLengthOrLessThenZeroWithIndex : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int ammount = 17;
            int index = 1;
            MyArrayList.AList list = new MyArrayList.AList(new int[] { 1, 2, 3, 4, 5 });
            yield return new object[] { ammount, index, list };

            ammount = 2;
            index = 0;
            list = new MyArrayList.AList(new int[] { });
            yield return new object[] { ammount, index, list };

            ammount = 4;
            index = 1;
            list = new MyArrayList.AList(new int[] { 44 });
            yield return new object[] { ammount, index, list };

            ammount = -1;
            index = 1;
            list = new MyArrayList.AList(new int[] { 66, 10 });
            yield return new object[] { ammount, index, list };
        }
    }
}