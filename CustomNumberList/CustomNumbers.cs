using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class CustomNumbers<T>
    {
        T[] numbers = new T[8];
        int count = 0;
        public int Count
        {
            get
            {
                return Count;
            }
        }
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

