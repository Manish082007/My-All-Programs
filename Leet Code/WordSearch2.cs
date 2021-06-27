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
using System.Runtime.ExceptionServices;

namespace All_Programs
{
  public class WordSearch2
  {
    public bool Run()
    {
      Stopwatch stopwatch = new Stopwatch();
      stopwatch.Start();

      char[][] board = new char[][]
      {
        new char[] { 'o', 'a', 'a', 'n' },
        new char[] { 'e', 't', 'a', 'e' },
        new char[] { 'i', 'h', 'k', 'r' },
        new char[] { 'i', 'f', 'l', 'v' }
      };
      string[] words = new string[] { "oath", "pea", "eat", "rain" };

      int wordLength = 0;
      int maxRows = board.Length;
      int maxCols = board[0].Length;
      bool[,] visited = new bool[maxRows, maxCols];
      IList<string> result = new List<string>();

      
      stopwatch.Stop();
      Console.WriteLine($"{Environment.NewLine}Output is: false in {stopwatch.ElapsedMilliseconds}");

      return false;
    }
  }
}
