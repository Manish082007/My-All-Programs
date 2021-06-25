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
using System.Runtime.ExceptionServices;

namespace All_Programs
{
  public class WordSearch
  {
    public bool Run()
    {
      Stopwatch stopwatch = new Stopwatch();
      stopwatch.Start();

      char[][] board = new char[][]
      {
        new char[] { 'A','B','C','E' },
        new char[] { 'S','F','E','S' },
        new char[] { 'A','D','E','E' }
      };
      string word = "ABCESEEEFS";

      int wordLength = word.Length;
      int maxRows = board.Length;
      int maxCols = board[0].Length;
      bool[,] visited = new bool[maxRows, maxCols];

      for (int i = 0; i < maxRows; i++)
      {
        for (int j = 0; j < maxCols; j++)
        {
          if (board[i][j] == word.First())
          {
            if (FindWord(i, j, 0))
            {
              stopwatch.Stop();
              Console.WriteLine($"{Environment.NewLine}Output is: true in {stopwatch.ElapsedTicks}");

              return true;
            }
          }
          else if (!word.Contains(board[i][j]))
          {
            visited[i, j] = true;
          }
        }
      }

      //bool FindWord(int row, int col, int index)
      //{
      //  if (row < 0 || row >= maxRows || col < 0 || col >= maxCols || visited[row, col])
      //  {
      //    return false;
      //  }
      //  else
      //  {
      //    char charToCheck = board[row][col];
      //    if (charToCheck == word[index])
      //    {
      //      if (index + 1 != wordLength)
      //      {
      //        board[row][col] = '*';

      //        bool result = FindWord(row - 1, col, index + 1) ||
      //              FindWord(row + 1, col, index + 1) ||
      //              FindWord(row, col - 1, index + 1) ||
      //              FindWord(row, col + 1, index + 1);

      //        board[row][col] = charToCheck;
      //        return result;
      //      }
      //      else
      //      {
      //        return true;
      //      }
      //    }
      //    else if (!word.Contains(charToCheck))
      //    {
      //      visited[row, col] = true;
      //    }
      //  }

      //  return false;
      //}

      bool FindWord(int row, int col, int index)
      {
        if (index == wordLength)
        {
          return true;
        }
        else if (row < 0 || row >= maxRows || col < 0 || col >= maxCols || visited[row, col] || board[row][col] != word[index])
        {
          return false;
        }
        else
        {
          char charToCheck = board[row][col];

          board[row][col] = '*';

          bool result = FindWord(row - 1, col, index + 1) ||
                FindWord(row + 1, col, index + 1) ||
                FindWord(row, col - 1, index + 1) ||
                FindWord(row, col + 1, index + 1);

          board[row][col] = charToCheck;

          return result;
        }
      }

      stopwatch.Stop();
      Console.WriteLine($"{Environment.NewLine}Output is: false in {stopwatch.ElapsedTicks}");

      return false;
    }
  }
}
