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
  public class AddTwoNumbers
  {
    public class ListNode
    {
      public int val;
      public ListNode next;
      public ListNode(int val = 0, ListNode next = null)
      {
        this.val = val;
        this.next = next;
      }
    }

    public void Run()
    {
      Stopwatch stopwatch = new Stopwatch();
      stopwatch.Start();

      ListNode l1 = new ListNode(2, new ListNode(4, new ListNode(3, new ListNode(7, new ListNode(1)))));
      ListNode l2 = new ListNode(5, new ListNode(6, new ListNode(4)));

      ListNode result = SubTwoLinkedList(l1, l2);

      ListNode SubTwoLinkedList(ListNode l1, ListNode l2, int nextAdd = 0)
      {
        if (l1 == null && l2 == null)
        {
          if (nextAdd == 1)
          {
            return new ListNode(1);
          }
          return null;
        }

        int n1 = l1?.val ?? 0;
        int n2 = l2?.val ?? 0;
        int sum = n1 + n2 + nextAdd;

        if (sum > 9)
        {
          sum %= 10;
          nextAdd = 1;
        }
        else
        {
          nextAdd = 0;
        }

        ListNode resultHeadNode = new ListNode(sum);
        resultHeadNode.next = SubTwoLinkedList(l1?.next, l2?.next, nextAdd);

        return resultHeadNode;
      }

      PrintSinglyLinkedList(result, ", ");

      stopwatch.Stop();
      Console.WriteLine($"{Environment.NewLine}Output is: output in {stopwatch.ElapsedMilliseconds}");
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
  }
}
