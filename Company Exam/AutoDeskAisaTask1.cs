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
  public class AutoDeskAisaTask1
  {
    public void Run()
    {
      Stopwatch stopwatch = new Stopwatch();
      stopwatch.Start();

      int[] numArray = new int[] { };
      numArray[0] = 1;
      numArray[1] = 2;

      stopwatch.Stop();
      Console.WriteLine($"{Environment.NewLine}Output is: output in {stopwatch.ElapsedMilliseconds}");
    }
  }
}
