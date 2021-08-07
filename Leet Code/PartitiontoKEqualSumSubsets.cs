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
  public class PartitiontoKEqualSumSubsets
  {
    public bool Run()
    {
      Stopwatch stopwatch = new Stopwatch();
      stopwatch.Start();

      int[] nums = { 4, 3, 2, 3, 5, 2, 1 };
      int part = 4;
      bool[] visited = new bool[nums.Length];

      int total = 0;
      foreach(int num in nums)
      {
        total += num;
      }

      if (total % part != 0)
      {
        return false;
      }

      int targetNumber = total / part;

      bool PartitionSubset(int index, int currentNumber, int remainingPartition)
      {
        if (remainingPartition == 1)
        {
          return true;
        }

        if (currentNumber == targetNumber)
        {
          return PartitionSubset(0, 0, remainingPartition - 1);
        }

        for (int i = index; i < nums.Length; i++)
        {
          if (!visited[i] && currentNumber + nums[i] <= targetNumber)
          {
            visited[i] = true;
            if (PartitionSubset(i + 1, currentNumber + nums[i], remainingPartition))
            {
              return true;
            }
            visited[i] = false;
          }
        }

        return false; 
      }

      stopwatch.Stop();
      Console.WriteLine($"{Environment.NewLine}Output in {stopwatch.ElapsedMilliseconds}");

      return PartitionSubset(0, 0, part);
    }
  }
}
