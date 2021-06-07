using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace All_Programs
{
  public class MaximumPerformance
  {
    public void Run()
    {
      Stopwatch stopwatch = new Stopwatch();
      stopwatch.Start();

      int n = 6;
      int[] speed = { 2, 10, 3, 1, 5, 8 };
      int[] efficiency = { 5, 4, 3, 9, 7, 2 };
      int k = 2;

      int maxPerformance = 0;




      stopwatch.Stop();
      Console.WriteLine($"Output is: {maxPerformance} in {stopwatch.ElapsedMilliseconds}");
    }
  }
}
