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
  public class GreyCode
  {
    public void Run()
    {
      Stopwatch stopwatch = new Stopwatch();
      stopwatch.Start();

      int n = 3;

      //var data1 = ReturnBinaryString(7);
      //var num1 = ReturnNumber(data1);
      //var data2 = ReturnBinaryString(8);
      //var num2 = ReturnNumber(data2);

      string fileName = "myTestFileName.txt";
      
      // First 8 Characters ..8
      Console.WriteLine($"{fileName[0..8]}");
      Console.WriteLine($"{fileName[..8]}");

      Console.WriteLine($"{fileName[2..8]}");

      // After first 3 char to end
      Console.WriteLine($"{fileName[8..]}");




      // Except last 4 Characters ..^4
      Console.WriteLine($"{fileName[0..^4]}");
      //Console.WriteLine($"{fileName[..^4]}");

      // Last 3 Characters ^3..
      Console.WriteLine($"{fileName[^3..^0]}");
      //Console.WriteLine($"{fileName[^3..]}");

      // Except start & end character
      Console.WriteLine($"{fileName[1..^1]}");
      


      stopwatch.Stop();
      Console.WriteLine($"{Environment.NewLine}Output is: output in {stopwatch.ElapsedTicks}");
    }

    private string ReturnBinaryString(int n)
    {
      if (n == 1)
      {
        return "1";
      }
      else
      {
        return ReturnBinaryString(n / 2) + (n % 2);
      }
    }

    private int ReturnNumber(string s)
    {
      if (s == "1")
      {
        return 1;
      }
      else
      {
        return ReturnNumber(s[0..^1]) * 2 + int.Parse(s.Last().ToString());
      }
    }
  }
}
