using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace All_Programs
{
  public class CakeAreaAfterCut
  {
    int maxRows, maxCols;
    int[] hCuts, vCuts;
    bool[,] visited;

    public int Run()
    {
      //Stopwatch stopwatch = new Stopwatch();
      //stopwatch.Start();

      int h = 14;
      int w = 16;
      int[] horizontalCuts = { 6, 2 };
      int[] verticalCuts = { 10, 4, 5, 8 };

      //Array.Sort(horizontalCuts);
      //Array.Sort(verticalCuts);

      //int maxHCut = horizontalCuts.First(), maxVCut = verticalCuts.First(), prevHCut = maxHCut, prevVCut = maxVCut;
      //foreach(int hCut in horizontalCuts)
      //{
      //  maxHCut = Math.Max(maxHCut, hCut - prevHCut);
      //  prevHCut = hCut;
      //}
      //maxHCut = Math.Max(maxHCut, h - horizontalCuts.Last());

      //foreach (int vCut in verticalCuts)
      //{
      //  maxVCut = Math.Max(maxVCut, vCut - prevVCut);
      //  prevVCut = vCut;
      //}
      //maxVCut = Math.Max(maxVCut, w - verticalCuts.Last());

      Task<double> maxHCutd = GetMaxGap(h, horizontalCuts);
      Task<double> maxVCutd = GetMaxGap(w, verticalCuts);

      //int maxArea = (int)((Convert.ToDouble(maxHCut) * Convert.ToDouble(maxVCut)) % 1000000007);
      return (int)((maxHCutd.Result * maxVCutd.Result) % 1000000007);

      //stopwatch.Stop();
      //Console.WriteLine($"Output is: {maxArea} in {stopwatch.ElapsedMilliseconds}");
      //return maxArea;
    }

    private async Task<double> GetMaxGap(int len, int[] arr)
    {
      Array.Sort(arr);
      int maxCut = arr.First(), prevCut = maxCut;
      foreach (int cut in arr)
      {
        maxCut = Math.Max(maxCut, cut - prevCut);
        prevCut = cut;
      }
      double maxCutd = Math.Max(maxCut, len - arr.Last());
      return maxCutd;
    }
  }
}
