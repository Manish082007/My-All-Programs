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
  public class MaximumUnitsOnTruck
  {
    class Box
    {
      public int numberOfBoxes { get; set; }
      public int numberOfUnitsPerBox { get; set; }
      public int totalUnits { get { return numberOfBoxes * numberOfUnitsPerBox; } }
    }

    class CompareByNumberOfUnits : IComparer<Box>
    {
      public int Compare(Box box1, Box box2)
      {
        if (box1.numberOfUnitsPerBox > box2.numberOfUnitsPerBox)
        {
          return -1;
        }
        else if (box1.numberOfUnitsPerBox < box2.numberOfUnitsPerBox)
        {
          return 1;
        }
        else
        {
          return 0;
        }
      }
    }

    public void Run()
    {
      Stopwatch stopwatch = new Stopwatch();
      stopwatch.Start();

      int[][] boxTypes = new int[][]
      {
        new int[] { 5, 10 },
        new int[] { 2, 5 },
        new int[] { 4, 7 },
        new int[] { 3, 9 } 
      };
      
      int truckSize = 10;

      List<Box> boxes = new List<Box>();
      foreach (var boxType in boxTypes)
      {
        boxes.Add(new Box() { numberOfBoxes = boxType[0], numberOfUnitsPerBox = boxType[1] });
      }

      boxes.Sort(new CompareByNumberOfUnits());

      int maxUnits = 0;
      foreach (Box box in boxes)
      {
        if (truckSize >= box.numberOfBoxes)
        {
          maxUnits += box.totalUnits;
          truckSize -= box.numberOfBoxes;
        }
        else
        {
          maxUnits += (truckSize * box.numberOfUnitsPerBox);
          break;
        }
      }

      stopwatch.Stop();
      Console.WriteLine($"{Environment.NewLine}Output is: {maxUnits} in {stopwatch.ElapsedTicks}");
    }
  }
}
