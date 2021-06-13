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
  public class MergeTwoSortedLinkedList
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

      int llistCount1 = Convert.ToInt32(Console.ReadLine());

      SinglyLinkedList llist1 = new SinglyLinkedList();

      for (int i = 0; i < llistCount1; i++)
      {
        int llistItem = Convert.ToInt32(Console.ReadLine());
        llist1.InsertNode(llistItem);
      }
      Console.WriteLine($"2nd List:");
      int llistCount2 = Convert.ToInt32(Console.ReadLine());

      SinglyLinkedList llist2 = new SinglyLinkedList();

      for (int i = 0; i < llistCount2; i++)
      {
        int llistItem = Convert.ToInt32(Console.ReadLine());
        llist2.InsertNode(llistItem);
      }

      SinglyLinkedListNode llist_head = MergeTwoLinkedList(llist1.head, llist2.head);

      PrintSinglyLinkedList(llist_head, ", ");

      stopwatch.Stop();
      Console.WriteLine($"{Environment.NewLine}Output is: output in {stopwatch.ElapsedMilliseconds}");
    }

    private static SinglyLinkedListNode MergeTwoLinkedList(SinglyLinkedListNode head1, SinglyLinkedListNode head2)
    {
      var p1 = head1;
      var p2 = head2;
      SinglyLinkedList result = new SinglyLinkedList();
      
      while (p1 != null && p2 != null)
      {
        if (p1.data == p2.data)
        {
          result.InsertNode(p1.data);
          result.InsertNode(p2.data);
          p1 = p1.next;
          p2 = p2.next;
        }
        else if (p1.data < p2.data)
        {
          result.InsertNode(p1.data);
          p1 = p1.next;
        }
        else
        {
          result.InsertNode(p2.data);
          p2 = p2.next;
        }
      }

      if (p1 != null)
      {
        result.tail.next = p1;

        while (p1.next != null)
        {
          p1 = p1.next;
        }
        result.tail = p1;
      }
      else
      {
        result.tail.next = p2;
        
        while (p2.next != null)
        {
          p2 = p2.next;
        }
        result.tail = p2;
      }

      return result.head;
    }
  }
}
