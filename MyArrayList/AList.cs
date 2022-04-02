namespace MyArrayList
{
    public class AList
    {
        public int Length { get; private set; }

        private int[] _array;

        public int this[int index]
        {
            get
            {
                if (index < 0 || index >= Length)
                {
                    throw new IndexOutOfRangeException();
                }
                return _array[index];
            }
            set
            {
                if (index < 0 || index >= Length)
                {
                    throw new IndexOutOfRangeException();
                }
                _array[index] = value;
            }
        }
        public AList()
        {
            _array = new int[10];
            Length = 0;
        }

        public AList(int element)
        {
            _array = new int[10];
            _array[0] = element;
            Length = 1;
        }
        public AList(int[] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                _array = new int[10];
                Length = 0;
            }

            int lengthOfArr = arr.Length;

            _array = new int[(int)(lengthOfArr * 1.5 + 1)];
            Length = lengthOfArr;
            for (int i = 0; i < lengthOfArr; i++)
            {
                _array[i] = arr[i];
            }
        }

        public void AddInTheEnd(int value)
        {
            if (Length >= _array.Length)
            {
                UpSize();
            }

            _array[Length] = value;
            Length++;
        }
        public void AddInTheStart(int value)
        {
            Shift(0, Length + 1, 1);
            _array[0] = value;
        }
        public void AddInTheIndex(int value, int index)
        {
            if (index < 0 || index >= Length)
            {
                throw new IndexOutOfRangeException();
            }
            Shift(index, Length + 1, 1);
            _array[index] = value;
        }
        public void DeleteLast()
        {
            if (Length == 0 || this == null)
            {
                throw new Exception("List is empty or null");
            }
            _array[Length - 1] = 0;
            Length--;

            if (Length <= ((int)_array.Length * 0.5))
            {
                DownSize();
            }
        }
        public void DeleteFirst()
        {
            if (Length == 0 || this == null)
            {
                throw new Exception("List is empty or null");
            }
            Shift(1, Length, -1);
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

            Shift(index + 1, Length, -1);
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
            for (int i = Length - 1; i >= Length - ammount; i--)
            {
                _array[i] = 0;
            }
            Length -= ammount;

            if (Length <= ((int)_array.Length * 0.5))
            {
                DownSize();
            }
        }
        public void DeleteInTheStartAFewElements(int ammount)
        {
            if ((ammount < 0) || (ammount > Length))
            {
                throw new Exception("Ammount of elements must be more then zero and less than Length");
            }
            if (Length == 0 || this == null)
            {
                throw new Exception("List is empty or null");
            }
            if (ammount == 0)
            {
                return;
            }
            Shift(ammount, Length, -ammount);
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
            for (int i = index; i < Length; i++)
            {
                _array[i] = _array[i + ammount];
            }
            Length -= ammount;

            if (Length <= ((int)_array.Length * 0.5))
            {
                DownSize();
            }
        }
        public int ReturnLength()
        {
            return Length;
        }
        public int AccessByIndex(int index)
        {
            if (index < 0 || index >= Length)
            {
                throw new Exception("Index out of range");
            }
            return _array[index];
        }
        public int FindFirstIndexOfValue(int value)
        {
            if (Length == 0 || this == null)
            {
                throw new Exception("List is empty or null");
            }
            for (int i = 0; i <= Length; i++)
            {
                if (_array[i] == value)
                {
                    return i;
                }
            }
            return -1;
        }
        public void ChangeValueInTheIndex(int value, int index)
        {
            if (index >= Length)
            {
                throw new Exception("Index out of range");
            }
            _array[index] = value;
        }
        public void Reverse()
        {
            for (int i = 0; i < Length / 2; i++)
            {
                ChangeNumbers(ref _array[i], ref _array[Length - i - 1]);
            }
        }
        public int FindMax()
        {
            if (Length == 0 || this == null)
            {
                throw new Exception("List is empty or null");
            }
            int max = _array[0];
            for (int i = 0; i < Length; i++)
            {
                if (_array[i] > max)
                {
                    max = _array[i];
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
            int min = _array[0];
            for (int i = 0; i < Length; i++)
            {
                if (_array[i] < min)
                {
                    min = _array[i];
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
            int max = FindMax();
            return FindFirstIndexOfValue(max);
        }
        public int FindIndexOfMin()
        {
            if (Length == 0 || this == null)
            {
                throw new Exception("List is empty or null");
            }
            int min = FindMin();
            return FindFirstIndexOfValue(min);
        }
        public void BubbleSort(bool reverse = false)
        {
            int[] sortedArray = new int[_array.Length];
            Array.Copy(_array, sortedArray, _array.Length);
            for (int i = 0; i < Length - 1; i++)
            {
                for (int j = 0; j < Length - i - 1; j++)
                {
                    if (sortedArray[j] > sortedArray[j + 1])
                    {
                        ChangeNumbers(ref sortedArray[j], ref sortedArray[j + 1]);
                    }
                }
            }
            _array = sortedArray;
            if (reverse)
            {
                Reverse();
            }
        }
        public int DeleteFirstValueAndReturnIndex(int value)
        {
            int index = FindFirstIndexOfValue(value);

            if (index >= 0)
            { 
                DeleteInTheIndex(index);
            }
            return index;        
        }
        public int DeleteAllValueAndReturnCount(int value)
        {
            int count = 0;
            for (int i = 0; i < Length; i++)            
            {
                if (_array[i] == value)
                {
                    count++;
                }
                else
                {
                    _array[i - count] = _array[i];
                }
            }      
            Length -= count;
            return count;
        }
        public void AddListInTheEnd(AList list)
        { 
        int newLength = (int) ((list.Length + this.Length) * 1.5d + 1);
        int[] newArray = new int[newLength];
            for (int i = 0; i < this.Length; i++)
            {
                newArray[i] = _array[i];
            }
            for (int i = 0; i < list.Length; i++)
            {
                newArray[i + Length] = list[i];
            }
            _array = newArray;
            Length = list.Length + Length;
        }
        public void AddListInTheStart(AList list)
        {
            int newLength = (int)((list.Length + this.Length) * 1.5d + 1);
            int[] newArray = new int[newLength];

            for (int i = 0; i < list.Length; i++)
            {
                newArray[i] = list[i];
            }
            for (int i = 0; i < Length; i++)
            {
                newArray[i + list.Length] = _array[i];
            }
            _array = newArray;
            Length = list.Length + Length;
        }
        public void AddListInTheIndex(AList list, int index)
        {
            if (index < 0 || index >= Length)
            {
                throw new IndexOutOfRangeException();
            }
            if (Length == 0 || this == null || list.Length == 0 || list == null)
            {
                throw new Exception("List is empty or null");
            }            
            int newLength = (int)((list.Length + Length) * 1.5d + 1);
            int[] newArray = new int[newLength];


            for (int i = 0; i < index; i++)
            {
                newArray[i] = _array[i];
            }

            for (int i = 0; i < list.Length; i++)
            {
                newArray[i + index] = list[i];
            }

            for (int i = index; i < Length; i++)
            {
                newArray[i + list.Length] = _array[i];
            }
            _array = newArray;
            Length = list.Length + Length;
        }

        private void UpSize()
        {
            int newLength = (int)(_array.Length * 1.5d + 1);
            int[] newArray = new int[newLength];
            for (int i = 0; i < _array.Length; i++)
            {
                newArray[i] = _array[i];
            }
            _array = newArray;
        }
        private void DownSize()
        {
            int newLength = (int)(_array.Length / 1.3d + 1);
            int[] newArray = new int[newLength];
            for (int i = 0; i < newLength; i++)
            {
                newArray[i] = _array[i];
            }
            _array = newArray;
        }

        public override string ToString()
        {
            string s = "[";

            for (int i = 0; i < Length; i++)
            {
                s += $"{_array[i]} ";
            }
            s += "]";
            return s;
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || !(obj is AList))
            {
                return false;
            }
            else
            {
                AList list = (AList)obj;
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


        private void Shift(int firstIndex, int lastIndex, int step)
        {
            Length += step;

            if (Length >= _array.Length)
            {
                UpSize();
            }

            int[] newArray = new int[_array.Length];

            for (int i = 0; i < firstIndex; i++)
            {
                newArray[i] = _array[i];
            }

            for (int i = firstIndex; i < lastIndex; i++)
            {
                newArray[i + step] = _array[i];
            }

            _array = newArray;

            if (Length < (int)(_array.Length * 0.5 + 1))
            {
                DownSize();
            }

        }

        private void ChangeNumbers(ref int a, ref int b)
        {
            int tmp = b;
            b = a;
            a = tmp;
        }
        public AList CopyAList(AList list)
        {           
            AList newList = new AList();
            newList.AddListInTheStart(list);

            return newList;
        }
        public void Write()
        {
            Console.Write($"L={Length} RL={_array.Length}   ");
            for (int i = 0; i < Length; i++)
            {
                Console.Write($"{_array[i]} ");
            }
            Console.WriteLine();
        }
    }
}