using System;
using System.Collections.Generic;

namespace Program
{
    public class BinaryTree
    {
        public bool isPerfectlyBalanced = true;
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
        public void TraverseInOrder(int currentDepth)
        {
            if (this.LeftChild != null)
            {
                currentDepth++;
                this.LeftChild.depth = currentDepth;
                this.LeftChild.TraverseInOrder(currentDepth);
                currentDepth--;
            }

            this.depth = currentDepth;

            if (this.RightChild != null)
            {
                currentDepth++;
                this.RightChild.depth = currentDepth;
                this.RightChild.TraverseInOrder(currentDepth);
                currentDepth--;
            }
        }

        public void CheckBalance()
        {
            //
            if ((this.LeftChild != null) && (this.RightChild != null))
            {
                var difference = Math.Abs(this.LeftChild.depth - this.RightChild.depth);
                if (difference > 1)
                {
                    isPerfectlyBalanced = false;
                    Console.WriteLine($"Binary tree isn't perfectly balanced");
                    return;
                }
            }

            if ((this.LeftChild == null) && (this.RightChild != null))
            {
                if ((this.RightChild.RightChild != null) || (this.RightChild.LeftChild != null))
                {
                    isPerfectlyBalanced = false;
                    Console.WriteLine($"Binary tree isn't perfectly balanced");
                    return;
                }
            }

            if ((this.LeftChild != null) && (this.RightChild == null))
            {
                if ((this.LeftChild.RightChild != null) || (this.LeftChild.LeftChild != null))
                {
                    isPerfectlyBalanced = false;
                    Console.WriteLine($"Binary tree isn't perfectly balanced");
                    return;
                }
            }
            //

            if (this.LeftChild != null)
            {
                this.LeftChild.CheckBalance();
            }
            
            if (this.RightChild != null)
            {
                this.RightChild.CheckBalance();
            }


        }

        //public void PrintSum()
        //{
        //    foreach (var key in sum.Keys.OrderBy(a => a))
        //    {
        //        Console.WriteLine($"Depth {key}: with sum {sum[key]}");
        //    }
        //}
    }
}