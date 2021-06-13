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
  public class BinaryTreeTraversals
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
      root.right = new Node(3);
      root.left.left = new Node(4);
      root.left.right = new Node(5);
      root.right.left = new Node(6);
      root.right.right = new Node(7);

      Console.WriteLine($"{Environment.NewLine}In Order: ");
      printInOrder(root);
      Console.WriteLine($"{Environment.NewLine}{Environment.NewLine}Pre Order: ");
      printPreOrder(root);
      Console.WriteLine($"{Environment.NewLine}{Environment.NewLine}Post Order: ");
      printPostOrder(root);

      stopwatch.Stop();
      Console.WriteLine($"{Environment.NewLine}{Environment.NewLine}Output in {stopwatch.ElapsedMilliseconds}");
    }

    void printInOrder(Node root)
    {
      if (root == null)
        return;

      printInOrder(root.left);
      Console.Write($"{root.key} ");
      printInOrder(root.right);
    }

    void printPreOrder(Node root)
    {
      if (root == null)
        return;

      Console.Write($"{root.key} ");
      printPreOrder(root.left);
      printPreOrder(root.right);
    }

    void printPostOrder(Node root)
    {
      if (root == null)
        return;

      printPostOrder(root.left);
      printPostOrder(root.right);
      Console.Write($"{root.key} ");
    }
  }
}
