using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyArrayLists
{
    public interface IMyList
    {
        public int Length { get; }
        public void AddInTheEnd(int value);
        public void AddInTheStart(int value);
        public void AddInTheIndex(int value, int index);
    }
}
