using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace All_Programs
{
  public class ArrayManipulation
  {
    public long Run()
    {
      Stopwatch stopwatch = new Stopwatch();
      stopwatch.Start();

      int n = 10;
      int[][] queries = new int[][] 
      { 
        new int[] { 2, 6, 8 },
        new int[] { 3, 5, 7 },
        new int[] { 1, 8, 1 },
        new int[] { 5, 9, 15 }
      };

      Dictionary<int, long> dic = new Dictionary<int, long>();

      foreach (int[] query in queries)
      {
        int start = query[0];
        int end = query[1];
        int value = query[2];

        if (dic.ContainsKey(start))
        {
          dic[start] += value;
        }
        else
        {
          dic.Add(start, value);
        }

        if (dic.ContainsKey(end + 1))
        {
          dic[end + 1] -= value;
        }
        else
        {
          dic.Add(end + 1, 0 - value);
        }
      }

      long result = long.MinValue;
      long temp = 0;
      for (int i = 0; i < n; i++)
      {
        temp += (dic.ContainsKey(i + 1) ? dic[i + 1] : 0);
        result = Math.Max(result, temp);
      }

      stopwatch.Stop();
      Console.WriteLine($"Output is: {result} in {stopwatch.ElapsedMilliseconds}");
      return result;
    }
  }
}
