using System;

namespace All_Programs
{
  public static class PrintDiamond
  {
    public static void Run()
    {
      bool validValue = false;
      int inputRows;
      do
      {
        Console.Write("Enter Number of Rows: ");
        _ = int.TryParse(Console.ReadLine(), out inputRows);

        if (inputRows < 0 || (inputRows % 2) == 0)
        {
          Console.WriteLine($"Diamond is only possible with positive ODD INT value.{Environment.NewLine}");
        }
        else
        {
          validValue = true;
        }
      } while (!validValue);

      int space = (inputRows / 2);
      int star = 1;
      for (int i = 0; i < inputRows; i++)
      {
        int rowSpace = space;
        for (int j = 0; j < space + star; j++)
        {
          if (rowSpace > 0)
          {
            Console.Write(" ");
            rowSpace--;
          }
          else
          {
            Console.Write("*");
          }
        }
        Console.WriteLine();

        if (i + 1 <= (inputRows / 2))
        {
          star += 2;
          space--;
        }
        else
        {
          space++;
          star -= 2;
        }
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
