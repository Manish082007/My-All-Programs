using System;

namespace All_Programs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number: ");
            int n = int.Parse(Console.ReadLine());
            int[,] output = new int[n, n];
            int index = 0, run = n - 1, startNumber = 1;

            try
            {
                fillUpEmptyArray();

                startNumber = fillUpArray(startNumber, index, run);

                do
                {
                    index += 1;
                    run -= 2;
                    fillUpArray(startNumber, index, run);
                } while ((index + 1) * 2 <= n);

                int fillUpArray(int start, int row, int run)
                {
                    output[row, row] = start;

                    for (int i = 1; i < run + 1; i++)
                    {
                        start += 1;
                        output[row, row + i] = start;
                    }

                    printArray();

                    for (int i = row + 1; i < run + 1; i++)
                    {
                        start += 1;
                        output[i, run] = start;
                    }

                    printArray();

                    for (int i = row + 1; i < run + 1; i++)
                    {
                        start += 1;
                        output[run, run - i] = start;
                    }

                    printArray();

                    for (int i = row + 1; i < run; i++)
                    {
                        start += 1;
                        output[run - i, row] = start;
                    }

                    printArray();
                    return start + 1;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
                Console.WriteLine("startIndex: " + index);
                Console.WriteLine("endIndex: " + run);
                Console.WriteLine("startNumber: " + startNumber);
            }

            printArray();
            Console.ReadLine();

            void printArray()
            {
                Console.WriteLine("\n");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write(output[i, j] + " ");
                    }
                    Console.WriteLine("\n");
                }
                Console.WriteLine("\n");
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
