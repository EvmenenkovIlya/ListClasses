namespace MyArrayList
{
    public class ArrayList
    {
        public int Length { get; private set; }

        private int[] _array;

        public ArrayList()
        {
            _array = new int[10];
            Length = 0;
        }

        public ArrayList(int element)
        {
            _array = new int[10];
            _array[0] = element;
            Length = 1;
        }
        public ArrayList(int[] arr)
        {
            int lengthOfArr = arr.Length;

            _array = new int[(int)(lengthOfArr * 1.5 + 1)];
            Length = lengthOfArr + 1;
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
            Shift(index, Length + 1, 1);
            _array[index] = value;
        }

        public void DeleteLast()
        {
            _array[Length - 1] = 0;
            Length--;

            if (Length <= ((int)_array.Length * 0.5))
            {
                DownSize();
            }
        }

        public void DeleteFirst()
        {
            Shift(1, Length, -1);
        }

        public void DeleteInTheIndex(int index)
        {
            Shift(index + 1, Length, -1);
        }

        public void DeleteInTheEndAFewElements(int ammount)
        {
            if (ammount < 0)
            {
                throw new Exception("Ammount of elements must be more then zero");
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
            if (ammount < 0)
            {
                throw new Exception("Ammount of elements must be more then zero");
            }
            Shift(ammount, Length, -ammount);
        }

        public void DeleteInTheIndexAFewElements(int index, int ammount, bool right = true)
        {
            if (ammount < 0)
            {
                throw new Exception("Ammount of elements must be more then zero");
            }

        }

        public int ValueOfLength()
        {
            return Length;
        }
        public int AccessByIndex(int index)
        {
            if (index >= Length)
            {
                throw new Exception("Index out of range");
            }
            return _array[index];
        }
        public int FindFirstIndexOfValue(int value)
        {
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

        public int FindMax()
        {
            int max = _array[0];
            for (int i = 0; i <= Length; i++)
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
            int min = _array[0];
            for (int i = 0; i <= Length; i++)
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
            int max = FindMax();
            return FindFirstIndexOfValue(max);
        }
        public int FindIndexOfMin()
        {
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

        public void Reverse()
        {
            for (int i = 0; i < Length / 2 ; i++)
            {
                ChangeNumbers(ref _array[i], ref _array[Length - i - 1]);
            }
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

        public void Shift(int firstIndex, int lastIndex, int step)
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
    }
}