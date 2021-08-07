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
  public class JumpGame
  {
    public bool Run()
    {
      Stopwatch stopwatch = new Stopwatch();
      stopwatch.Start();

      int[] nums = { 3, 2, 1, 0, 4 };//{ 2, 1, 3, 1, 4, 0 };
      int targetIndex = nums.Length - 1;
      bool[] deadEnds = new bool[nums.Length];

      bool CalculateJump(int startIndex, int endIndex = 0)
      {
        if (deadEnds[startIndex])
        {
          return false;
        }
        Console.WriteLine($"Visited for startIndex {startIndex} with endIndex {endIndex}");

        if (startIndex == targetIndex || endIndex == targetIndex)
        {
          return true;
        }

        for (int i = startIndex + 1; i <= startIndex + nums[startIndex]; i++)
        {
          if (CalculateJump(i, startIndex + nums[startIndex]))
          {
            return true;
          }
        }

        Console.WriteLine($"False for startIndex {startIndex} with endIndex {endIndex}");
        deadEnds[startIndex] = true;
        return false;
      }

      stopwatch.Stop();
      Console.WriteLine($"{Environment.NewLine}Output is: output in {stopwatch.ElapsedMilliseconds}");

      return CalculateJump(0);
    }
  }
}
