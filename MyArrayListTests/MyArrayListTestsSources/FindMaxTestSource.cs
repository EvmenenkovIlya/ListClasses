using System.Collections;
using MyArrayList;

namespace MyArrayListTests.MyArrayListTestsSources
{
    internal class FindMaxTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int value = 5;
            AList list = new AList(new int[] { 5, 2, 3, 4, 1 });
            yield return new object[] { value, list };

            value = 1;
            list = new AList(new int[] { 1 });
            yield return new object[] { value, list };

            value = 7;
            list = new AList(new int[] { 5, 2, 3, 7, 4, 1 });
            yield return new object[] { value, list };

            value = -1;
            list = new AList(new int[] { -5, -2, -3, -1, -7, -4, -1 });
            yield return new object[] { value, list };

            value = 3;
            list = new AList(new int[] { 1, 2, 3 });
            yield return new object[] { value, list };
        }
    }
}