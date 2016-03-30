using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamletInC
{
    //This class will implement a Binary Search Tree to sort words
    //in a text document in alphabetical order. Using compareTo if the 
    //number is < 0 then branch left, if number is > 0 branch right.
    //If the number is ==0 then increment count. 
    class SearchTree
    {
        int distinct = 0;
        int totalCount = 0;
        int comparisons = 0;
        int addedNodes = 0;


        TreeNode first;
        int length = 0;
        TreeNode current;
        int referenceChange;
        int compared;

        static SearchTree link = new SearchTree();

        public void Add(TreeNode node)
        {
            current = first;
            //If tree is empty set root.
            if (first == null)
            {
                first = node;
                referenceChange += 1;
            }
            //else compare and search tree for corrent leaf location.
            else
            {
                do
                {
                    compared = current.word.CompareTo(node.word);
                    comparisons += 1;
                    //If the compared node is the same increment count.
                    if (compared == 0) current.count += 1;
                    //If it is greater then compared node follow branch right
                    //if that branch is empty place leaf.
                    else if (compared > 0)
                    {
                        if (current.getRightChild() == null)
                        {
                            current.setRightChild(node);
                            referenceChange += 1;
                            break;
                        }
                        else
                        {
                            current = current.getRightChild();
                            comparisons += 1;
                        }
                    }
                    //If it is less then compared node follow branch left
                    //if that branch is empty place leaf.
                    else if (compared < 0)
                    {
                        if (current.getLeftChild() == null)
                        {
                            current.setLeftChild(node);
                            referenceChange += 1;
                            break;
                        }
                        else
                        {
                            current = current.getLeftChild();
                            comparisons += 1;
                        }
                    }
                } while (compared != 0);
            }

        }

        public void stat()
        {
            Console.Write("Comparisons made: " + comparisons);
            Console.Write(" Refrence changes: " + referenceChange);
            Console.Write(" Total words: " + sum(first));
            Console.Write(" Distinct words: " + distinct);

        }
        //This will recursively add the count value of every node in the tree.
        int sum(TreeNode node)
        {
            //Add the count of the current node called
            int result = node.count;
            distinct += 1;
            //If branches are not empty call those as well.
            if (node.getLeftChild() != null)
            {
                result += sum(node.getLeftChild());
            }
            if (node.getRightChild() != null)
            {
                result += sum(node.getRightChild());
            }
            return result;
        }


    }
}

