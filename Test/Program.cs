﻿using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,,] mas = { { { 1, 2 },{ 3, 4 } },
                { { 4, 5 }, { 6, 7 } },
                { { 7, 8 }, { 9, 10 } },
                { { 10, 11 }, { 12, 13 } }
              };

            Console.Write("{");
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                Console.Write("{");
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    Console.Write("{");
                    for (int a = 0; a < mas.GetLength(2); a++)
                    {
                        Console.Write($"{mas[i, j, a]}");
                    }
                    Console.Write("}");
                }
                Console.Write("}");
            }
            Console.Write("}");
        }
    }
}
