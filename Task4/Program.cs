using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[]
            {
                9, 8, 7, 6
            };

            var a = new MyStack(array);

            a.Push(0, 1);
            a.Push(1, 2);
            a.Push(2, 3);
            a.Push(3, 4);


            a.Pop(3);
        }
    }
}
