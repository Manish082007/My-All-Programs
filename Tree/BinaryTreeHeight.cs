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
  public class BinaryTreeHeight
  {
    class Node
    {
      public int key;
      public Node left, right;

      public Node(int item)
      {
        key = item;
        left = right = null;
      }
    }

    public void Run()
    {
      Stopwatch stopwatch = new Stopwatch();
      stopwatch.Start();

      Node root = new Node(1);
      root.left = new Node(2);
      root.right = new Node(2);
      root.left.left = new Node(3);
      root.left.right = new Node(4);
      root.right.left = new Node(4);
      root.right.right = new Node(3);
      root.right.right.right = new Node(3);

      //int height = GetHeight(root, 0) - 1;
      int height = GetHeight2(root);

      stopwatch.Stop();
      Console.WriteLine($"{Environment.NewLine}Output is {height}: in {stopwatch.ElapsedMilliseconds}");
    }

    private int GetHeight(Node root, int level)
    {
      if (root == null)
      {
        return level;
      }

      level += 1;

      return Math.Max(GetHeight(root.left, level), GetHeight(root.right, level));
    }

    private int GetHeight2(Node root)
    {
      if (root == null)
      {
        return 0;
      }

      int leftHeight = GetHeight2(root.left);
      int rightHeight = GetHeight2(root.right);

      if (leftHeight > rightHeight)
      {
        return leftHeight + 1;
      }
      else
      {
        return rightHeight + 1;
      }
    }
  }
}
