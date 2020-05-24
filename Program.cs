using System;

namespace Stiva
{
    class Program
    {
        static void Main(string[] args)
        {
            Stivă<int> st = new Stivă<int>();
            Stivă<string> str = new Stivă<string>();

            for (int i = 0; i < 11; i++)
            {
                st.Push(i);
            }

            int last = st.Pop();

            st.Clear();
        }
    }
}
