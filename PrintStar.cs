using System;

namespace All_Programs
{
  public static class PrintStar
  {
    public static void Run()
    {
      bool validValue = false;
      int inputRows;
      do
      {
        Console.Write("Enter Number of Rows: ");
        _ = int.TryParse(Console.ReadLine(), out inputRows);

        if (inputRows < 0)
        {
          Console.WriteLine($"Please input only positive INT value.{Environment.NewLine}");
        }
        else
        {
          validValue = true;
        }
      } while (!validValue);

      for (int i = 0; i < inputRows; i++)
      {
        int space = inputRows - i - 1;
        // Print 0 inputNumber - i times
        // Print * remaining

        for (int j = 0; j < inputRows + i; j++)
        {
          if (space > 0)
          {
            Console.Write(" ");
            space--;
          }
          else
          {
            Console.Write("*");
          }
        }
        Console.WriteLine();
      }
    }

    //private static void printArray(int[] arr)
    //{
    //  Console.WriteLine("\n");
    //  for (int i = 0; i < arr.Length; i++)
    //  {
    //    Console.Write(arr[i] + " ");
    //  }
    //  Console.WriteLine("\n");
    //}
  }
}
