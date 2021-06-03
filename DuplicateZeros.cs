using System;
using System.Collections.Generic;

namespace All_Programs
{
  public static class DuplicateZeros
  {
    public static void Run()
    {
      int[] arr = { 1, 0, 2, 3, 0, 4, 5, 0 };
      printArray(arr);

      int arrayLength = arr.Length;
      for (int startIndex = 0; startIndex < arrayLength - 1; startIndex++)
      {
        if (arr[startIndex] == 0)
        {
          for (int endIndex = arrayLength - 1; endIndex > startIndex + 1; endIndex--)
          {
            arr[endIndex] = arr[endIndex - 1];
          }
          arr[startIndex + 1] = 0;
          startIndex++;
          printArray(arr);
        }
      }
    }

    private static void printArray(int[] arr)
    {
      Console.WriteLine("\n");
      for (int i = 0; i < arr.Length; i++)
      {
        Console.Write(arr[i] + " ");
      }
      Console.WriteLine("\n");
    }
  }
}
