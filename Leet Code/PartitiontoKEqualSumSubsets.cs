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
  public class PartitiontoKEqualSumSubsets
  {
    public bool Run()
    {
      Stopwatch stopwatch = new Stopwatch();
      stopwatch.Start();

      int[] nums = { 4, 3, 2, 3, 5, 2, 1 };
      int part = 4;
      
      int total = 0;
      foreach(int num in nums)
      {
        total += num;
      }

      if (total % part == 0)
      {
        return false;
      }




      stopwatch.Stop();
      Console.WriteLine($"{Environment.NewLine}Output is: output in {stopwatch.ElapsedMilliseconds}");
    }
  }
}
