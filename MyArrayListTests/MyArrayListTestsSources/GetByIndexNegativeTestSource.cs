using System.Collections;
using MyArrayList;

namespace MyArrayListTests.MyArrayListTestsSources
{
    internal class GetByIndexNegativeTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int index = -1;
            AList list = new AList(new int[] { 1, 2, 3, 4, 5 });
            yield return new object[] { index, list };

            index = 5;
            list = new AList(new int[] { 1, 2, 3, 4, 5 });
            yield return new object[] { index, list };

            index = -1;
            list = new AList(new int[] { 1 });
            yield return new object[] { index, list };

            index = 1;
            list = new AList(new int[] { 1 });
            yield return new object[] { index, list };

            index = -1;
            list = new AList(new int[] { });
            yield return new object[] { index, list };

            index = 0;
            list = new AList(new int[] { });
            yield return new object[] { index, list };
        }
    }
}
