using System;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Program
{

    public class TreeNode
    {
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

        public int NumberOfLeaves { get; set; }

        public int NumberOfVerticles { get; set; }

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

        private void PrintDFS(TreeNode root)
        {
            if (this.root == null)
            {
                return;
            }

            //if (root.Value == this.Number)
            //{
            //    Occurrences++;
            //}

            TreeNode child = null;
            for (int i = 0; i < root.ChildrenCount; i++)
            {
                child = root.GetChild(i);

                if (child.ChildrenCount >= 1)
                {
                    NumberOfVerticles++;
                }

                else
                {
                    NumberOfLeaves++;
                }

                PrintDFS(child);
            }
        }

        public void TraverseDFS()
        {
            this.PrintDFS(this.root);
        }
                
    }


}