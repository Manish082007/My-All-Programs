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
using System.Xml.Schema;

namespace All_Programs
{
  public class StoneGameVII
  {
    #region Not Working Approach
    public void Run()
    {
      Stopwatch stopwatch = new Stopwatch();
      stopwatch.Start();

      int[] stones = { 5, 3, 1, 4, 2 };
      int total = 0;
      foreach (int stone in stones)
      {
        total += stone;
      }

      int alice = 0, bob = 0, start = 0, end = stones.Length - 1;

      while (start < end)
      {
        if (stones[start] > stones[end])
        {
          total = total - stones[end];
          alice = alice + total;
          end--;
        }
        else
        {
          total = total - stones[start];
          alice = alice + total;
          start++;
        }

        if (stones[start] > stones[end])
        {
          total = total - stones[start];
          bob = bob + total;
          start++;
        }
        else
        {
          total = total - stones[end];
          bob = bob + total;
          end--;
        }
      }

      stopwatch.Stop();
      Console.WriteLine($"{Environment.NewLine}Output is: {alice - bob} in {stopwatch.ElapsedMilliseconds}");
    }

    int[,] memo;

    public void Run2()
    {
      Stopwatch stopwatch = new Stopwatch();
      stopwatch.Start();

      int[] stones = { 5, 3, 1, 4, 2 };
      int total = 0;
      foreach (int stone in stones)
      {
        total += stone;
      }
      int len = stones.Length;
      memo = new int[len, len];

      int result = GetMaxDiff(stones, 0, len - 1, total);

      stopwatch.Stop();
      Console.WriteLine($"{Environment.NewLine}Output is: {result} in {stopwatch.ElapsedMilliseconds}");
    }

    private int GetMaxDiff(int[] stones, int s, int e, int total)
    {
      if (s >= e)
      {
        return 0;
      }
      
      return Math.Max(
        total - stones[s] - GetMaxDiff(stones, s + 1, e, total - stones[s]),
        total - stones[e] - GetMaxDiff(stones, s, e - 1, total - stones[e])
      );
    }

    #endregion

    public void Run3()
    {
      Stopwatch stopwatch = new Stopwatch();
      stopwatch.Start();

      int[] stones = { 5, 3, 1, 4, 2 };

      int N = stones.Length;
      int[] dpCurr = new int[N], dpLast = new int[N];
      for (int i = N - 2; i >= 0; i--)
      {
        int total = stones[i];
        int[] temp = dpLast;
        dpLast = dpCurr;
        dpCurr = temp;

        for (int j = i + 1; j < N; j++)
        {
          total += stones[j];
          dpCurr[j] = Math.Max(total - stones[i] - dpLast[j], total - stones[j] - dpCurr[j - 1]);
        }
      }

      stopwatch.Stop();
      Console.WriteLine($"{Environment.NewLine}Output is: {dpCurr[N - 1]} in {stopwatch.ElapsedMilliseconds}");
    }
  }
}
