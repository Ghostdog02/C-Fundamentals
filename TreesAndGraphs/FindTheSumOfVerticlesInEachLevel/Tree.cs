using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;

namespace Program
{
    public class TreeNode
    {
        public int depth;
        // Contains the value of the node
        private int value;
        // Shows whether the current node has a parent or not
        private bool hasParent;
        // Contains the children of the node (zero or more)
        private List<TreeNode> children;

        public TreeNode(int value)
        {
            if (value == 0)
            {
                throw new ArgumentNullException(
                "Cannot insert zero value!");
            }
            this.value = value;
            this.children = new List<TreeNode>();
        }
        /// <summary>The value of the node</summary>
        public int Value
        {
            get
            {
                return this.value;
            }
            set
            {
                this.value = value;
            }
        }
        /// <summary>The number of node's children</summary>
        public int ChildrenCount
        {
            get
            {
                return this.children.Count;
            }
        }

        public void AddChild(TreeNode child)
        {
            if (child == null)
            {
                throw new ArgumentNullException(
                "Cannot insert null value!");
            }
            if (child.hasParent)
            {
                throw new ArgumentException(
                "The node already has a parent!");
            }
            child.hasParent = true;
            this.children.Add(child);
        }

        public TreeNode GetChild(int index)
        {
            return this.children[index];
        }


    }

    public class Tree
    {
        // The root of the tree
        private TreeNode root;
        public List<int> sum = new List<int>();

        public Tree(int value)
        {
            if (value == 0)
            {
                throw new ArgumentNullException(
                "Cannot insert null value!");
            }
            this.root = new TreeNode(value);
        }

        public Tree(int value, params Tree[] children)
        : this(value)
        {
            foreach (Tree child in children)
            {
                this.root.AddChild(child.root);
            }
        }

        public TreeNode Root
        {
            get
            {
                return this.root;
            }
        }

        private void PrintDFS(TreeNode root, int currentDepth)
        {
            if (this.root == null)
            {
                return;
            }

            //if (root.Value == this.Number)
            //{
            //    Occurrences++;
            //}
            sum.Add(root.Value);
            TreeNode child = null;
            for (int i = 0; i < root.ChildrenCount; i++)
            {
                child = root.GetChild(i);
                currentDepth++;
                child.depth = currentDepth;
                if (sum[currentDepth] != 0)
                {
                    sum[currentDepth] += child.Value;
                }
                Console.WriteLine($"Element {child.Value} with depth {currentDepth}");
                PrintDFS(child, currentDepth);
                currentDepth--;
            }


        }

        public void PrintSum()
        {
            foreach (int index in sum)
            {
                Console.WriteLine($"Depth {index}: sum = {sum[index]}");
            }
        }

        public void TraverseDFS()
        {
            this.PrintDFS(this.root, 0);
        }

    }


}