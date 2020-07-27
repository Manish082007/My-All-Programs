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
            int index = 0, run = n, startNumber = 1, endNumber = n * n;

            try
            {
                fillUpEmptyArray();

                output[index, index] = startNumber;
                fillUpArray();

                do
                {
                    index += 1;
                    run -= 1;
                    fillUpArray();
                } while (startNumber < endNumber);

                void fillUpArray()
                {
                    fillUpTopRow();
                    fillUpLastColumn();
                    fillUpBottomRow();
                    fillFirstColumn();
                }

                void fillUpTopRow()
                {
                    output[index, index] = startNumber;
                    for (int i = 1; i < run; i++)
                    {
                        startNumber += 1;
                        output[index, index + i] = startNumber;
                    }

                    printArray();
                }

                void fillUpLastColumn()
                {
                    for (int i = 1; i < run; i++)
                    {
                        startNumber += 1;
                        output[index + i, run - 1] = startNumber;
                    }

                    printArray();
                }

                void fillUpBottomRow()
                {
                    for (int i = 1; i < run; i++)
                    {
                        startNumber += 1;
                        output[run, run - i] = startNumber;
                    }

                    printArray();
                }

                void fillFirstColumn()
                {
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
