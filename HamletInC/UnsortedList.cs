using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamletInC
{
    class UnsortedList
    {
        public Node first;
        Node currentNode;

        
        public UnsortedList()
        {

        }

        public void AddNode(Node node)
        {
            currentNode = first;
            if (currentNode == null) first = node;
            else
            {
                while (currentNode.word != node.word)
                {
                    if (currentNode.GetNext() == null) currentNode.SetNext(node);
                    else currentNode = currentNode.GetNext();
                }
                if (currentNode.word == node.word) currentNode.AddCount();
            }
                
            
        }
    }
}
