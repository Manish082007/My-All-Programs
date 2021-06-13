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
  public class CompareTwoLinkedList
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

      int llistCount = Convert.ToInt32(Console.ReadLine());

      SinglyLinkedList llist1 = new SinglyLinkedList();

      for (int i = 0; i < llistCount; i++)
      {
        int llistItem = Convert.ToInt32(Console.ReadLine());
        llist1.InsertNode(llistItem);
      }

      SinglyLinkedList llist2 = new SinglyLinkedList();

      for (int i = 0; i < llistCount; i++)
      {
        int llistItem = Convert.ToInt32(Console.ReadLine());
        llist2.InsertNode(llistItem);
      }

      bool result = CompareLinkList(llist1.head, llist2.head);

      stopwatch.Stop();
      Console.WriteLine($"{Environment.NewLine}Output is: {result} in {stopwatch.ElapsedMilliseconds}");
    }

    private static bool CompareLinkList(SinglyLinkedListNode llist1, SinglyLinkedListNode llist2)
    {
      var p1 = llist1;
      var p2 = llist2;

      while (p1 != null && p2 != null)
      {
        if (p1.data == p2.data)
        {
          p1 = p1.next;
          p2 = p2.next;
          continue;
        }
        else
        {
          return false;
        }
      }

      if ((p1 == null && p2 != null) || p1 != null && p2 == null)
      {
        return false;
      }

      return true;
    }
  }
}
