using System;
using System.Collections.Generic;
using System.Text;

namespace All_Programs
{
    public class Node
    {
        public Node Left;
        public Node Right;

        public int Value { get; set; } = 0;
        public Node Parent { get; set; }

        public Node()
        {
            
        }

    }
}
