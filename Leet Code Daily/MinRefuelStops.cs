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
  public class MinRefuelStops
  {
    public void Run()
    {
      Stopwatch stopwatch = new Stopwatch();
      stopwatch.Start();

      int target = 100;
      int startFuel = 10;
      int[][] stations = new int[][]
      {
        new int [] { 10, 60 },
        new int [] { 20, 30 },
        new int [] { 30, 30 },
        new int [] { 60, 40 }
      };

      int result;
      if (startFuel == target)
      {
        result = 0;
      }
      else if (startFuel < stations[0][0])
      {
        result = -1;
      }
      else
      {
        result = 0;
      }

      stopwatch.Stop();
      Console.WriteLine($"{Environment.NewLine}Output is: {result} in {stopwatch.ElapsedTicks}");
    }
  }
}
