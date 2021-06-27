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
  public class CountofSmallerNumbersAfterSelf
  {
    public void Run()
    {
      Stopwatch stopwatch = new Stopwatch();
      stopwatch.Start();

      int[] nums = { 5, 2, 6, 3, 8, -5 };
      int[] result = new int[nums.Length];

      for (int i = nums.Length - 2; i >= 0; i--)
      {
        int count = 0, elementToCheck = nums[i];
        for (int j = i + 1; j < nums.Length; j++)
        {
          if (elementToCheck > nums[j])
          {
            count++;
          }
        }
        result[i] = count;
      }

      stopwatch.Stop();
      Console.WriteLine($"{Environment.NewLine}Output is: {string.Join(",", result)} in {stopwatch.ElapsedMilliseconds}");
    }
  }
}
