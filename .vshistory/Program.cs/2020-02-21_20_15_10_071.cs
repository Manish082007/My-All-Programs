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
            int index = 0, run = n - 1, startNumber = 1, nCall = 0;

            try
            {
                fillUpEmptyArray();

                output[index, index] = startNumber;
                fillUpArray();

                do
                {
                    index += 1;
                    run -= 1;
                    nCall += 1;
                    fillUpArray();
                } while ((index + 1) * 2 <= n);

                void fillUpArray()
                {
                    

                    for (int i = index + 1 - nCall; i < run + 1 - nCall; i++)
                    {
                        startNumber += 1;
                        output[index, index + i] = startNumber;
                    }

                    printArray();

                    for (int i = index + 1; i < run + 1; i++)
                    {
                        startNumber += 1;
                        output[i, run] = startNumber;
                    }

                    printArray();

                    for (int i = index + 1 - nCall; i < run + 1 - nCall; i++)
                    {
                        startNumber += 1;
                        output[run, run - i] = startNumber;
                    }

                    printArray();

                    for (int i = index + 1; i < run; i++)
                    {
                        startNumber += 1;
                        output[run - i, index] = startNumber;
                    }

                    printArray();
                    startNumber += 1;
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
