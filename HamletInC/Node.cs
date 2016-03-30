using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamletInC
{
    class Node
    {
        public String word { get; set; }  // Allows getting and setting of word.
        public int count = 1;
        Node next;

        public Node(String word)
        {
            this.word = word; // Assign the word from the text file to the node. 
            
        }

        public void AddCount()
        {
            count++;  // increments the count of the word when a repeated word is found.
        }

        public void SetNext(Node nextNode)
        {
            next = nextNode; // Points to the next node in the list to allow linking.
        }

        public Node GetNext()
        {
            return next;
        }
    }
}
