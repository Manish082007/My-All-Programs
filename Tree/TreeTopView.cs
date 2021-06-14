﻿using System;
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
  public class TreeTopView
  {
    public class Node
    {
      public int data;
      public Node left, right;

      public Node(int item)
      {
        data = item;
        left = right = null;
      }
    }

    class QueueObj
    {
      public Node node;
      public int hd;

      public QueueObj(Node node, int hd)
      {
        this.node = node;
        this.hd = hd;
      }
    };

    public Node insert(Node root, int data)
    {
      if (root == null)
      {
        return new Node(data);
      }
      else
      {
        Node cur;
        if (data <= root.data)
        {
          cur = insert(root.left, data);
          root.left = cur;
        }
        else
        {
          cur = insert(root.right, data);
          root.right = cur;
        }
        return root;
      }
    }

    public void Run()
    {
      Stopwatch stopwatch = new Stopwatch();
      stopwatch.Start();

      //var array = new int[] { 108, 253, 290, 355, 288, 180, 323, 109, 430, 162, 148, 304, 312, 50, 98, 267, 57, 195, 206, 131, 276, 419, 207, 366, 102, 337, 259, 390, 272, 243, 86, 286, 255, 398, 130, 95, 41, 392, 351, 191, 18, 313, 216, 342, 433, 145, 54, 184, 61, 365, 395, 301, 213, 318, 442, 315, 73, 193, 303, 172, 371, 43, 384, 431, 411, 96, 425, 146, 347, 55, 10, 149, 292, 189, 244, 382, 340, 91, 64, 111, 234, 368, 260, 218, 94, 293, 40, 29, 297, 277, 174, 144, 372, 196, 179, 412, 170, 134, 51, 2, 220, 13, 82, 59, 92, 9, 306, 87, 181, 200, 104, 56, 32, 402, 429, 271, 152, 26, 302, 65, 49, 107, 333, 432, 334, 246, 239, 367, 11, 273, 257, 237, 204, 324, 164, 256, 69, 186, 68, 192, 62, 24, 436, 205, 129, 426, 296, 222, 407, 31, 418, 89, 71, 440, 380, 3, 90, 404, 74, 438, 275, 370, 413, 393, 291, 60, 99, 21, 133, 443, 163, 417, 84, 77, 357, 427, 369, 103, 227, 235, 307, 231, 44, 70, 281, 314, 121, 300, 38, 128, 362, 294, 378, 375, 110, 105, 132, 178, 346, 37, 212, 399, 165, 445, 197, 45, 326, 80, 23, 136, 15, 310, 338, 403, 250, 261, 410, 158, 345, 20, 242, 409, 444, 379, 1, 283, 377, 183, 331, 125, 118, 322, 166, 219, 401, 217, 348, 100, 53, 263, 230, 249, 353, 88, 258, 319, 363, 420, 441, 224, 6, 48, 150, 327, 343, 161, 115, 364, 284, 266, 397, 236, 154, 437, 336, 46, 127, 16, 422, 72, 119, 143, 182, 4, 394, 157, 159, 376, 124, 137, 141, 352, 434, 245, 361, 439, 349, 359, 325, 298, 396, 280, 173, 116, 33, 175, 171, 279, 25, 241, 114, 203, 374, 126, 332, 354, 190, 335, 414, 405, 320, 223, 176, 63, 36, 215, 435, 202, 232, 76, 389, 22, 321, 42, 424, 209, 167, 264, 383, 240, 135, 138, 211, 381, 309, 251, 52, 12, 248, 282, 155, 97, 278, 93, 400, 8, 188, 7, 187, 113, 228, 142, 185, 120, 387, 160, 254, 391, 269, 416, 406, 287, 198, 81, 39, 153, 341, 305, 229, 247, 168, 274, 19, 27, 386, 147, 123, 156, 233, 5, 194, 169, 35, 221, 17, 199, 311, 415, 75, 208, 67, 421, 78, 308, 58, 177, 262, 122, 225, 106, 289, 151, 47, 140, 344, 112, 358, 101, 329, 360, 388, 385, 210, 330, 214, 83, 252, 30, 285, 408, 226, 350, 373, 270, 317, 79, 423, 28, 295, 328, 66, 238, 356, 265, 117, 139, 14, 299, 428, 316, 34, 201, 85, 268, 339 };
      //Node root = null;
      //int len = 445;
      //int index = 0;
      //while (len-- > 0)
      //{
      //  int data = array[index++];
      //  root = insert(root, data);
      //}

      Node root = new Node(1);
      root.left = new Node(2);
      root.right = new Node(3);
      root.left.right = new Node(4);
      root.left.right.right = new Node(5);
      root.left.right.right.right = new Node(6);

      topView2(root);

      stopwatch.Stop();
      Console.WriteLine($"{Environment.NewLine}Output is : in {stopwatch.ElapsedMilliseconds}");
    }

    public void topView2(Node root)
    {
      Queue<QueueObj> queue = new Queue<QueueObj>();
      SortedDictionary<int, Node> topViewMap = new SortedDictionary<int, Node>();

      if (root == null)
      {
        return;
      }
      else
      {
        queue.Enqueue(new QueueObj(root, 0));
      }

      // count function returns 1 if the container
      // contains an element whose key is equivalent
      // to hd, or returns zero otherwise.
      while (queue.Count != 0)
      {
        QueueObj tmpNode = queue.Dequeue();

        if (!topViewMap.ContainsKey(tmpNode.hd))
        {
          topViewMap[tmpNode.hd] = tmpNode.node;
        }

        if (tmpNode.node.left != null)
        {
          queue.Enqueue(new QueueObj(tmpNode.node.left, tmpNode.hd - 1));
        }
        if (tmpNode.node.right != null)
        {
          queue.Enqueue(new QueueObj(tmpNode.node.right, tmpNode.hd + 1));
        }
      }

      foreach (var entry in topViewMap.Values)
      {
        Console.Write(entry.data + " ");
      }
    }

    public void topView(Node root)
    {
      if (root == null)
      {
        return;
      }

      callLeft(root.left);
      Console.Write(root.data + " ");
      callRight(root.right);
    }

    private void callLeft(Node root)
    {
      if (root == null)
      {
        return;
      }

      callLeft(root.left);
      //System.out.print(root.data + " ");
      Console.Write(root.data + " ");
    }

    private void callRight(Node root)
    {
      if (root == null)
      {
        return;
      }

      Console.Write(root.data + " ");
      callRight(root.right);
      //System.out.print(root.data + " ");
    }
  }
}
