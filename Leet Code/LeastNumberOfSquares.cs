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
using System.Numerics;

namespace All_Programs
{
  public class LeastNumberOfSquares
  {
    public void Run()
    {
      Stopwatch stopwatch = new Stopwatch();
      stopwatch.Start();

      int n = 12;
      
      int[] dp = new int[n + 1];
      Array.Fill(dp, int.MaxValue);
      dp[0] = 0;

      for (int i = 1; i <= n; ++i)
      {
        int min = int.MaxValue;
        int j = 1;
        while (i - j * j >= 0)
        {
          min = Math.Min(min, dp[i - j * j] + 1);
          j++;
        }
        dp[i] = min;
      }
      
      //return dp[n];

      stopwatch.Stop();
      Console.WriteLine($"{Environment.NewLine}Output is: {dp[n]} in {stopwatch.ElapsedTicks}");
    }
  }
}
