using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace All_Programs
{
  public class InterLeavingStrings
  {
    public bool Run()
    {
      Stopwatch stopwatch = new Stopwatch();
      stopwatch.Start();

      string s1 = "aa";
      string s2 = "ab";
      string s3 = "aaba";

      if ((s1 == string.Empty && s2.Length > 0 && s3.Equals(s2)) || 
        (s2 == string.Empty && s1.Length > 0 && s3.Equals(s1)))
      {
        return true;
      }
      else if ((s1.Length + s2.Length) != s3.Length)
      {
        return false;
      }

      int s1Index = 0;
      int s2Index = 0;
      int s3Index = 0;
      
      int length = 1;
      string activeString = "s1";
      string currentString = s1;
      int currentIndex = s1Index;

      for (int i = 0; i < s3.Length; i++)
      {
        if ((currentIndex + length) <= currentString.Length &&
          (s3Index + length) <= s3.Length &&
          s3.Substring(s3Index, length) == currentString.Substring(currentIndex, length))
        {
          length++;
        }
        else
        {
          if (length == 1)
          {
            stopwatch.Stop();
            Console.WriteLine($"InterLeaving: {false} in {stopwatch.ElapsedMilliseconds}");
            return false;
          }
          else
          {
            s3Index = i;
            i--;
            
            if (activeString == "s1")
            {
              s1Index = s1Index + length - 1;

              currentString = s2;
              currentIndex = s2Index;
              activeString = "s2";
            }
            else
            {
              s2Index = s2Index + length - 1;

              currentString = s1;
              currentIndex = s1Index;
              activeString = "s1";
            }

            length = 1;
          }
        }
      }

      stopwatch.Stop();
      Console.WriteLine($"InterLeaving: {true} in {stopwatch.ElapsedMilliseconds}");

      return true;
    }
  }
}
