using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamletInC
{
    class Node
    {
        public String word { get; set; }
        public int count = 1;
        Node next;

        public Node(String word)
        {
            this.word = word;
            
        }

        public void AddCount()
        {
            count++;
        }

        public void SetNext(Node nextNode)
        {
            next = nextNode;
        }

        public Node GetNext()
        {
            return next;
        }
    }
}
