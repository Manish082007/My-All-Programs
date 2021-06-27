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
  public class MaximumLengthofConcatenatedStringwithUniqueCharacters
  {
    public void Run()
    {
      Stopwatch stopwatch = new Stopwatch();
      stopwatch.Start();

      string[] arr = { "cha", "r", "act", "ersz" };
      int arrLen = arr.Length;
      int maxLength = 0;

      FindMaxString(0, string.Empty);

      void FindMaxString(int index, string stringToCheck)
      {
        if (IsUniqueString(stringToCheck))
        {
          //Console.WriteLine(stringToCheck);
          maxLength = Math.Max(maxLength, stringToCheck.Length);
        }
        else
        {
          return;
        }

        if (index == arrLen)
        {
          Console.WriteLine($"End{Environment.NewLine}");
          return;
        }

        for (int i = index; i < arrLen; i++)
        {
          Console.WriteLine(stringToCheck + arr[i]);
          FindMaxString(i + 1, stringToCheck + arr[i]);
        }
      }

      bool IsUniqueString(string stringToCheck)
      {
        char[] charArray = new char[stringToCheck.Length];

        int i = 0;
        foreach (char strChar in stringToCheck)
        {
          if (charArray.Contains(strChar))
          {
            return false;
          }
          charArray[i++] = strChar;
        }

        return true;
      }

      stopwatch.Stop();
      Console.WriteLine($"{Environment.NewLine}Output is: {maxLength} in {stopwatch.ElapsedMilliseconds}");
    }


  }
}
