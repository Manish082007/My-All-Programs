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
  public class MaxConsecutiveOnes3
  {
    public void Run()
    {
      Stopwatch stopwatch = new Stopwatch();
      stopwatch.Start();

      int[] nums = { 0, 0, 1, 1, 0, 0, 1, 1, 1, 0, 1, 1, 0, 0, 0, 1, 1, 1, 1 };
      int k = 3;
      List<int> zeros = new List<int>();
      int max = 0, lastOneIndex = 0;

      for (int i = 0; i < nums.Length; i++)
      {
        if (nums[i] == 0)
        {
          zeros.Add(i);
        }
        else
        {
          lastOneIndex = i;
        }
      }

      for (int i = 0; i + k <= zeros.Count; i++)
      {
        int start = i == 0 ? 0 : zeros.ElementAt(i - 1) + 1;
        int end = i + k == zeros.Count ? lastOneIndex : zeros.ElementAt(i + k);
        max = Math.Max(max, end - start);
      }

      stopwatch.Stop();
      Console.WriteLine($"{Environment.NewLine}Output is: {max} in {stopwatch.ElapsedMilliseconds}");
    }
  }
}
