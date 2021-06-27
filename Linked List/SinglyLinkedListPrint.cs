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
  public class SinglyLinkedListPrint
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

    public void Run()
    {
      Stopwatch stopwatch = new Stopwatch();
      stopwatch.Start();

      SinglyLinkedList llist = new SinglyLinkedList();

      int llistCount = Convert.ToInt32(Console.ReadLine());

      for (int i = 0; i < llistCount; i++)
      {
        int llistItem = Convert.ToInt32(Console.ReadLine());
        llist.InsertNode(llistItem);
      }

      Console.WriteLine($"{Environment.NewLine}Printing Data: ");
      printLinkedList(llist.head);

      stopwatch.Stop();
      Console.WriteLine($"Output is: output in {stopwatch.ElapsedMilliseconds}");
    }

    static void printLinkedList(SinglyLinkedListNode head)
    {
      SinglyLinkedListNode node = head;
      while (node != null)
      {
        Console.WriteLine(node.data);
        node = node.next;
      }
    }
  }
}
