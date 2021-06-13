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
  public class SymmetricTree
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
      
      Boolean output = isSymmetric(root, root);
      if (output == true)
        Console.WriteLine("Symmetric");
      else
        Console.WriteLine("Not symmetric");

      stopwatch.Stop();
      Console.WriteLine($"{Environment.NewLine}Output is: in {stopwatch.ElapsedMilliseconds}");
    }

    Boolean isSymmetric(Node node1, Node node2)
    {
      // if both trees are empty,
      // then they are mirror image
      if (node1 == null && node2 == null)
        return true;

      // For two trees to be mirror images,
      // the following three conditions must be true
      // 1 - Their root node's key must be same
      // 2 - left subtree of left tree and right
      // subtree of right tree have to be mirror images
      // 3 - right subtree of left tree and left subtree
      // of right tree have to be mirror images

      if (node1 != null && 
        node2 != null && 
        node1.key == node2.key)
      {
        return
         isSymmetric(node1.left, node2.right) &&
         isSymmetric(node1.right, node2.left);
      }

      // if none of the above conditions
      // is true then root1 and root2 are
      // mirror images
      return false;
    }
  }
}
