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
  public class LongestConsecutiveSequence
  {
    public void Run()
    {
      Stopwatch stopwatch = new Stopwatch();
      stopwatch.Start();

      int[] nums = { 0, 3, 7, 2, 5, 8, 4, 6, 0, 1 };

      if (nums.Length <= 1)
      {
        stopwatch.Stop();
        Console.WriteLine($"Output is: {nums.Length} in {stopwatch.ElapsedMilliseconds}");
        return;
      }

      Array.Sort(nums);

      int result = 1, seq = 1;

      for (int i = 0; i < nums.Length - 1; i++)
      {
        if (nums[i] == nums[i + 1])
        {
          continue;
        }
        else if (nums[i] + 1 == nums[i + 1])
        {
          seq++;
        }
        else
        {
          result = Math.Max(result, seq);
          seq = 1;
        }
      }

      stopwatch.Stop();
      Console.WriteLine($"Output is: {Math.Max(result, seq)} in {stopwatch.ElapsedMilliseconds}");
    }
  }
}
