
using System.Collections;
using MyArrayList;

namespace MyArrayListTests.MyArrayListTestsSources
{
    internal class ChangingByIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int index = 4;
            AList list = new AList(new int[] { 5, 2, 3, 4, 1 });
            yield return new object[] { index, list };

            index = 0;
            list = new AList(new int[] { 1 });
            yield return new object[] { index, list };

            index = 5;
            list = new AList(new int[] { 5, 2, 3, 7, 4, 1 });
            yield return new object[] { index, list };

            index = 0;
            list = new AList(new int[] { -5, -2, -3, -1, -7, -4, -1 });
            yield return new object[] { index, list };

        }
    }
}
