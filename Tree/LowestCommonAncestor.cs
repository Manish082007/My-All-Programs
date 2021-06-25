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
  public class LowestCommonAncestor
  {
    class Node
    {
      public int data;
      public Node left, right;

      public Node(int item)
      {
        data = item;
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

      Lca(root, 1, 3);

      stopwatch.Stop();
      Console.WriteLine($"{Environment.NewLine}Output is : in {stopwatch.ElapsedMilliseconds}");
    }

    private Node Lca(Node root, int v1, int v2)
    {
      if (v1 > root.data && v2 > root.data)
      {
        return Lca(root.right, v1, v2);
      }
      else if (v1 < root.data && v2 < root.data)
      {
        return Lca(root.left, v1, v2);
      }
      else
      {
        return root;
      }
    }
  }
}
