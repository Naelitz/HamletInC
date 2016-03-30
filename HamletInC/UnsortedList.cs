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
                    // If the current node does not have anything following it then add node.
                    if (currentNode.GetNext() == null) currentNode.SetNext(node);
                    // If the current node has a next node then continue to traverse the list.
                    else currentNode = currentNode.GetNext();
                }
                // Once the word is found then increase the count.
                if (currentNode.word == node.word) currentNode.AddCount();
            }
                
            
        }
    }
}
