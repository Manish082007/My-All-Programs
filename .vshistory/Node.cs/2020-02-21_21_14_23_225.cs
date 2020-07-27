using System;
using System.Collections.Generic;
using System.Text;

namespace All_Programs
{
    public class Node
    {
        private int value;
        public Node Parent;
        public Node Left;
        public Node Right;

        public int Value { get => value; set => this.value = value; }

        public Node()
        {
            
        }

    }
}
