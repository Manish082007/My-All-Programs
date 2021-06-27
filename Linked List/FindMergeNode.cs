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
  public class FindMergeNode
  {
    class SinglyLinkedListNode
    {
      public int data;
      public SinglyLinkedListNode next;

      public SinglyLinkedListNode(int nodeData)
      {
        this.data = nodeData;
        this.next = null;
      }
    }

    class SinglyLinkedList
    {
      public SinglyLinkedListNode head;
      public SinglyLinkedListNode tail;

      public SinglyLinkedList()
      {
        this.head = null;
        this.tail = null;
      }

      public void InsertNode(int nodeData)
      {
        SinglyLinkedListNode node = new SinglyLinkedListNode(nodeData);

        if (this.head == null)
        {
          this.head = this.tail = node;
        }
        else
        {
          this.tail.next = this.tail = node;
        }
      }
    }

    static void PrintSinglyLinkedList(SinglyLinkedListNode node, string sep)
    {
      while (node != null)
      {
        Console.Write(node.data);

        node = node.next;

        if (node != null)
        {
          Console.Write(sep);
        }
      }
    }

    public void Run()
    {
      Stopwatch stopwatch = new Stopwatch();
      stopwatch.Start();

      SinglyLinkedList llist1 = new SinglyLinkedList();

      int llistCount = Convert.ToInt32(Console.ReadLine());

      for (int i = 0; i < llistCount; i++)
      {
        int llistItem = Convert.ToInt32(Console.ReadLine());
        llist1.InsertNode(llistItem);
      }

      Console.WriteLine($"{Environment.NewLine}Enter Position: ");
      int position = Convert.ToInt32(Console.ReadLine());

      int result = GetValue(llist1.head, position);

      stopwatch.Stop();
      Console.WriteLine($"{Environment.NewLine}Output is: {result} in {stopwatch.ElapsedMilliseconds}");
    }

    private static int GetValue(SinglyLinkedListNode llist, int position)
    {
      var p1 = llist;
      var p2 = llist;

      //while (position > 0)
      //{
      //  p2 = p2.next;
      //  position--;
      //}

      while (p2.next != null)
      {
        if (position == 0)
        {
          p1 = p1.next;
        }
        else
        {
          position--;
        }

        p2 = p2.next;
      }

      return p1.data;
    }
  }
}
