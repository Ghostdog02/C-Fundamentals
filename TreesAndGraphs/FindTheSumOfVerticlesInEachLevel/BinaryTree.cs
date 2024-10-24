using System;
using System.Collections.Generic;

namespace Program
{
    public class BinaryTree
    {
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
        private void TraverseInOrder(int currentDepth, Dictionary<int, int> sum)
        {
            // 1. Visit the left child
            if (this.LeftChild != null)
            {
                currentDepth++;
                this.LeftChild.depth = currentDepth;
                this.LeftChild.TraverseInOrder(currentDepth, sum);
                currentDepth--;
            }
            // 2. Visit the root of this sub-tree
            if (sum.ContainsKey(currentDepth))
            {
                sum[currentDepth] += this.Value;
            }

            else
            {
                sum[currentDepth] = this.Value;
            }
            //Console.Write(this.Value + " ");
            // 3. Visit the right child
            if (this.RightChild != null)
            {
                currentDepth++;
                this.RightChild.depth = currentDepth;
                this.RightChild.TraverseInOrder(currentDepth, sum);
                currentDepth--;
            }
        }

        public void TraverseInOrder()
        {
            TraverseInOrder(0, sum);
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