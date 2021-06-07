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
  public class InsertNodeAtTail
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

      public SinglyLinkedList()
      {
        this.head = null;
      }
    }

    static void PrintSinglyLinkedList(SinglyLinkedListNode node, string sep)
    {
      while (node != null)
      {
        Console.WriteLine(node.data);
        
        node = node.next;

        if (node != null)
        {
          Console.WriteLine(sep);
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
        SinglyLinkedListNode llist_head = insertNodeAtTail(llist.head, llistItem);
        llist.head = llist_head;
      }

      PrintSinglyLinkedList(llist.head, "\n");

      stopwatch.Stop();
      Console.WriteLine($"Output is: output in {stopwatch.ElapsedMilliseconds}");
    }

    static SinglyLinkedListNode insertNodeAtTail(SinglyLinkedListNode head, int data)
    {
      SinglyLinkedListNode nodeToInsert = new SinglyLinkedListNode(data);

      if (head == null)
      {
        head = nodeToInsert;
      }
      else
      {
        SinglyLinkedListNode temp = head;
        while (temp.next != null)
        {
          temp = temp.next;
        }
        temp.next = nodeToInsert;
      }

      return head;
    }
  }
}
