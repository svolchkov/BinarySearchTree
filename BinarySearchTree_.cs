using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinarySearchTree
{
    class BinarySearchTree_<T>
    {
        public TreeNode<T> Root { get; set; }
        public List<TreeNode<T>> treeNodes;

        public BinarySearchTree_()
        {
            this.Root = null;
            treeNodes = new List<TreeNode<T>>();
        }

        public void Insert(T x)
        {
            Insert(x, this.Root);
        }

        public void Remove(T x)
        {
            //this.Root = Remove(x, this.Root);
            //this.Root.Parent = null;
            //this.Root.Level = 0;
            TreeNode<T> t = Find(x, this.Root);
            if (t == null)
            {
                throw new ItemNotFoundException("Item not found");
            }
            else
            {
                Remove(t);
            }
        }

        public void RemoveMin()
        {
            //this.Root = RemoveMin(this.Root);
            Remove(this.FindMin());
        }

        public T FindMin()
        {
            return FindMin(this.Root);
        }

        public T FindMax()
        {
            return ElementAt(FindMax(this.Root));
        }

        public T Find(T x)
        {
            return ElementAt(Find(x, this.Root));
        }

        public void MakeEmpty()
        {
            // Clear the tree
            this.Root = null;
            this.treeNodes.Clear();
        }

        public bool IsEmpty()
        {
            return this.Root == null;
        }

        private T ElementAt(TreeNode<T> t)
        {
            // Return node element
            return t == null ? default(T) : t.Element;
        }

        private TreeNode<T> Find(T x, TreeNode<T> t)
        {
            // Find a node
            while (t != null)
            {
                if ((x as IComparable).CompareTo(t.Element) < 0)
                {
                    t = t.Left;
                }
                else if((x as IComparable).CompareTo(t.Element) > 0)
                {
                    t = t.Right;
                }
                else
                {
                    return t;
                }
            }

            return null;
        }

        private T FindMin(TreeNode<T> t)
        {
            // Find maximum element of a sub-tree
            if (t != null)
            {
                while (t.Left != null)
                {
                    t = t.Left;
                }
            }

            return t.Element;
        }

        private TreeNode<T> FindMax(TreeNode<T> t)
        {
            // Find maximum element of the tree
            if (t != null)
            {
                while (t.Right != null)
                {
                    t = t.Right;
                }
            }

            return t;
        }

        protected void Insert(T x, TreeNode <T> t)
        {
            // This routine will actually insert a node in the tree and the
            // list of nodes
            if (t == null)
                // root element
            {
                this.Root = new TreeNode<T>(x, null);
                treeNodes.Add(this.Root);
            }
            else if ((x as IComparable).CompareTo(t.Element) < 0)
            {
                if (t.Left == null)
                {
                    t.Left = new TreeNode<T>(x, t);
                    treeNodes.Add(t.Left);
                }
                else
                {
                    Insert(x, t.Left);
                }
            }
            else if ((x as IComparable).CompareTo(t.Element) > 0)
            {
                if (t.Right == null)
                {
                    t.Right = new TreeNode<T>(x, t);
                    treeNodes.Add(t.Right);
                }
                else
                {
                    Insert(x, t.Right);
                }
            }
            else
            {
                throw new DuplicateItemException("Duplicate item");
            }
        }

        protected TreeNode<T> RemoveMin(TreeNode <T> t)
        {
            // This routine will remove the minimum element of a subtree
            // and update its children
            if (t == null)
            {
                throw new ItemNotFoundException("Item not found");
            }
            else if (t.Left != null)
            {
                t.Left = RemoveMin(t.Left);
                return t;
            }
            else
            {
                treeNodes.Remove(t);
                if (t.Right != null)
                {
                    updateLevels(t.Right);
                    t.Right.Parent = t.Parent;
                }
                return t.Right;
            }
        }

        protected void Remove(TreeNode<T> t)
        {
            if (t == null)
            {
                throw new ItemNotFoundException("Item not found");
            }
            else if (t.Left == null && t.Right == null)
            {
                // If the node has no children, we remove the node and update
                // the parent so that it does not refer to a non-existent node.
                treeNodes.Remove(t);
                // update 
                updateParent(t, null);
                if (treeNodes.Count == 0)
                {
                    this.Root = null;
                }

            }
            else if(t.Left != null && t.Right != null)
            {
                // if node has both children, set its element to be the element of the
                // leftmost child of the node's right child. Note that we're not
                // replacing the node with a new node so the parent and the level
                // don't need to be updated.
                t.Element = FindMin(t.Right);
                t.Right = RemoveMin(t.Right);
            }
            else
            // the node has only one child
            {
                TreeNode<T> parent = t.Parent;
                int level = t.Level;
                treeNodes.Remove(t);
                if (t.Left != null)
                {
                    updateLevels(t.Left);
                    updateParent(t, t.Left);
                    if (t == this.Root)
                    // we are replacing the root with another node
                    // so need to update the root
                    {
                        this.Root = t.Left;
                        this.Root.Parent = null;
                    }
                    else
                    {
                        t = t.Left;
                    }
                    
                }
                else if (t.Right != null)
                {
                    updateLevels(t.Right);
                    updateParent(t, t.Right);
                    if (t == this.Root)
                        // we are replacing the root with another node
                        // so need to update the root
                    {
                        this.Root = t.Right;
                        this.Root.Parent = null;
                    }
                    else
                    {
                        t = t.Right;
                    }
                    
                }
                //if (t != null)
                //{
                //t.Level = level;
                t.Parent = parent;
                //}
                
            }
            // DEBUG

            //return t;
        }

        public override string ToString()
        {
            return this.Root.ToString();
        }

        public int getMaxLevel()
        { 
            // Returns the maximum level of the tree
            int maxLevel = -1;
            foreach (TreeNode<T> t in treeNodes)
            {
                if (t.Level > maxLevel) maxLevel = t.Level;
            }
            return maxLevel;
        }

        public void updateLevels(TreeNode<T> t)
        {
            // Update child nodes' levels after node removal
            if (t == null) return;
            t.Level -= 1;
            if (t.Left != null)
            {
                updateLevels(t.Left);
            }
            if (t.Right != null)
            {
                updateLevels(t.Right);
            }
        }

        public void updateParent(TreeNode<T> t, TreeNode<T> updatedNode)
        {
            // This method will update the node parent when a node is removed
            // that has child nodes
            if (t.Parent != null)
            {
                if (t.Parent.Left == t)
                {
                    t.Parent.Left = updatedNode;
                }
                else if (t.Parent.Right == t)
                {
                    t.Parent.Right = updatedNode;
                }
            }
        }

        public string printDebugInfo()
        {
            // This method will advise user of a potential problem
            // when a node refers to a non-existent node as its parent or left or right
            // child
            foreach (TreeNode<T> tr in treeNodes)
            {
                if ((tr.Parent != null && !treeNodes.Contains(tr.Parent)) ||
                    (tr.Left != null && !treeNodes.Contains(tr.Left)) ||
                    (tr.Right != null && !treeNodes.Contains(tr.Right)))
                {
                    string parent = (tr.Parent == null) ? "null" : tr.Parent.Element.ToString();
                    string left = (tr.Left == null) ? "null" : tr.Left.Element.ToString();
                    string right = (tr.Right == null) ? "null" : tr.Right.Element.ToString();
                    return (String.Format("{0} Parent {1} Left {2} Right {3}",
                                    tr.Element.ToString(), parent, left, right));
                }
            }

            return "";
        }

    }
}
