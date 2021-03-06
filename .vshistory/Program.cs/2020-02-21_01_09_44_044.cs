﻿using System;

namespace All_Programs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number: ");
            int n = Console.Read();

            int[,] output = new int[n, n];
            int startIndex = 0, endIndex = n;
            fillUpEmptyArray();

            do
            {
                startIndex += 1;
                endIndex -= 1;
                fillUpArray(1, startIndex-1, endIndex);
            } while (startIndex != endIndex);

            printArray();

            Console.ReadLine();

            void fillUpArray(int start, int row, int col)
            {
                output[row, row] = start;
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

            void fillUpEmptyArray()
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        output[i, j] = 0;
                    }
                }
            }

        }
    }
}
