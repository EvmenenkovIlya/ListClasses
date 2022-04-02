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
            else 
            {
                _root = new Node(array[0]);
                _tail = _root;    
                for (int i = 1; i < array.Length; i++)
                {
                    AddInTheEnd(array[i]);
                }
                Length = array.Length;
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
                Node tmp = _root;

                for (int i = 0; i < index - 1; i++)
                {
                tmp = tmp.Next;
                }
                Node crnt = new Node(value);
                crnt.Next = tmp.Next;
                tmp.Next = crnt;
                Length += 1;
            }            
        }
        public void DeleteInTheEnd()
        {
            if (Length == 0 || this == null)
            {
                throw new Exception("List is empty or null");
            }
            Node crnt = _root;
            for (int i = 0; i < Length - 1; i++)
            { 
                crnt = crnt.Next;
            }
            _tail = crnt;
            _tail.Next = null;
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
        public void DeleteInTheIndex(int index)
        {
            if (index < 0 || index >= Length)
            {
                throw new IndexOutOfRangeException();
            }
            if (Length == 0 || this == null)
            {
                throw new Exception("List is empty or null");
            }
            if (index == 0)
            {
                DeleteInTheStart();
            }
            else
            {
                Node tmp = _root;
                for (int i = 0; i < index - 1; i++)
                {
                    tmp = tmp.Next;
                }
                tmp.Next = tmp.Next.Next;
                Length--;
            }
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
            _tail.Next = null;
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
        public void DeleteInTheIndexAFewElements(int index, int ammount)
        {
            if ((ammount < 0) || (ammount > Length))
            {
                throw new Exception("Ammount of elements must be more then zero  and less than Length");
            }
            if (index < 0 || index >= Length || (index + ammount > Length))
            {
                throw new IndexOutOfRangeException();
            }
            if (Length == 0 || this == null)
            {
                throw new Exception("List is empty or null");
            }
            if (ammount == 0)
            {
                return;
            }
            if (index == 0)
            {
                DeleteInTheStartAFewElements(ammount);
            }
            else 
            {
                Node startDeleting = null;
                Node endDeleting = _root;
                for (int i = 0; i < index + ammount; i++)
                {
                    if (i == index - 1)
                    {
                        startDeleting = endDeleting;
                    }
                    endDeleting = endDeleting.Next;
                }
                startDeleting.Next = endDeleting;
                Length -= ammount;
            }
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
            if (Length == 0 || this == null)
            {
                throw new Exception("List is empty or null");
            }
            Node crnt = _root;
            Node next;
            while (crnt.Next != null)
            {
                next = crnt.Next;
                crnt.Next = next.Next;
                next.Next = _root;
                _root = next;
            }           
        }
        public int FindMax()
        {
            if (Length == 0 || this == null)
            {
                throw new Exception("List is empty or null");
            }
            int max = _root.Value;
            Node crnt = _root;
            while (crnt.Next != null)
            {
                crnt = crnt.Next;
                if (crnt.Value > max)
                { 
                    max = crnt.Value;
                }
            }
            return max;
        }
        public int FindMin()
        {
            if (Length == 0 || this == null)
            {
                throw new Exception("List is empty or null");
            }
            int min = _root.Value;
            Node crnt = _root;
            while (crnt.Next != null)
            {
                crnt = crnt.Next;
                if (crnt.Value < min)
                { 
                    min = crnt.Value;
                }
            }
            return min;
        }
        public int FindIndexOfMax()
        {
            if (Length == 0 || this == null)
            {
                throw new Exception("List is empty or null");
            }
            int index = 0;
            int max = _root.Value;
            Node crnt = _root;
            for (int i = 0; i < Length; i++)
            {                
                if(crnt.Value > max)
                {
                    index = i;
                    max = crnt.Value;
                }
                crnt = crnt.Next;
            }
            return index;
        }
        public int FindIndexOfMin()
        {
            if (Length == 0 || this == null)
            {
                throw new Exception("List is empty or null");
            }
            int index = 0;
            int min = _root.Value;
            Node crnt = _root;
            for (int i = 0; i < Length; i++)
            {
                if (crnt.Value < min)
                {
                    index = i;
                    min = crnt.Value;
                }
                crnt = crnt.Next;
            }
            return index;
        }
        public void Sort(bool reverse = false)
        {
            int l = Length;
            Node crnt;
            Node prev;

            for (int i = l - 2; i >= 0; i--)
            {
                if (i == 0)
                {
                    crnt = _root;
                    if (crnt.Next != null && crnt.Value > crnt.Next.Value)
                    {
                        _root = crnt.Next;
                        crnt.Next = _root.Next;
                        _root.Next = crnt;
                    }
                    prev = _root;
                }
                else
                {
                    prev = GetNode(i - 1);
                    crnt = prev.Next;
                }

                while (crnt.Next != null && crnt.Value > crnt.Next.Value)
                {
                    prev.Next = crnt.Next;
                    crnt.Next = prev.Next.Next;
                    prev.Next.Next = crnt;

                    prev = prev.Next;
                }
            }
            _tail = GetNode(l - 1);
            if (reverse)
            {
                Reverse();
            }
        }

        public int DeleteFirstValueAndReturnIndex(int value)
        {
            int index = -1;
            Node crnt = _root;
            if (_root.Value == value)
            {
                DeleteInTheStart();
                index = 0;
            }
            else 
            {
                for (int i = 0; i < Length - 1; i++)
                {
                    if (crnt.Next.Value == value)
                    {
                        index = i+1;
                        break;
                    }
                    crnt = crnt.Next;               
                }
                if (index > 0)
                {
                    crnt.Next = crnt.Next.Next;
                    Length--;
                }
            }
            return index;
        }
        public int DeleteAllValueAndReturnCount(int value)
        {  
            int count = 0;
            Node crnt = _root;
            while (crnt != null)
            {
                if (_root.Value == value)
                {
                    DeleteInTheStart();
                    count += 1;
                    crnt = _root;
                }
                else 
                {
                    if (crnt.Next == null)
                    {
                        break;
                    }
                    if (crnt.Next.Value == value)
                    {
                        if (crnt.Next == null)
                        {
                            DeleteInTheEnd();
                            count += 1;
                            break;
                        }
                        else 
                        {
                            crnt.Next = crnt.Next.Next;
                            count += 1;
                            Length -= 1;                    
                        }
                    }                    
                    crnt = crnt.Next;
                }
            }
            return count;
        }
        public void AddListInTheEnd(LinkList list)
        {
            _tail.Next = list._root;
            _tail = list._tail;
            Length = Length + list.Length;
        }
        public void AddListInTheStart(LinkList list)
        {
            list._tail.Next = _root;
            _root = list._root;
            Length = Length + list.Length;
        }
        public void AddListInTheIndex(LinkList list, int index)
        {
            if (index < 0 || index >= Length)
            {
                throw new IndexOutOfRangeException();
            }
            if (index == 0)
            {
                AddListInTheStart(list);
            }
            else 
            {
            Node crnt = _root;
            for (int i = 1; i < index; i++)
            {
                crnt = crnt.Next;
            }
            list._tail.Next = crnt.Next;
            crnt.Next = list._root;
            Length = Length + list.Length;
            }
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
    }
}
