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
  public class NQueen
  {
    public void Run()
    {
      Stopwatch stopwatch = new Stopwatch();
      stopwatch.Start();

      int n = 5;
      string defaultRowString = GetDefaultRowString(n);
      IList<string> board = GetDefaultBoard(defaultRowString);
      IList<IList<string>> result = new List<IList<string>>();

      Check(0);

      void Check(int row)
      {
        if (row == n)
        {
          result.Add(new List<string>(board));
          return;
        }

        StringBuilder rowBuilder = new StringBuilder(defaultRowString);
        for (int col = 0; col < n; col++)
        {
          if (IsSafePosition(row, col))
          {
            rowBuilder[col] = 'Q';
            board[row] = rowBuilder.ToString();
            
            Check(row + 1);

            rowBuilder[col] = '.';
            board[row] = rowBuilder.ToString();
          }
        }
      }

      bool IsSafePosition(int posRow, int posCol)
      {
        for (int row = 0; row <= posRow; row++)
        {
          if (board[row][posCol] == 'Q')
          {
            return false;
          }
          if (posRow - row >= 0 && posCol - row >= 0 && board[posRow - row][posCol - row] == 'Q')
          {
            return false;
          }
          if (posRow - row >= 0 && posCol + row < n && board[posRow - row][posCol + row] == 'Q')
          {
            return false;
          }
        }

        return true;
      }

      IList<string> GetDefaultBoard(string defaultRowString)
      {
        IList<string> defaultBoard = new List<string>(n);
        for (int i = 0; i < n; i++)
        {
          defaultBoard.Add(defaultRowString);
        }

        return defaultBoard;
      }

      string GetDefaultRowString(int n)
      {
        StringBuilder builder = new StringBuilder();
        for (int i = 0; i < n; i++)
        {
          builder.Append('.');
        }
        return builder.ToString();
      }

      stopwatch.Stop();
      Console.WriteLine($"{Environment.NewLine}Output is: {result.Count} in {stopwatch.ElapsedMilliseconds}");
    }
  }
}
