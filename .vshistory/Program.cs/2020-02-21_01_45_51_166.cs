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
            int startIndex = 0, endIndex = n - 1, startNumber = 1;

            try
            {

                fillUpEmptyArray();

                startNumber = fillUpArray(startNumber, startIndex, endIndex);

                do
                {
                    startIndex += 1;
                    endIndex -= 1;
                    fillUpArray(startNumber, startIndex, endIndex);
                } while (startIndex != endIndex);

                int fillUpArray(int start, int row, int runNumber)
                {
                    output[row, row] = start;

                    for (int i = 1; i < runNumber + 1; i++)
                    {
                        start += 1;
                        output[row, row + i] = start;
                    }

                    for (int i = 1; i < runNumber + 1; i++)
                    {
                        start += 1;
                        output[i, runNumber] = start;
                    }

                    for (int i = 1; i < runNumber + 1; i++)
                    {
                        start += 1;
                        output[runNumber, runNumber - i] = start;
                    }

                    for (int i = 1; i < runNumber; i++)
                    {
                        start += 1;
                        output[runNumber - i, row] = start;
                    }

                    printArray();
                    return start + 1;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
                Console.WriteLine("startIndex: " + startIndex);
                Console.WriteLine("endIndex: " + endIndex);
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
