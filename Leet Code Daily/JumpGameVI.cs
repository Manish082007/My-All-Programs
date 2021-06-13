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
  public class JumpGameVI
  {
    #region Solution 1

    int[] _nums;
    int _k;
    int len;
    int[] memo;

    public void Run()
    {
      Stopwatch stopwatch = new Stopwatch();
      stopwatch.Start();

      int[] nums = { 1, -1, -2, 4, -7, 3 };
      int k = 2;

      _nums = nums;
      _k = k;
      len = nums.Length - 1;
      memo = Enumerable.Repeat(int.MinValue, len + 1).ToArray();
      memo[len] = _nums[len];

      int result = GetMaxResult(0);

      stopwatch.Stop();
      Console.WriteLine($"{Environment.NewLine}Output is: {result} in {stopwatch.ElapsedTicks}");
    }

    private int GetMaxResult(int index)
    {
      if (memo[index] != int.MinValue)
      {
        return memo[index];
      }
      for (int i = 1; i <= _k; i++)
      {
        if (index + i <= len)
        {
          memo[index] = Math.Max(memo[index], _nums[index] + GetMaxResult(index + i));
        }
      }

      return memo[index];
    }

    #endregion

    #region Solution 2

    public void Run2()
    {
      Stopwatch stopwatch = new Stopwatch();
      stopwatch.Start();

      int[] nums = { 1, -1, -2, 4, -7, 3 };
      int k = 2;
      int[] memo = Enumerable.Repeat(int.MinValue, nums.Length).ToArray();
      memo[0] = nums[0];

      for (int i = 0; i < nums.Length; i++)
      {
        for (int j = 1; j <= k && i - j >= 0; j++)
        {
          memo[i] = Math.Max(memo[i], nums[i] + memo[i - j]);
        }
      }

      stopwatch.Stop();
      Console.WriteLine($"{Environment.NewLine}Output is: {memo.Last()} in {stopwatch.ElapsedTicks}");
    }

    #endregion

    public void Run3()
    {
      Stopwatch stopwatch = new Stopwatch();
      stopwatch.Start();

      int[] nums = { 1, -1, -2, 4, -7, 3 };
      int k = 2;
      int len = nums.Length, a = 0, b = 0;
      int[] deq = new int[len];
      deq[0] = len - 1;

      for (int i = len - 2; i >= 0; i--)
      {
        if (deq[a] - i > k)
        {
          a++;
        }

        nums[i] += nums[deq[a]];

        while (b >= a && nums[deq[b]] <= nums[i])
        {
          b--;
        }

        deq[++b] = i;
      }

      stopwatch.Stop();
      Console.WriteLine($"{Environment.NewLine}Output is: {nums[0]} in {stopwatch.ElapsedTicks}");
    }


  }
}
