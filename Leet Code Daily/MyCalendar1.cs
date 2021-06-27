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
  public class MyCalendar1
  {
    class Interval
    {
      public int Start { get; set; }

      public int End { get; set; }
    }

    public class MyCalendar
    {
      List<Interval> bookings;
      //SortedDictionary<int, int> bookings;

      public MyCalendar()
      {
        bookings = new List<Interval>();
        //bookings = new SortedDictionary<int, int>();
      }

      public bool Book(int start, int end)
      {
        foreach (var booking in bookings)
        {
          if (end <= booking.Start || booking.End <= start)
          {
            return false;
          }
        }

        bookings.Add(new Interval() { Start = start, End = end });
        //bookings.Add(new Interval() { Start = start, End = end });
        return true;
      }
    }

    public void Run()
    {
      Stopwatch stopwatch = new Stopwatch();
      stopwatch.Start();

      MyCalendar myCalendar = new();
      Console.WriteLine(myCalendar.Book(10, 20)); // T
      Console.WriteLine(myCalendar.Book(15, 25)); // F
      Console.WriteLine(myCalendar.Book(20, 30)); // T
      Console.WriteLine(myCalendar.Book(5, 15));  // F
      Console.WriteLine(myCalendar.Book(15, 18)); // F
      Console.WriteLine(myCalendar.Book(10, 20)); // F
      Console.WriteLine(myCalendar.Book(5, 20));  // F

      myCalendar = new();
      Console.WriteLine(myCalendar.Book(97, 100)); // T
      Console.WriteLine(myCalendar.Book(33, 51));  // T
      Console.WriteLine(myCalendar.Book(89, 100)); // F
      Console.WriteLine(myCalendar.Book(83, 100)); // F
      Console.WriteLine(myCalendar.Book(75, 92));  // F
      Console.WriteLine(myCalendar.Book(76, 95));  // F
      Console.WriteLine(myCalendar.Book(19, 30));  // T
      Console.WriteLine(myCalendar.Book(53, 63));  // F
      Console.WriteLine(myCalendar.Book(8, 23));   // F
      Console.WriteLine(myCalendar.Book(18, 37));  // F
      Console.WriteLine(myCalendar.Book(87, 100)); // F
      Console.WriteLine(myCalendar.Book(83, 100)); // F
      Console.WriteLine(myCalendar.Book(54, 67));  // F
      Console.WriteLine(myCalendar.Book(35, 48));  // F
      Console.WriteLine(myCalendar.Book(58, 75));  // F
      Console.WriteLine(myCalendar.Book(70, 89));  // F
      Console.WriteLine(myCalendar.Book(13, 32));  // F
      Console.WriteLine(myCalendar.Book(44, 63));  // F
      Console.WriteLine(myCalendar.Book(51, 62));  // F
      Console.WriteLine(myCalendar.Book(2, 15));   // F

      myCalendar = new();
      int[][] arr = new int[][]
      {
        new int[] {47,50},
        new int[] {33,41},
        new int[] {39,45},
        new int[] {33,42},
        new int[] {25,32},
        new int[] {26,35},
        new int[] {19,25},
        new int[] {3,8},
        new int[] {8,13},
        new int[] {18,27}
      };

      foreach (var a in arr)
      {
        Console.WriteLine(myCalendar.Book(a[0], a[1]));
      }

      stopwatch.Stop();
      Console.WriteLine($"{Environment.NewLine}Output is: output in {stopwatch.ElapsedMilliseconds}");
    }
  }
}
