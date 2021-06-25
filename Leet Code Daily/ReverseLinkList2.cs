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
  public class ReverseLinkList2
  {
    class ListNode
    {
      public int val;
      public ListNode next;

      public ListNode(int nodeData)
      {
        this.val = nodeData;
        this.next = null;
      }
    }

    class LinkedList
    {
      public ListNode head;
      public ListNode tail;

      public LinkedList()
      {
        this.head = null;
        this.tail = null;
      }

      public void InsertNode(int nodeData)
      {
        ListNode node = new ListNode(nodeData);

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

    static void PrintSinglyLinkedList(ListNode node, string sep)
    {
      while (node != null)
      {
        Console.Write(node.val);

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

      LinkedList llist = new LinkedList();

      //Console.WriteLine($"{Environment.NewLine}Enter Number: ");
      int llistCount = 6;//Convert.ToInt32(Console.ReadLine());

      //Console.WriteLine($"{Environment.NewLine}Enter List: ");
      for (int i = 0; i < llistCount; i++)
      {
        //int llistItem = Convert.ToInt32(Console.ReadLine());
        llist.InsertNode(i + 1);
      }

      var result = Reverse3(llist.head, 2, 5);

      Console.WriteLine($"{Environment.NewLine}New List: ");
      PrintSinglyLinkedList(result, ", ");

      stopwatch.Stop();
      Console.WriteLine($"{Environment.NewLine}Output is: output in {stopwatch.ElapsedMilliseconds}");
    }

    private ListNode Reverse(ListNode head, int left, int right)
    {
      ListNode tailNode = null, temp;
      ListNode leftNode, lastNode;
      
      #region Find Left Node

      int tempLeft = left;
      while (tempLeft > 1)
      {
        head = head.next;
        tempLeft--;
      }
      leftNode = head;
      
      #endregion

      tempLeft = left;

      while (tempLeft <= right && head != null)
      {
        temp = head.next;
        head.next = tailNode;
        tailNode = head;
        head = temp;

        tempLeft++;
      }

      tailNode.next = head;

      return tailNode;
    }

    private ListNode Reverse2(ListNode head, int left, int right)
    {
      if (head == null)
      {
        return null;
      }

      ListNode dummy = new ListNode(0); // create a dummy node to mark the head of this list
      dummy.next = head;
      ListNode pre = dummy; // make a pointer pre as a marker for the node before reversing

      for (int i = 0; i < left - 1; i++)
      {
        pre = pre.next;
      }

      ListNode start = pre.next; // a pointer to the beginning of a sub-list that will be reversed
      ListNode then = start.next; // a pointer to a node that will be reversed

      // 1 - 2 -3 - 4 - 5 - 6; left = 2; right = 4 ---> pre = 1, start = 2, then = 4
      // dummy-> 1 -> 2 -> 3 -> 4 -> 5 -> 6

      for (int i = 0; i < right - left; i++)
      {
        start.next = then.next;
        then.next = pre.next;
        pre.next = then;
        then = start.next;
      }

      // first reversing : dummy -> 1 - 3 - 2 - 4 - 5 - 6; pre = 1, start = 2, then = 4
      // second reversing: dummy -> 1 - 4 - 3 - 2 - 5 - 6; pre = 1, start = 2, then = 5 (finish)

      return dummy.next;
    }

    private ListNode Reverse3(ListNode head, int left, int right)
    {
      if (head == null)
      {
        return null;
      }

      ListNode dummy = new ListNode(0);
      dummy.next = head;

      ListNode leftNode = head;
      for(int i = left; i > 1; i--)
      {
        leftNode = leftNode.next;
      }

      // left=2,right=3
      // 1-2-3-4-5-6    left=3,right=2    left=3,right=4
      // 1-3-2-4-5-6
      // 1-4-2-3-5-6
      // 1-5-2-3-4-6

      ListNode rightNode = leftNode.next;
      for (int i = 0; i< right - left; i++)
      {
        int temp = leftNode.val;
        leftNode.val = rightNode.val;
        rightNode.val = temp;

        rightNode = rightNode.next;
      }

      return dummy.next;
    }
  }
}
