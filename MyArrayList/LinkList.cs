using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyArrayList
{
    public class LinkList
    {
        private Node _root;

        private Node _tail;
        public int Length { get; private set; }

        public int this[int index]
        {
            get
            {
                if (index < 0 || index >= Length)
                {
                    throw new IndexOutOfRangeException();
                }
                Node crnt = _root;

                for (int i = 1; i <= index; i++)
                    crnt = crnt.Next;

                return crnt.Value;
            }

            set
            {
                if (index < 0 || index >= Length)
                {
                    throw new IndexOutOfRangeException();
                }
                Node crnt = _root;

                for (int i = 1; i <= index; i++)
                {
                    crnt = crnt.Next;
                }
                crnt.Value = value;
            }
        }

        public LinkList()
        {
            _root = null;
            _tail = null;
            Length = 0;
        }

        public LinkList(int value)
        {
            _root = new Node(value);
            _tail = _root;
            Length = 1;
        }
        public LinkList(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                _root = null;
                _tail = null;
            }
            for (int i = 0; i < array.Length; i++)
            {
                AddInTheEnd(array[i]);
            }
            Length = array.Length;
        }

        public void AddInTheEnd(int value)
        {
            if (_root == null)
            {
                _root = new Node(value);
                _tail = _root;
            }
            else
            {
                _tail.Next = new Node(value);
                _tail = _tail.Next;
            }
            Length += 1;
        }


        public override string ToString()
        {
            string s = "[";
            Node crnt = _root;
            while (crnt != null)
            {
                s += $"{crnt.Value} ";
                crnt = crnt.Next;
            }
                s += "]";                     
            return s;
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || !(obj is LinkList))
            {
                return false;
            }
            else
            {
                LinkList list = (LinkList)obj;
                if (list.Length != this.Length)
                {
                    return false;
                }
                else
                {
                    for (int i = 0; i < this.Length; i++)
                    {
                        if (list[i] != this[i])
                        {
                            return false;
                        }
                    }
                    return true;
                }
            }
        }
        public void Write()
        {
            Node crnt = _root;
            Console.Write("[");
            while (crnt != null)
            { 
                Console.Write($"{crnt.Value} ");
                crnt= crnt.Next;
            }
            Console.Write("]");
            Console.WriteLine();
        }



    }
}
