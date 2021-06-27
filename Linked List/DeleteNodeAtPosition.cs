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
  public class DeleteNodeAtPosition
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

      int position = Convert.ToInt32(Console.ReadLine());

      SinglyLinkedListNode llist_head = DeleteNode(llist.head, position);

      PrintSinglyLinkedList(llist_head, ", ");

      stopwatch.Stop();
      Console.WriteLine($"{Environment.NewLine}Output is: output in {stopwatch.ElapsedMilliseconds}");
    }

    private static SinglyLinkedListNode DeleteNode(SinglyLinkedListNode llist, int position)
    {
      if (position == 0)
      {
        if (llist != null)
        {
          return llist.next;
        }

        return null;
      }
      else
      {
        SinglyLinkedListNode currentNode = llist;
        while (position > 1)
        {
          currentNode = currentNode.next;
          position--;
        }

        SinglyLinkedListNode nodeToDelete = currentNode.next;
        if (nodeToDelete.next == null)
        {
          currentNode.next = null;
        }
        else
        {
          SinglyLinkedListNode veryNextNode = nodeToDelete.next;
          currentNode.next = veryNextNode;
        }

        return llist;
      }
    }
  }
}
