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
  public class PascalTriangle
  {
    public void Run()
    {
      Stopwatch stopwatch = new Stopwatch();
      stopwatch.Start();

      int n = 30;
      IList<IList<int>> list = new List<IList<int>>();
      list.Add(new int[] { 1 });
      int[] prevSubArray = new int[2] { 1, 1 };
      int start, end;

      for (int i = 1; i < n; i++)
      {
        int[] subArray = new int[i + 1];
        subArray[0] = subArray[i] = 1;
        subArray[1] = subArray[i - 1] = i;
        start = 2;
        end = i - 2;

        while (start <= end)
        {
          subArray[start] = subArray[end] = prevSubArray[start - 1] + prevSubArray[start];
          start++;
          end--;
        }

        prevSubArray = subArray;
        list.Add(subArray);
      }

      stopwatch.Stop();
      Console.WriteLine($"{Environment.NewLine}Output is: output in {stopwatch.ElapsedMilliseconds}");
    }
  }
}
