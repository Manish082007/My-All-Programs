using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;

namespace All_Programs
{
  public class RotateImage
  {
    public void Run()
    {
      Stopwatch stopwatch = new Stopwatch();
      stopwatch.Start();

      int[][] matrix = new int[][]
      {
        new int[] { 5, 1, 9, 11 },
        new int[] { 2, 4, 8, 10 },
        new int[] { 13, 3, 6, 7 },
        new int[] { 15, 14, 12, 16 }
      };
      
      printArray(matrix);

      int top = 0, bottom = matrix.Length - 1;

      while (top < bottom)
      {
        for (int i = 0; i < matrix[top].Length; i++)
        {
          int temp = matrix[top][i];
          matrix[top][i] = matrix[bottom][i];
          matrix[bottom][i] = temp;
        }

        top++;
        bottom--;
      }

      printArray(matrix);

      for (int i = 0; i < matrix.Length; i++)
      {
        for (int j = i + 1; j < matrix[i].Length; j++)
        {
            int temp = matrix[i][j];
            matrix[i][j] = matrix[j][i];
            matrix[j][i] = temp;
        }
      }

      printArray(matrix);

      stopwatch.Stop();
      Console.WriteLine($"{Environment.NewLine}Output is: output in {stopwatch.ElapsedMilliseconds}");
    }

    private static void printArray(int[][] arr)
    {
      Console.WriteLine("\n");
      for (int i = 0; i < arr.Length; i++)
      {
        for (int j = 0; j < arr[i].Length; j++)
        {
          Console.Write((arr[i][j] <= 9 ? ("0" + arr[i][j]) : arr[i][j]) + " ");
        }
        Console.WriteLine("\n");
      }
      Console.WriteLine("\n");
    }
  }
}
