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
  public class NQueen2
  {
    public void Run()
    {
      Stopwatch stopwatch = new Stopwatch();
      stopwatch.Start();

      int n = 4;
      int result = 0;
      int[,] board = new int[n,n];

      for (int i = 0; i < n; i++)
      {
        for (int row = 0; row < n; row++)
        {

        }
      }      

      stopwatch.Stop();
      Console.WriteLine($"{Environment.NewLine}Output is: {result} in {stopwatch.ElapsedTicks}");
    }
  }
}
