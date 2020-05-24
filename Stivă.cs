using System;

namespace Stiva
{
    internal class Stivă<T>
    {

        T[] data;
        int count;
        
        public Stivă()
        {
            data = new T[10];
            count = 0;
        }

        public Stivă(int length)
        {
            data = new T[length];
            count = 0;
        }

        public void Push(T elem)
        {
            if(count == data.Length)
            {
                Array.Resize(ref data, data.Length * 2);
                data[count] = elem;
                count++;
            }
            else
            {
                data[count] = elem;
                count++;
            }
        }

        public T Pop()
        {
            if(count == 0) {
                throw new StivaGoalaExceptie("Stiva este goala");
            }
            return data[count - 1];
        }
        
        public void Clear()
        {
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = default;
            }
            Array.Resize(ref data, 10);
        }

        
    }
}