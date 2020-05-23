using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Approximator2
{
    class Node
    {
        public Node next;
        public Point point;
        public Node(Node next, Point point)
        {
            this.next = next;
            this.point = point;
        }
    }
}
