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

        public int Length;

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
        }

        public LinkList(int value)
        {
            _root = new Node(value);
            _tail = _root;
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
