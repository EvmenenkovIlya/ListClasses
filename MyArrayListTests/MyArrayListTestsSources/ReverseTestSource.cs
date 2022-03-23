using System.Collections;
using MyArrayList;

namespace MyArrayListTests.MyArrayListTestsSources
{
    internal class ReverseTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            AList expectedResult= new AList(new int[] { 1, 2, 3, 4, 5 });
            AList list = new AList(new int[] { 5, 4, 3, 2, 1 });
            yield return new object[] { expectedResult, list };

            expectedResult = new AList(new int[] { 1 });
            list = new AList(new int[] { 1});
            yield return new object[] { expectedResult, list };

            expectedResult = new AList(new int[] {  });
            list = new AList(new int[] { });
            yield return new object[] { expectedResult, list };

            expectedResult = new AList(new int[] { 2, 1, 2, 1});
            list = new AList(new int[] { 1,2, 1,2});
            yield return new object[] { expectedResult, list };
        }
    }
}