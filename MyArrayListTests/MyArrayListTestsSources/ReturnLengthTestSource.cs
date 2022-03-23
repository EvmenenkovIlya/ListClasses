using System.Collections;
using MyArrayList;

namespace MyArrayListTests.MyArrayListTestsSources
{
    internal class ReturnLengthTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int length = 5;
            MyArrayList.AList list = new MyArrayList.AList(new int[] { 1, 2, 3, 4, 5 });
            yield return new object[] { length, list };

            length = 1;
            list = new MyArrayList.AList(new int[] { 1 });
            yield return new object[] { length, list };

            length = 0;
            list = new MyArrayList.AList(new int[] {  });
            yield return new object[] { length, list};

            length = 3;
            list = new MyArrayList.AList(new int[] { 1, 2, 3});
            yield return new object[] { length, list };
        }
    }
}