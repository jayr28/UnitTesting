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
        private int Capacity = 1;

        

        public void Add(T value)
        {
            int x = Capacity;
            if (Count >= Capacity)
            {
                x = Count + 1;
            }

            T[] temp = new T[x];
            for (int i = 0; i < Count; i++)
            {
                temp[i] = numbers[i];
            }
            temp[Count] = value;
            count++;
            numbers = temp;

        }

        public void Remove(T value)
        {
           
            int TempCount = Count - 1;
            T[] TempArray = new T[TempCount];

            int Location = 0;
            int d = 0;

            for(int i =0; i <Count; i++) //looking for existence of item to be removed
            {
                if(numbers[i].Equals(value))
                {
                    Location = i;
                    break;
                }
            }

            if(Location > 0)
            {
                for(int e = 0; e <Count; e++)
                {
                    if (!numbers[e].Equals(value))
                    {
                        TempArray[d] = numbers[e];
                        d += 1;
                    }
                }
                numbers = TempArray;
            }
            count = d;
        }

        public override void ToString()
        {
            CustomNumbers<string> temp = new CustomNumbers<string>();
            
            int d = 0;
            for (int i = 0; i < Count; i++)
            {
                temp[i] = numbers[i].ToString();
                d += 1;
            }

            count = d;
           
            numbers = temp;
        }

    }


}

