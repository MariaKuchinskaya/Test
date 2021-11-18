using System;

namespace Task2
{
    class Program
    {
        static void Main()
        {
            var result = new MyString("Hello");
            var reversedName = result.Reverse();
            Console.WriteLine($"{reversedName}");
        }
    }
}
