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
  public class RangeCharacters
  {
    public void Run()
    {
      string num = "1234";
      int len = num.Length;

      for (int i = 0; i <= len; i++)
      {
        //Console.WriteLine($"{i} {num[..i]}");
        //Console.WriteLine($"{i} {num[i..]}");
        //Console.WriteLine($"^{i} {num[..^i]}");
        Console.WriteLine($"^{i} {num[^i..]}");
      }

      //string fileName = "myTestFileName.txt";

      //// First 8 Characters ..8
      //Console.WriteLine($"{fileName[0..8]}");
      //Console.WriteLine($"{fileName[..8]}");

      //Console.WriteLine($"{fileName[2..8]}");

      //// After first 3 char to end
      //Console.WriteLine($"{fileName[8..]}");

      //// Except last 4 Characters ..^4
      //Console.WriteLine($"{fileName[0..^4]}");
      ////Console.WriteLine($"{fileName[..^4]}");

      //// Last 3 Characters ^3..
      //Console.WriteLine($"{fileName[^3..^0]}");
      ////Console.WriteLine($"{fileName[^3..]}");

      //// Except start & end character
      //Console.WriteLine($"{fileName[1..^1]}");
    }
  }
}
