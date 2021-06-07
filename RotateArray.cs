using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ExceptionServices;

namespace All_Programs
{
  public class RotateArray
  {
    public void Run()
    {
      Stopwatch stopwatch = new Stopwatch();
      stopwatch.Start();

      int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
      int d = 3;
      Console.WriteLine($"Input is: {string.Join(',', arr)}");

      int arrLen = arr.Length;
      int[] newArr = new int[arrLen];

      if (arrLen != 1 && arrLen != d)
      {
        for (int i = 0; i < arrLen; i++)
        {
          if (i - d < 0)
          {
            newArr[arrLen + i - d] = arr[i];
          }
          else
          {
            newArr[i - d] = arr[i];
          }
        }
      }
      stopwatch.Stop();
      Console.WriteLine($"Output is: {string.Join(',', newArr)} in {stopwatch.ElapsedMilliseconds}");
    }

    public void Run2()
    {
      Stopwatch stopwatch = new Stopwatch();
      stopwatch.Start();

      int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
      int d = 3;
      Console.WriteLine($"Input is: {string.Join(',', arr)}");

      int arrLen = arr.Length;

      if (d > arrLen)
      {
        d = d % arrLen;
      }

      if (arrLen != 1 && arrLen != d)
      {

        if (d > (arrLen / 2))
        {
          for (int j = 0; j < arrLen - d; j++)
          {
            RotateLeftByOne(arr, arrLen);
          }
        }
        else
        {
          for (int j = 0; j < d; j++)
          {
            RotateRightByOne(arr, arrLen);
          }
        }
      }

      stopwatch.Stop();
      Console.WriteLine($"Output is: {string.Join(',', arr)} in {stopwatch.ElapsedMilliseconds}");
    }

    private void RotateRightByOne(int[] arr, int arrLen)
    {
      int temp = arr[arrLen - 1];
      for (int i = arrLen - 1; i > 0; i--)
      {
        arr[i] = arr[i - 1];
      }
      arr[0] = temp;
    }

    private void RotateLeftByOne(int[] arr, int arrLen)
    {
      int temp = arr[0];
      for (int i = 0; i < arrLen - 1; i++)
      {
        arr[i] = arr[i + 1];
      }
      arr[arrLen - 1] = temp;
    }

    //
    // Rotate Right
    //
    public void Run3()
    {
      // Rotate Right
      Stopwatch stopwatch = new Stopwatch();
      stopwatch.Start();

      int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
      int d = 3;
      Console.WriteLine($"Input is: {string.Join(',', arr)}");

      int arrLen = arr.Length;
      d = d % arrLen;

      Reverse(arr, 0, arrLen - d - 1);
      Reverse(arr, arrLen - d, arrLen - 1);
      Reverse(arr, 0, arrLen - 1);

      stopwatch.Stop();
      Console.WriteLine($"Output is: {string.Join(',', arr)} in {stopwatch.ElapsedMilliseconds}");
    }

    //
    // Rotate Left
    //
    public void Run4()
    {
      // Rotate Left
      Stopwatch stopwatch = new Stopwatch();
      stopwatch.Start();

      int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
      int d = 3;
      Console.WriteLine($"Input is: {string.Join(',', arr)}");

      int arrLen = arr.Length;
      d = d % arrLen;

      Reverse(arr, 0, d - 1);
      Reverse(arr, d, arrLen - 1);
      Reverse(arr, 0, arrLen - 1);

      stopwatch.Stop();
      Console.WriteLine($"Output is: {string.Join(',', arr)} in {stopwatch.ElapsedMilliseconds}");
    }

    private void Reverse(int[] arr, int start, int end)
    {
      int temp;
      while(start < end)
      {
        temp = arr[start];
        arr[start] = arr[end];
        arr[end] = temp;
        start++;
        end--;
      }
    }
  }
}
