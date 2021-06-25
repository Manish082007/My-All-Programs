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
  public class MatchstickstoSquare
  {
    public void Run()
    {
      Stopwatch stopwatch = new Stopwatch();
      stopwatch.Start();

      int[] matchSticks = { 1, 1, 1, 2, 2, 2, 3, 4 };
      //int[] matchsticks = { 1, 2, 2, 2, 3, 3, 3, 4 };

      bool result = false;

      int total = 0;
      for (int i = 0; i < matchSticks.Length; i++)
      {
        total += matchSticks[i];
      }

      if (total % 4 == 0)
      {
        Array.Sort(matchSticks);
        int onesideBorderLength = total / 4;

        result = DFS(matchSticks.Length - 1, onesideBorderLength, onesideBorderLength, onesideBorderLength, onesideBorderLength);
      }

      bool DFS(int len, int s1, int s2, int s3, int s4)
      {
        if (s1 == 0 && s2 == 0 && s3 == 0 && s4 == 0)
        {
          return true;
        }
        if (s1 < 0 || s2 < 0 || s3 < 0 || s4 < 0 || len < 0)
        {
          return false;
        }

        return 
          DFS(len - 1, s1 - matchSticks[len], s2, s3, s4) ||
          DFS(len - 1, s1, s2 - matchSticks[len], s3, s4) ||
          DFS(len - 1, s1, s2, s3 - matchSticks[len], s4) ||
          DFS(len - 1, s1, s2, s3, s4 - matchSticks[len]);
      }

      stopwatch.Stop();
      Console.WriteLine($"{Environment.NewLine}Output is: {result} in {stopwatch.ElapsedTicks}");
    }
  }
}
