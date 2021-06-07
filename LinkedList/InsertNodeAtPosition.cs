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
  public class InsertNodeAtPosition
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

      int data = Convert.ToInt32(Console.ReadLine());
      int position = Convert.ToInt32(Console.ReadLine());

      SinglyLinkedListNode llist_head = insertNodeAtPosition(llist.head, data, position);

      PrintSinglyLinkedList(llist_head, ", ");

      stopwatch.Stop();
      Console.WriteLine($"Output is: output in {stopwatch.ElapsedMilliseconds}");
    }

    static SinglyLinkedListNode insertNodeAtPosition(SinglyLinkedListNode llist, int data, int position)
    {
      SinglyLinkedListNode nodeToInsert = new SinglyLinkedListNode(data);

      if (position == 0 || llist == null)
      {
        nodeToInsert.next = llist;
        return nodeToInsert;
      }
      else
      {
        SinglyLinkedListNode prevNode = llist;
        while (position > 1)
        {
          prevNode = prevNode.next;
          position--;
        }

        if (prevNode.next == null)
        { // Inserting node at end
          prevNode.next = nodeToInsert;
        }
        else
        {
          SinglyLinkedListNode nextNode = prevNode.next;
          prevNode.next = nodeToInsert;
          nodeToInsert.next = nextNode;
        }
      }

      return llist;
    }
  }
}
