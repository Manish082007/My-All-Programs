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
  public class Permutations
  {
    public void Run()
    {
      Stopwatch stopwatch = new Stopwatch();
      stopwatch.Start();

      int[] nums = { 1, 2, 3 };

      int numsLen = nums.Length;
      IList<IList<int>> result = new List<IList<int>>();
      foreach (int num in nums)
      {
        FindPermutation(new List<int>() { num });
      }

      void FindPermutation(IEnumerable<int> array)
      {
        if (array.Count() == numsLen)
        {
          result.Add(array.ToArray());
          return;
        }
        else
        {
          foreach (int num in nums)
          {
            if (!array.Contains(num))
            {
              FindPermutation(array.Append(num));
            }
          }
        }
      }

      stopwatch.Stop();
      Console.WriteLine($"{Environment.NewLine}Output is: {result.Count} in {stopwatch.ElapsedMilliseconds}");
    }
  }
}
