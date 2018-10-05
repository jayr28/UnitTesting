using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomNumbers<T>
    {

        private int count;

        T[] numbers = new T[8];
        
        public T this[int index]
        {
            get
            {
                return numbers[index];
            }
            set
            {
                numbers[index] = value;
            }
        }

        public int Count{get{ return count;}}
        private int Capacity = 4;

        

        public void Add(T value)
        {
            T[] temp = new T[Capacity * 2];
            for (int i = 0; i < Count; i++)
            {
                temp[i] = numbers[i];
            }
            temp[Count] = value;
            count++;
            numbers = temp;
        }
    }
}

