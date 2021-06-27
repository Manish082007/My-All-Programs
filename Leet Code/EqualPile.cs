using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ExceptionServices;

namespace All_Programs
{
  public class EqualPile
  {
    int[] _pile;

    public void Run()
    {
      Stopwatch stopwatch = new Stopwatch();
      stopwatch.Start();

      _pile = new int[] { 1, 1, 2, 2, 2, 3, 3, 3, 4, 4 };
      int steps = 0;

      if (_pile.Length <= 1)
      {
        stopwatch.Stop();
        Console.WriteLine($"Output is: {0} in {stopwatch.ElapsedMilliseconds}");
        return;
      }

      Array.Sort(_pile);
      Array.Reverse(_pile);

      while (!IsValidPile())
      {
        int max = _pile[0];
        int index = 1;

        while (max == _pile[index])
        {
          index++;
        }
        int secondMax = _pile[index];

        for (int i = 0; i < index; i++)
        {
          _pile[i] = secondMax;
          steps++;
        }
      }

      stopwatch.Stop();
      Console.WriteLine($"Output is: {steps} in {stopwatch.ElapsedMilliseconds}");
    }

    public bool IsValidPile()
    {
      return _pile.Distinct().Count() == 1 ? true : false;
    }

    public void SortDesc()
    {
      for (int i = 0; i < _pile.Length; i++)
      {
        for (int j = i + 1; j < _pile.Length; j++)
        {
          if (_pile[i] < _pile[j])
          {
            int temp = _pile[i];
            _pile[i] = _pile[j];
            _pile[j] = temp;
          }
        }
      }
    }
  }
}
