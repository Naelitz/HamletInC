using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamletInC
{
    // This class will sort the list by adding the new 
    // word to the beginning of the list. If the word already 
    // exists in the list then when current finds it, 
    // previous will get currents link and link will move to first.
    class SelfSorting
    {
        static int totalCount = 0;
        static int count = 0;
        static int comparisons = 0;
        static int length = 0;
        Node current;
        Node first;
        Node previous;

        public void AddNode(Node node)
        {
            current = first; // start traversing from the beginning of the list. 
            previous = null;

            if (first == null)  // If the list is empty just add the node. 
            {
                nodeAdd(node);
            }

            else
            {
                current = first;

                // if the first node is the same as the new node
                // just increase the count and return. 
                comparisons++;
                if (first.word == node.word)
                {
                    first.count++;
                    return;
                }

                // While not at the end of the list continue to traverse until you 
                // find the correct node. 
                else while (current.GetNext() != null)
                    {
                        // If the correct node is found then add to the count
                        // move the node to the front of the list and correct
                        // the links. 
                        comparisons++;
                        if (current.word == node.word)
                        {
                            current.count++;
                            previous.SetNext(current.GetNext());
                            current.SetNext(first);
                            first = current;
                            return;
                        }
                        else
                        {
                            previous = current;

                            current = current.GetNext();
                        }
                    }
                nodeAdd(node);
            }
        }

        void nodeAdd(Node node)
        {
            node.SetNext(first);
            node.count++;
            first = node;
            length++;
        }
    }

}

