﻿using System;

namespace All_Programs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number: ");
            int n = Console.Read();

            int[,] output = new int[n, n];

            printArray();


            void fillUpArray(int start, int row, int col)
            {

            }

            void printArray()
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write(output[i, j] + " ");
                    }
                    Console.WriteLine("\n");
                }
            }



            Console.ReadLine();
        }
    }
}
