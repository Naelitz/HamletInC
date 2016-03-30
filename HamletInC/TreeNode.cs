using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamletInC
{
    class TreeNode
    {
        public String word;
        public int count = 1;
        TreeNode leftChild { get; set; }
        TreeNode rightChild { get; set; }

        public TreeNode(String word)
        {
            this.word = word;
            leftChild = null;
            rightChild = null;

        }

        public void setLeftChild(TreeNode node)
        {
            leftChild = node;
        }

        public void setRightChild(TreeNode node)
        {
            rightChild = node;
        }

        public TreeNode getLeftChild()
        {
            return leftChild;
        }

        public TreeNode getRightChild()
        {
            return rightChild;
        }




    }
}

