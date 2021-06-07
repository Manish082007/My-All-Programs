using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace All_Programs
{
  public class MaxIslandArea
  {
    //List<Array> oneList = new List<Array>();
    //Dictionary<string, Array> oneDic = new Dictionary<string, Array>();
    //HashSet<Array> oneSet = new HashSet<Array>();
    bool[,] visited;
    int maxRow;
    int maxCol;
    int[][] _grid;

    //public class Array
    //{
    //  public int Row { get; set; }

    //  public int Col { get; set; }

    //  public override int GetHashCode()
    //  {
    //    return Convert.ToInt32($"1{Row}{Col}");
    //  }

    //  //public override string ToString()
    //  //{
    //  //  return $"{Row}{Col}";
    //  //}
    //}

    public void Run()
    {
      Stopwatch stopwatch = new Stopwatch();
      stopwatch.Start();
      
      _grid = new int[][]
      {new int[] {1,1,0,0,1,0,1,1,1,1,1,0,0,0,1,1,0,1,0,1,1,1,1,0,0}, new int[] {0,0,0,1,0,1,0,1,1,0,0,0,0,1,0,1,1,1,1,0,1,0,0,0,1}, new int[] {1,0,1,0,1,1,0,0,1,1,1,0,0,0,1,0,0,1,1,1,1,1,1,0,1}, new int[] {0,0,1,1,0,1,1,0,1,0,0,0,0,0,0,0,1,0,1,0,1,0,0,1,1}, new int[] {1,1,0,1,1,1,1,1,0,0,1,0,0,1,1,1,1,1,1,0,0,0,0,0,1}, new int[] {0,1,0,1,0,0,1,1,0,1,0,0,0,0,0,0,0,0,0,1,0,1,1,1,1}, new int[] {1,1,1,1,0,0,0,1,0,0,1,0,0,1,0,1,1,1,1,1,0,0,0,0,0}, new int[] {0,1,1,1,1,1,0,1,0,0,0,1,0,1,1,1,0,0,1,0,0,0,0,1,1}, new int[] {1,1,0,0,1,1,0,1,0,1,1,0,0,0,0,1,1,1,1,0,1,1,0,0,0}, new int[] {0,1,1,1,1,0,1,1,0,1,1,0,1,1,0,1,0,0,0,0,1,0,1,1,1}, new int[] {0,1,1,1,0,1,0,0,0,0,0,1,0,1,0,1,0,0,0,0,0,0,0,1,0}, new int[] {1,0,0,1,0,1,1,1,1,1,1,1,1,1,0,0,1,1,1,1,1,0,1,1,1}, new int[] {1,1,1,1,1,1,1,1,0,0,1,1,0,1,1,1,1,1,0,1,1,0,1,1,1}, new int[] {1,1,1,0,1,0,1,1,1,1,1,1,0,1,1,0,1,0,1,1,1,0,0,1,1}, new int[] {0,0,0,1,1,0,1,1,1,0,1,1,1,1,1,1,0,1,1,0,0,0,0,1,0}, new int[] {0,0,1,0,0,1,0,1,1,1,1,0,1,0,0,0,1,0,1,1,1,1,1,1,1}, new int[] {0,0,1,1,1,1,0,1,1,0,0,1,1,1,0,0,1,0,1,0,1,1,0,1,1}, new int[] {1,0,0,1,0,1,0,0,1,1,1,1,0,0,0,1,0,1,0,1,1,1,0,1,1}, new int[] {0,0,0,0,1,0,0,1,0,1,0,0,0,1,1,1,0,1,0,0,0,1,0,0,0}, new int[] {1,1,1,1,0,0,0,0,0,1,0,0,0,0,0,1,1,0,1,1,1,0,0,0,1}, new int[] {1,0,0,1,1,1,1,1,1,1,0,1,0,0,1,1,1,1,1,1,0,1,0,1,1}, new int[] {1,1,0,0,0,0,0,0,1,0,1,0,1,0,0,1,0,1,0,1,0,0,0,0,0}, new int[] {1,0,0,0,0,1,1,0,1,1,0,1,0,1,0,1,1,1,0,1,0,1,0,0,0}, new int[] {0,1,1,0,1,1,0,1,0,1,0,1,1,1,1,1,0,1,0,0,1,1,0,1,1}, new int[] {1,1,0,1,1,0,1,1,1,0,1,0,1,0,0,1,0,1,0,0,0,1,0,0,0}, new int[] {0,1,0,0,1,0,0,0,0,0,0,1,0,1,1,0,1,1,0,1,1,1,0,0,0}, new int[] {0,1,1,1,1,0,0,0,0,0,1,0,1,0,1,0,1,0,1,0,1,1,1,0,1}, new int[] {1,0,0,1,1,1,0,0,0,1,0,1,0,0,0,0,0,0,1,1,0,0,0,0,0}, new int[] {1,0,0,0,1,0,1,0,0,0,0,1,0,0,0,0,1,1,1,0,1,0,0,0,0}, new int[] {0,0,0,1,0,1,0,1,1,1,0,1,1,1,0,1,1,1,0,1,0,0,1,1,0}, new int[] {1,0,1,1,1,0,1,1,1,0,1,1,1,0,0,0,0,0,1,1,0,0,1,0,1}, new int[] {0,1,1,0,0,0,0,1,0,1,0,0,1,0,1,1,1,1,0,0,0,1,1,0,0}, new int[] {0,1,0,0,1,1,0,1,1,0,1,0,1,0,0,0,0,1,1,0,0,1,1,1,1}, new int[] {0,0,1,0,1,1,1,1,0,1,1,1,0,1,0,1,1,1,1,1,1,1,1,0,0}, new int[] {1,0,1,0,1,1,0,1,1,0,0,0,1,1,1,1,1,1,1,0,1,1,1,1,1}, new int[] {1,0,1,0,1,1,1,0,1,0,1,0,1,1,0,0,1,1,0,0,1,1,0,0,1}, new int[] {0,1,0,0,0,1,0,1,1,1,1,1,0,0,0,1,0,0,0,0,1,0,1,0,1}, new int[] {0,0,1,0,1,0,1,1,0,0,0,0,0,0,0,0,1,0,0,1,1,1,0,0,1}, new int[] {1,1,0,1,0,0,1,1,0,0,1,1,1,0,0,1,1,1,1,0,0,0,0,1,0}, new int[] {1,0,0,0,0,0,0,1,0,0,0,1,0,1,0,1,0,1,1,1,0,0,0,0,0}, new int[] {1,0,0,0,1,0,0,1,0,0,0,0,1,1,1,1,1,1,0,0,1,0,0,0,1}, new int[] {0,1,0,1,0,1,1,0,0,1,1,1,0,1,0,0,0,1,1,0,0,1,1,1,0}, new int[] {1,1,1,1,0,1,0,0,1,0,1,1,0,0,1,1,0,1,0,1,0,0,1,0,1}, new int[] {1,0,0,1,0,1,0,1,0,0,1,0,1,0,0,0,1,1,0,1,1,1,0,0,0}, new int[] {1,1,1,0,1,0,0,0,1,1,1,0,0,0,0,0,0,0,1,0,0,0,0,0,0}, new int[] {1,1,1,0,0,0,1,0,0,1,0,1,1,0,1,1,1,1,0,0,1,1,0,0,1}, new int[] {0,1,1,0,1,0,0,1,0,0,0,0,1,0,1,1,1,1,1,0,1,1,1,0,1}, new int[] {0,1,1,1,1,1,1,1,1,1,0,1,0,0,1,1,1,0,0,0,0,1,1,0,1}, new int[] {0,0,1,0,1,1,0,0,1,1,1,0,1,0,0,0,1,0,1,0,1,0,1,1,0}, new int[] {1,0,0,1,1,0,1,0,0,1,0,0,1,1,0,1,0,0,1,0,0,1,0,1,0}};
      
      maxRow = _grid.Length;
      maxCol = _grid[0].Length;
      int maxArea = 0;
      visited = new bool[maxRow, maxCol];

      for (int row = 0; row < maxRow; row++)
      {
        for (int col = 0; col < maxCol; col++)
        {
          //if (!oneList.Any(l => l.Row == row && l.Col == col))
          //if (!oneDic.ContainsKey($"{row}{col}"))
          //if (!oneSet.Any(l => l.Row == row && l.Col == col))
          if (!visited[row,col])
          {
            maxArea = Math.Max(maxArea, GetArea(row, col));
          }
        }
      }

      stopwatch.Stop();
      Console.WriteLine($"Max Island Area: {maxArea} in {stopwatch.ElapsedMilliseconds}");
    }

    public int GetArea(int row, int col)
    {
      if (row < 0 || row >= maxRow || col < 0 || col >= maxCol || _grid[row][col] == 0 || visited[row, col])
      {
        return 0;
      }
      else
      {
        //Array array = new Array() { Row = row, Col = col };
        //oneDic.Add(array.ToString(), array);

        //oneList.Add(new Array() { Row = row, Col = col });

        //oneSet.Add(new Array() { Row = row, Col = col });

        visited[row, col] = true;

        return 1
          + GetArea(row - 1, col) // Top
          + GetArea(row + 1, col) // Bottom
          + GetArea(row, col - 1) // Left
          + GetArea(row, col + 1); // Right
      }
    }
  }
}
