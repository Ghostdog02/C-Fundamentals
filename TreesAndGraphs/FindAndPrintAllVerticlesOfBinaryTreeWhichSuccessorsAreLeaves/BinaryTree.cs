using System;
using System.Collections.Generic;

namespace Program
{
    public class BinaryTree
    {
        public List<BinaryTree> nodes = new List<BinaryTree>();
        //Depth,Sum
        public Dictionary<int, int> sum = new();
        //public int[] sum;
        public int depth;
        /// <summary>The value stored in the curent node</summary>
        public int Value { get; set; }
        /// <summary>The left child of the current node</summary>
        public BinaryTree LeftChild { get; private set; }
        /// <summary>The right child of the current node</summary>
        public BinaryTree RightChild { get; private set; }
        /// <summary>Constructs a binary tree</summary>
        /// <param name="value">the value of the tree node</param>
        /// <param name="leftChild">the left child of the tree</param>
        /// <param name="rightChild">the right child of the tree
        /// </param>
        public bool IsLeaf { get; private set; }
        public BinaryTree(int value,
        BinaryTree leftChild, BinaryTree rightChild)
        {
            this.Value = value;
            this.LeftChild = leftChild;
            this.RightChild = rightChild;
        }

        public BinaryTree(int value) : this(value, null, null)
        {
        }
        /// <summary>Traverses the binary tree in pre-order</summary>
        public void PrintPostOrder()
        {
            // 1. Visit the left child
            if (this.LeftChild != null)
            {
                this.LeftChild.PrintPostOrder();

            }
            
            if (this.RightChild != null)
            {
                this.RightChild.PrintPostOrder();
            }

            if ((this.RightChild == null) && (this.LeftChild == null))
            {
                this.IsLeaf = true;
            }

            if ((this.LeftChild != null) && (this.RightChild != null))
            {
                if (this.RightChild.IsLeaf && this.LeftChild.IsLeaf)
                {
                    nodes.Add(this);
                    Console.WriteLine(this.Value);
                }
            }
        }

        public void PrintSum()
        {
            foreach (var key in sum.Keys.OrderBy(a => a))
            {
                Console.WriteLine($"Depth {key}: with sum {sum[key]}");
            }
        }
    }
}