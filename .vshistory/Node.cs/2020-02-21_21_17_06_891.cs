using System;
using System.Collections.Generic;
using System.Text;

namespace All_Programs
{
    public class Node
    {
        public Node(Node parent, int value, Node left, Node right)
        {

        }

        public int Value { get; set; } = 0;
        public Node Parent { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
    }
}
