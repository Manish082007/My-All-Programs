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
  public class ReverseLinkList
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

      SinglyLinkedList llist = new SinglyLinkedList();

      int llistCount = Convert.ToInt32(Console.ReadLine());

      for (int i = 0; i < llistCount; i++)
      {
        int llistItem = Convert.ToInt32(Console.ReadLine());
        llist.InsertNode(llistItem);
      }

      var result = Reverse3(llist.head);

      Console.WriteLine($"{Environment.NewLine}New List: ");
      PrintSinglyLinkedList(result, ", ");

      stopwatch.Stop();
      Console.WriteLine($"{Environment.NewLine}Output is: output in {stopwatch.ElapsedMilliseconds}");
    }

    private static SinglyLinkedListNode Reverse(SinglyLinkedListNode llist)
    {
      if (llist.next != null)
      {
        var newHead = Reverse(llist.next);
        var temp = newHead;
        while (temp.next != null)
        {
          temp = temp.next;
        }

        temp.next = new SinglyLinkedListNode(llist.data);
        return newHead;
      }
      else
      {
        return new SinglyLinkedListNode(llist.data);
      }
    }

    private static SinglyLinkedListNode Reverse2(SinglyLinkedListNode head)
    {
      SinglyLinkedListNode tail, temp;
      tail = null;

      while (head != null)
      {
        temp = head.next; // Temporary saves the head next {1.....2,3,4,5}
        head.next = tail;
        tail = head;
        head = temp;
      }
      return tail;
    }

    private static SinglyLinkedListNode Reverse3(SinglyLinkedListNode head)
    {
      SinglyLinkedListNode temp = head;
      SinglyLinkedListNode newHead = new SinglyLinkedListNode(head.data);

      while (temp.next != null)
      {
        var newNodeToInsert = new SinglyLinkedListNode(temp.next.data);
        newNodeToInsert.next = newHead;
        temp = temp.next;
        newHead = newNodeToInsert;
      }

      return newHead;
    }
  }
}
