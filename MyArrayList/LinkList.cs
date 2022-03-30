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

        public void AddInTheStart(int value)
        {
            if (_root == null)
            {
                _root = new Node(value);
                _tail = _root;
            }
            else
            {
                Node crnt = new Node(value);
                crnt.Next = _root;
                _root = crnt;
            }
            Length += 1;
        }

        public void AddInTheIndex(int value, int index)
        {
            if (index < 0 || index >= Length)
            {
                throw new IndexOutOfRangeException();
            }
            if (index == 0)
            {
                AddInTheStart(value);
            }
            else
            {
                Node previosNode = GetNode(index - 1);
                Node nextNode = GetNode(index);
                Node crnt = new Node(value);
                previosNode.Next = crnt;
                crnt.Next = nextNode;

            }
            Length += 1;
        }

        public void DeleteInTheEnd()
        {
            if (Length == 0 || this == null)
            {
                throw new Exception("List is empty or null");
            }
            _tail = null;
            Length -= 1;
        }

        public void DeleteInTheStart()
        {
            if (Length == 0 || this == null)
            {
                throw new Exception("List is empty or null");
            }
            _root = _root.Next;
            Length -= 1;
        }

        public void DeleteInTheEndAFewElements(int ammount)
        {
            if ((ammount < 0) || (ammount > Length))
            {
                throw new Exception("Ammount of elements must be more then zero and less than Length");
            }
            if (ammount == 0)
            {
                return;
            }
            if (Length == 0 || this == null)
            {
                throw new Exception("List is empty or null");
            }
            _tail = GetNode(Length - ammount);
            Length -= ammount;
        }

        public void DeleteInTheStartAFewElements(int ammount)
        {
            if ((ammount < 0) || (ammount > Length))
            {
                throw new Exception("Ammount of elements must be more then zero and less than Length");
            }
            if (ammount == 0)
            {
                return;
            }
            if (Length == 0 || this == null)
            {
                throw new Exception("List is empty or null");
            }
            _root = GetNode(ammount);
            Length -= ammount;
        }

        public int FindFirstIndexOfValue(int value)
        {
            if (Length == 0 || this == null)
            {
                throw new Exception("List is empty or null");
            }
            int index = 0;
            Node crnt = _root;
            while (crnt != null)
            {
                if (crnt.Value == value)
                { 
                    return index;
                }
                index++;
                crnt = crnt.Next;
            }
            return -1;
        }

        public void Reverse()
        { 
            Node crnt = _root;
            _root = _tail;
            _tail = crnt;       
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
                    Node thisCrnt = this._root;
                    Node listCrnt = list._root; 
                    while (thisCrnt != null)
                    {
                        if (thisCrnt.Value != listCrnt.Value)
                        { 
                            return false;
                        }
                        thisCrnt = thisCrnt.Next;
                        listCrnt = listCrnt.Next;
                    }
                    /*for (int i = 0; i < this.Length; i++)
                    {
                        if (list[i] != this[i])
                        {
                            return false;
                        }
                    }      */             
                }
            }
            return true;
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

        private Node GetNode(int index)
        {
            Node crnt = _root;
            for (int i = 0; i < index; i++)
            { 
            crnt = crnt.Next;
            }
            return crnt;
        }
        private void SwapValueInNode(ref Node a, ref Node b)
        {
            int tmp = a.Value;
            a.Value = b.Value; 
            b.Value = tmp; 
        }

        private LinkList CopyOfList()
        { 
            LinkList copy = new LinkList();
            
            return copy;
        }

    }
}
