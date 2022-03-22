using System.Collections;
using MyArrayList;


namespace MyArrayListTests.MyArrayListTestsSources
{
    internal class AmmountMoreThanLengthOrLessThenZero : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int ammount = 17;
            MyArrayList.ArrayList list = new MyArrayList.ArrayList(new int[] { 1, 2, 3, 4, 5 });
            yield return new object[] { ammount, list };

            ammount = 0;
            list = new MyArrayList.ArrayList(new int[] { });
            yield return new object[] { ammount, list};

            ammount = 4;
            list = new MyArrayList.ArrayList(new int[] { 44 });
            yield return new object[] { ammount, list};

            ammount = -1;
            list = new MyArrayList.ArrayList(new int[] { 66, 10 });
            yield return new object[] { ammount, list};
        }
    }
}