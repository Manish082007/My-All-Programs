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
  public class MinSplitForHexStrings
  {
    public void Run()
    {
      Stopwatch stopwatch = new Stopwatch();
      stopwatch.Start();

      //string hex = "1a919";
      string hex = "1931";
      int hexLen = hex.Length;
      int[] memo = new int[hexLen];

      int result = GetMinNumberOfPerfectSquare(0);

      int GetMinNumberOfPerfectSquare(int index)
      {
        if (index == hexLen)
        {
          return 0;
        }
        if (memo[index] != 0)
        {
          return memo[index];
        }

        int result = int.MaxValue;
        int dec = 0;
        for (int i = index; i < hexLen; i++)
        {
          dec = dec * 16 + int.Parse(hex.Substring(i, 1), NumberStyles.HexNumber);
          if (IsPerfectSquare(dec))
          {
            result = Math.Min(result, 1 + GetMinNumberOfPerfectSquare(i + 1));
          }
        }

        memo[index] = result;
        return result;
      }

      stopwatch.Stop();
      Console.WriteLine($"{Environment.NewLine}Output is: {result} in {stopwatch.ElapsedMilliseconds}");
    }

    private static bool IsPerfectSquare(int decimalNumber)
    {
      var number = Math.Sqrt(decimalNumber);
      return number % 1 == 0;
    }
  }
}
