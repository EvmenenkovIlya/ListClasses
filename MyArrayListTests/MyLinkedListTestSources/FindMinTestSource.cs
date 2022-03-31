﻿using System.Collections;
using MyArrayList;

namespace MyArrayListTests.MyLinkedListTestSources
{
    internal class FindMinTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int value = 1;
            LinkList list = new LinkList(new int[] { 5, 2, 3, 4, 1 });
            yield return new object[] { value, list };

            value = 1;
            list = new LinkList(new int[] { 1 });
            yield return new object[] { value, list };

            value = 1;
            list = new LinkList(new int[] { 5, 2, 3, 7, 4, 1 });
            yield return new object[] { value, list };

            value = -7;
            list = new LinkList(new int[] { -5, -2, -3, -1, -7, -4, -1 });
            yield return new object[] { value, list };

            value = -5;
            list = new LinkList(new int[] { -5, 1, 2, 3 });
            yield return new object[] { value, list };
        }
    }
}