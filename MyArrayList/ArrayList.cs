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

            _array = new int[ (int) (lengthOfArr * 1.5 + 1) ];
            Length = lengthOfArr + 1;
            for (int i = 0; i < lengthOfArr; i ++)
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

        public void DeleteLast()
        {
            if (Length <= ((int) _array.Length * 0.5))
            {
                DownSize();
            }

            _array[Length - 1] = 0;
            Length--;
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

    }
}