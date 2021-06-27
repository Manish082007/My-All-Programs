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
  public class MaxUniqueSplitString
  {
    public void Run()
    {
      Stopwatch stopwatch = new Stopwatch();
      stopwatch.Start();

      //string str = "wwwzfvedwfvhsww";
      string str = "ababccc";
      HashSet<string> set = new HashSet<string>();

      int maxSplit = maxUnique(str);

      int maxUnique(string s)
      {
        // Stores maximum count of unique substring
        // by splitting the string into substrings
        int max = 0;

        // Iterate over the characters of the string
        for (int i = 1; i <= s.Length; i++)
        {
          // Stores prefix substring
          String tmp = s.Substring(0, i);

          // Check if the current substring
          // already exists
          if (!set.Contains(tmp))
          {
            // Insert tmp into set
            set.Add(tmp);

            // Recursively call for remaining
            // characters of string
            max = Math.Max(max, maxUnique(s.Substring(i)) + 1);

            // Remove from the set
            set.Remove(tmp);
          }
        }

        // Return answer
        return max;
      }

      stopwatch.Stop();
      Console.WriteLine($"{Environment.NewLine}Output is: {maxSplit} in {stopwatch.ElapsedMilliseconds}");
    }
  }
}
