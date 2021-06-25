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
  public class HuffmanDecoding
  {
    public class Node
    {
      public int data;
      public Node left, right;

      public Node(int item)
      {
        data = item;
        left = right = null;
      }
    }

    public Node insert(Node root, int data)
    {
      if (root == null)
      {
        return new Node(data);
      }
      else
      {
        Node cur;
        if (data <= root.data)
        {
          cur = insert(root.left, data);
          root.left = cur;
        }
        else
        {
          cur = insert(root.right, data);
          root.right = cur;
        }
        return root;
      }
    }

    public void Run()
    {
      Stopwatch stopwatch = new Stopwatch();
      stopwatch.Start();

      Node root = new Node(4);
      root.left = new Node(2);
      root.left.left = new Node(1);
      root.left.right = new Node(3);
      
      root.right = new Node(7);
      //root.right.left = new Node(6);

      root = InsertNode(root, 6);
      //root = InsertNode(root, 8);

      stopwatch.Stop();
      Console.WriteLine($"{Environment.NewLine}Output is : in {stopwatch.ElapsedMilliseconds}");
    }

    public Node InsertNode(Node root, int data)
    {
      if (root == null)
      {
        root = new Node(data);
      }
      else
      {
        if (root.data > data)
        {
          root.left = InsertNode(root.left, data);
        }
        else
        {
          root.right = InsertNode(root.right, data);
        }
      }

      return root;
    }
  }
}
