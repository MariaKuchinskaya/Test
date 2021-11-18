namespace Task4
{
    public struct MyStack
    {
        public  int [] _array;

        public MyStack(int[] value)
        {
            _array = value;
        }

        public int Pop (int index)
        {
            int lastValue = _array[index];
            
            int [] newArray = new int[_array.Length - 1];

            for (int i = 0; i < index; i++)
            {
                newArray[i] = _array[i];
            }

            for (int i = index; i < newArray.Length; i++)
            {
                newArray[i] = _array[i + 1];
            }

            _array = newArray;
            return lastValue;
        }

        public void Push (int index, int value)
        {
            int[] newArray = new int[_array.Length + 1];

            for (int i = 0; i < index; i++)
            {
                newArray[i] = _array[i];
            }

            newArray[index] = value;

            for (int i = index + 1; i < newArray.Length; i++)
            {
                newArray[i] = _array[i - 1];
            }

            _array = newArray;
        }
    }
}
