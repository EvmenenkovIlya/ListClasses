using System.Collections;
using MyArrayList;

namespace MyArrayListTests.MyArrayListTestsSources
{
    internal class IndexOutOfRange : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int value = 3;
            int index = 7;
            MyArrayList.ArrayList list = new MyArrayList.ArrayList(new int[] { 1, 2, 3, 4, 5 });        
            yield return new object[] { value, index, list};

            value = 2;
            index = 0;
            list = new MyArrayList.ArrayList(new int[] {});
            yield return new object[] { value, index, list};

            value = 10;
            index = -3;
            list = new MyArrayList.ArrayList(new int[] { 1, 2, 3, 4, 5 });
            yield return new object[] { value, index, list};
        }

    }
}
