using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    public class ArrayList : IList
    {
        public int Length { get; private set; }
        private int[] _array;
        public ArrayList()
        {
            _array = new int[10];
            Length = 0;
        }
        public ArrayList(int value)
        {
            _array = new int[10];
            _array[0] = value;
            Length = 1;
        }
        public ArrayList(int[] array)
        {
            Length = array.Length;
            _array = array;
        }
        public void Add(int value)
        {
            if (Length >= _array.Length)
            {
                UpSize();
            }
            _array[Length] = value;
            Length++;
        }
        public void AddFirst(int value)
        {
            if (Length >= _array.Length)
            {
                UpSize();
            }
            for (int i = Length; i >= 0; i--)
            {
                _array[i+1] = _array[i];
            }
            _array[0] = value;
            Length++;
        }
        public void AddByIndex(int index, int value)
        {
            if (Length >= _array.Length)
            {
                UpSize();
            }
            for (int i = Length; i >= index; i--)
            {
                _array[i + 1] = _array[i];
            }
            _array[index] = value;
            Length++;
        }
        public void DeleteLast()
        {
            Length--;
        }
        public void DeleteFirst()
        {
            for (int i = 0; i < Length; i++)
            {
                _array[i] = _array[i + 1];
            }
            Length--;
        }
        public void DeleteByIndex(int index)
        {
            for (int i = index; i < Length-1; i++)
            {
                _array[i] = _array[i + 1];
            }
            Length--;
        }
        public void DeleteSeveralFromEnd(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Length--;
            }
        }
        public void DeleteFirstNElements(int n)
        {
            int tmp = n;
            if (n > Length)
            {
                throw new IndexOutOfRangeException("n < Length");
            }
            for (int i = 0;  tmp != Length; i++)
            {
                _array[i] = _array[tmp];
                tmp++;
            }
            for (int i = 0; i < n; i++)
            {
                Length--;
            }
        }
        public void DeleteNElementsByIndex(int index, int n)
        {
            if (index + n >= Length + 1)
            {
                throw new IndexOutOfRangeException("chtoto nado napisat");
            }
            for (int i = index; i <= Length - n; i++)
            {
                _array[i] = _array[i + n];
            }
            for (int i = 0; i < n; i++)
            {
                Length--;
            }
        }
        public int FindIndexOfValue(int value)
        {
            for (int i = 0; i < Length; i++)
            {
                if (_array[i] == value)
                {
                    return i;
                }
            }
            return -1;
        }
        public void ChangeValueByIndex(int index, int value)
        {
            if (index > Length)
            {
                throw new IndexOutOfRangeException("idiot, out of range");
            }
            _array[index] = value;
        }
        public void Reverse()
        {
            int tmpLength = Length;
            int[] tmpArray = new int[Length];
            for (int i = 0; i < Length; i++)
            {
                tmpArray[i] = _array[tmpLength - 1];
                tmpLength--;
            }
            _array = tmpArray;
        }
        public int FindMax()
        {
            if (Length == 0)
            {
                throw new Exception("Can not find max value - list is empty");
            }
            int max = _array[0];
            for (int i = 0; i < Length; i++)
            {
                if (max <= _array[i])
                {
                    max = _array[i];
                }
            }
            return max;
        }
        public int FindMin()
        {
            if (Length == 0)
            {
                throw new Exception("Can not find min value - list is empty");
            }
            int min = _array[0];
            for (int i = 0; i < Length; i++)
            {
                if (min > _array[i])
                {
                    min = _array[i];
                }
            }
            return min;
        }
        public int FindMaxIndex()
        {
            if (Length == 0)
            {
                throw new Exception("Can not find index of max value - list is empty");
            }
            int max = _array[0];
            int maxIndex = 0;
            for (int i = 0; i < Length; i++)
            {
                if (max <= _array[i])
                {
                    max = _array[i];
                    maxIndex = i;
                }
            }
            return maxIndex;
        }
        public int FindMinIndex()
        {
            if (Length == 0)
            {
                throw new Exception("Can not find index of min value - list is empty");
            }
            int min = _array[0];
            int minIndex = 0;
            for (int i = 0; i < Length; i++)
            {
                if (min > _array[i])
                {
                    min = _array[i];
                    minIndex = i;
                }
            }
            return minIndex;
        }
        private void UpSize()
        {
            int newLenght = (int)(_array.Length * 1.5d + 1);
            int[] newArray = new int[newLenght];
            for (int i = 0; i < _array.Length; i++)
            {
                newArray[i] = _array[i];
            }
            _array = newArray;
        }
        public void Write()
        {
            for (int i = 0; i < Length; i++)
            {
                Console.WriteLine($"{i} - {_array[i]}");
            }
        }
    }
}