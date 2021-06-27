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
  public class NQueen2
  {
    public void Run()
    {
      Stopwatch stopwatch = new Stopwatch();
      stopwatch.Start();

      int n = 4;
      int result = 0;
      int[,] board = new int[n, n];
      Dictionary<int, int> positions = new Dictionary<int, int>();

      for (int startCol = 0; startCol < n; startCol++)
      {
        board[0, startCol] = 1;
        positions.Add(0, startCol);

        for (int i = 1; i < n; i++)
        {
          for (int row = i; row < n; row++)
          {
            bool isAssigned = false;
            for (int col = 0; col < n; col++)
            {
              if (col != startCol && IsValidPosition(row, col))
              {
                board[row, col] = 1;
                isAssigned = true;
                positions.Add(row, col);
                row = col = n;
              }
            }

            if (!isAssigned)
            {
              foreach (var pos in positions)
              {
                board[pos.Key, pos.Value] = 0;
              }
              positions = new Dictionary<int, int>();
              i = row = n;
            }
          }
        }

        if (positions.Count == n)
        {
          result++;
          foreach (var pos in positions)
          {
            board[pos.Key, pos.Value] = 0;
          }
          positions = new Dictionary<int, int>();
        }
      }

      bool IsValidPosition(int posRow, int posCol)
      {
        // Horizontal
        for (int col = 0; col < n; col++)
        {
          if (posRow == col)
          {
            continue;
          }
          else if (board[posRow, col] == 1)
          {
            return false;
          }
        }

        // Vertical
        for (int row = 0; row < n; row++)
        {
          if (posCol == row)
          {
            continue;
          }
          else if (board[row, posCol] == 1)
          {
            return false;
          }
        }

        // Backward Slash Up
        for (int i = 1; i < n; i++)
        {
          if (posRow - i >= 0 && posCol - i >= 0)
          {
            if (board[posRow - i, posCol - i] == 1)
            {
              return false;
            }
          }
          else
          {
            break;
          }
        }

        // Backward Slash Down
        for (int i = 1; i < n; i++)
        {
          if (posRow + i < n && posCol + i < n)
          {
            if (board[posRow + i, posCol + i] == 1)
            {
              return false;
            }
          }
          else
          {
            break;
          }
        }

        // Forward Slash Up
        for (int i = 1; i < n; i++)
        {
          if (posRow - i >= 0 && posCol + i < n)
          {
            if (board[posRow - i, posCol + i] == 1)
            {
              return false;
            }
          }
          else
          {
            break;
          }
        }

        // Forward Slash Down
        for (int i = 1; i < n; i++)
        {
          if (posRow + i < n && posCol - i >= 0)
          {
            if (board[posRow + i, posCol - i] == 1)
            {
              return false;
            }
          }
          else
          {
            break;
          }
        }

        return true;
      }

      stopwatch.Stop();
      Console.WriteLine($"{Environment.NewLine}Output is: {result} in {stopwatch.ElapsedMilliseconds}");
    }

    public void Run2()
    {
      Stopwatch stopwatch = new Stopwatch();
      stopwatch.Start();

      int n = 5;
      bool[,] board = new bool[n, n];

      int result = Check(0);

      int Check(int row)
      {
        if (row == n)
        {
          return 1;
        }

        int count = 0;
        for (int col = 0; col < n; col++)
        {
          if (row == 0 || IsSafePosition(row, col))
          {
            board[row, col] = true;
            count += Check(row + 1);
            board[row, col] = false;
          }
        }

        return count;
      }

      bool IsSafePosition(int posRow, int posCol)
      {
        for (int row = 0; row <= posRow; row++)
        {
          if (board[row, posCol])
          {
            return false;
          }
          if (posRow - row >= 0 && posCol - row >= 0 && board[posRow - row, posCol - row])
          {
            return false;
          }
          if (posRow - row >= 0 && posCol + row < n && board[posRow - row, posCol + row])
          {
            return false;
          }
        }

        return true;
      }

      stopwatch.Stop();
      Console.WriteLine($"{Environment.NewLine}Output is: {result} in {stopwatch.ElapsedMilliseconds}");
    }
  }
}
