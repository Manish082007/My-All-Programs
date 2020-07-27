using System;
using System.Collections.Generic;
using System.Text;

namespace All_Programs
{
    public class Node
    {
        private int value;
        private Node parent;
        public Node Left;
        public Node Right;

        public int Value { get => value; set => this.value = value; }
        public Node Parent { get => parent; set => parent = value; }

        public Node()
        {
            
        }

    }
}
