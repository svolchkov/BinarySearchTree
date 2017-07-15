using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class TreeNode<T>
    {
        public T Element { get; set; }
        public TreeNode<T> Left { get; set; }
        public TreeNode<T> Right { get; set; }
        public TreeNode<T> Parent { get; set; }
        public int Level { get; set; }

        public TreeNode (T element, TreeNode<T> parent)
        {
            this.Element = element;
            this.Parent = parent;
            // the root level is zero
            this.Level = (this.Parent == null) ? 0 : (this.Parent.Level + 1);
        }

        public TreeNode(TreeNode<T> t)
        {
            this.Element = t.Element;
            this.Parent = t.Parent;
            this.Level = t.Level;
        }

        public override string ToString()
        {
            string nodeString = "[" + this.Element + " ";
            nodeString += ("<Level " + this.Level + ">");
            //Leaf
            if (this.Left == null && this.Right == null)
            {
                nodeString += " (Leaf) ";
            }

            if (this.Left != null)
            {
                nodeString += "Left: " + this.Left.ToString();
            }

            if (this.Right != null)
            {
                nodeString += "Right: " + this.Right.ToString();
            }

            nodeString += "] ";

            return nodeString;
        }
    }
}
