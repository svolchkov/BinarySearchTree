using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinarySearchTree
{

    public partial class Form1 : Form
    {
        private const int CIRCLE_SIZE = 30;
        public const int MAX_NODES = 30;
        private const int MAX_LEVELS = 10;
        private const int MAX_NODE_VALUE = 500;
        private const int HIGHLIGHT_OFFSET = 2; // to avoid highlight circles getting cut off
        private System.Drawing.Graphics g;
        private System.Drawing.Pen pen1 = new System.Drawing.Pen(Color.Black, 2F);
        BinarySearchTree_<int> intTree;
        public static int totalTreeNodes;
        private Bitmap nodeLinkImage;
        private Bitmap nodeImage;
        int highlightedNode = 0;

        public Form1()
        {
            InitializeComponent();

        }

        private void btnNewTree_Click(object sender, EventArgs e)
        {
            // Asks the user for the desired number of nodes in the tree
            // and then generates the tree using random numbers
            totalTreeNodes = 0;
            NodesNumber n = new NodesNumber();
            n.ShowDialog();
            if (totalTreeNodes < 1 || totalTreeNodes > MAX_NODES) return;
            intTree = new BinarySearchTree_<int>();
            Random r = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < totalTreeNodes; i++)
            {
                bool itemCreated = false;
                while (!itemCreated)
                {
                    try
                    {
                        int randomInt = r.Next(1, MAX_NODE_VALUE);
                        intTree.Insert(randomInt);
                        itemCreated = true;
                    }
                    catch (DuplicateItemException die)
                    {
                    }
                }

            }
            highlightedNode = 0;
            pbTree.Refresh();
            lblInfo.Text = "";
            lblTrace.Text = "";
            //drawTree(intTree, 0);
        }

        private void drawTree(BinarySearchTree_<int> intTree, int highlightItem)
        {
            // Tree Painting Routine. First draws the connections between
            // the nodes and then the actual nodes
            if (intTree != null)
            {
                Bitmap result = new Bitmap(pbTree.Width, pbTree.Height);
                using (Graphics g = Graphics.FromImage(result))
                {
                    nodeLinkImage = new Bitmap(pbTree.Width, pbTree.Height);
                    Graphics gb = Graphics.FromImage(nodeLinkImage);
                    nodeImage = new Bitmap(pbTree.Width, pbTree.Height, PixelFormat.Format32bppArgb);
                    Graphics gn = Graphics.FromImage(nodeImage);
                    gn.Clear(Color.Transparent);
                    int totalLevels = intTree.getMaxLevel() + 1;
                    int treeMin = intTree.FindMin();
                    int treeMax = intTree.FindMax();
                    //g = pbTree.CreateGraphics();
                    g.Clear(this.BackColor);
                    Font boldFont = new Font(this.Font, FontStyle.Bold);
                    SizeF s = g.MeasureString(treeMax.ToString(), boldFont);
                    int span = treeMax - treeMin;
                    int totalNodes = intTree.treeNodes.Count;
                    int width = pbTree.Width - CIRCLE_SIZE - HIGHLIGHT_OFFSET * 2;
                    int height = pbTree.Height - CIRCLE_SIZE - HIGHLIGHT_OFFSET * 2;
                    int widthIncrement = (int)((double)width / totalNodes);
                    int heightIncrement = (int)((double)height / totalLevels);
                    //g = pbTree.CreateGraphics();
                    //g.DrawLine(pen1, 250, 50, 400, 200);
                    List<TreeNode<int>> sortedList = intTree.treeNodes.OrderBy(o => o.Element).ToList();
                    List<int> elements = sortedList.Select(o => o.Element).ToList();
                    int x = HIGHLIGHT_OFFSET;
                    foreach (TreeNode<int> t in sortedList)
                    {
                        int y = t.Level * heightIncrement + HIGHLIGHT_OFFSET;
                        RectangleF rect = new RectangleF(x, y, CIRCLE_SIZE, CIRCLE_SIZE);
                        Brush brush1 = Brushes.Black;
                        if (t.Parent != null)
                        {
                            int parentX = elements.IndexOf(t.Parent.Element) * widthIncrement + CIRCLE_SIZE / 2;
                            int parentY = t.Parent.Level * heightIncrement + CIRCLE_SIZE / 2;
                            gb.DrawLine(pen1, parentX, parentY, x + CIRCLE_SIZE / 2, y + CIRCLE_SIZE / 2);
                        }
                        gn.FillEllipse(brush1, rect);
                        StringFormat stringFormat = new StringFormat()
                        {
                            Alignment = StringAlignment.Center,
                            LineAlignment = StringAlignment.Center
                        };
                        string text = t.Element.ToString();
                        float fontScale = Math.Max(s.Width / rect.Width, s.Height / rect.Height);
                        //                   using (Font font = new Font(boldFont.FontFamily, boldFont.SizeInPoints / fontScale, GraphicsUnit.Point))
                        using (Font font = new Font(this.Font.FontFamily, this.Font.SizeInPoints / fontScale, FontStyle.Bold))
                        {
                            gn.DrawString(text, font, Brushes.White, rect, stringFormat);
                        }
                        if (highlightItem != 0 && t.Element == highlightItem)
                        {
                            Pen highlightPen = new System.Drawing.Pen(Color.Red, 2F); ;
                            //int highlightX = elements.IndexOf(t.Element) * widthIncrement - 2;
                            //int highlightY = t.Level * heightIncrement - 2;
                            RectangleF rectHighlight = new RectangleF(x - 2, y - 2, CIRCLE_SIZE + 4, CIRCLE_SIZE + 4);
                            gn.DrawEllipse(highlightPen, rectHighlight);
                        }

                        x += widthIncrement;
                    }
                    g.DrawImage(nodeLinkImage, 0, 0);
                    g.DrawImage(nodeImage, 0, 0);
                    pbTree.Image = result;
                }
            }
            else
            {
                pbTree.Image = null;
                pbTree.BackColor = SystemColors.Control;
            }
                
            
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            lblInfo.Text = "";
            if (intTree != null && (intTree.treeNodes.Count >= MAX_NODES 
                || intTree.getMaxLevel() >= MAX_LEVELS))
            {
                lblInfo.Text = String.Format("No more than {0} nodes or {1} levels allowed", 
                    MAX_NODES.ToString(), MAX_LEVELS.ToString());
                return;
            }
            if (tbNode.Text != String.Empty)
            {
                int currentNode = 0;
                if (Int32.TryParse(tbNode.Text, out currentNode))
                {
                    if (currentNode > MAX_NODE_VALUE || currentNode < 1)
                    {
                        lblInfo.Text = "Allowed node values greater than 0 and less than " + MAX_NODE_VALUE.ToString();
                    }
                    else
                    {
                        try
                        {
                            intTree.Insert(currentNode);
                            highlightedNode = currentNode;
                            pbTree.Refresh();
                            lblInfo.Text = "";
                            //drawTree(intTree, currentNode);
                        }
                        catch (DuplicateItemException die)
                        {
                            highlightedNode = 0;
                            //MessageBox.Show("Item exists " + currentNode);
                            lblInfo.Text = "Item exists " + currentNode;
                            lblInfo.ForeColor = Color.Red;
                        }
                        catch (NullReferenceException nre)
                        {
                            intTree = new BinarySearchTree_<int>();
                            intTree.Insert(currentNode);
                            highlightedNode = currentNode;
                            //drawTree(intTree,node);
                            pbTree.Refresh();
                        }
                    }
                }
                
            }
        }

        private void highlightNode(int node)
        {
            //int totalLevels = intTree.getMaxLevel() + 1;
            //int treeMin = intTree.FindMin();
            //int treeMax = intTree.FindMax();
            //g = pbTree.CreateGraphics();
            //int span = treeMax - treeMin;
            //int totalNodes = intTree.treeNodes.Count;
            //int width = pbTree.Width - CIRCLE_SIZE;
            //int height = pbTree.Height - CIRCLE_SIZE;
            //int widthIncrement = (int)((double)width / totalNodes);
            //int heightIncrement = (int)((double)height / totalLevels);
            //List<TreeNode<int>> sortedList = intTree.treeNodes.OrderBy(o => o.Element).ToList();
            //List<int> elements = sortedList.Select(o => o.Element).ToList();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            lblDebug.Text = "";
            if (tbNode.Text != String.Empty)
            {
                int currentNode = 0;
                if (Int32.TryParse(tbNode.Text, out currentNode))
                {
                    int node = 0;
                    try
                        {
                            node = intTree.Find(currentNode);
                        }
                    catch (NullReferenceException nre)
                        {
                            lblInfo.Text = "Tree is empty";
                            return;
                        }
                    
                    if (node != 0)
                    {
                        highlightedNode = node;
                        //drawTree(intTree,node);
                        pbTree.Refresh();
                        lblInfo.Text = "";
                    }
                    else
                    {
                        highlightedNode = 0;
                        pbTree.Refresh();
                        //MessageBox.Show("Item " + currentNode + " not found");
                        lblInfo.Text = "Item " + currentNode + " not found";
                        lblInfo.ForeColor = Color.Red;
                    }
                }
            }
        }

        private void pbTree_Paint(object sender, PaintEventArgs e)
        {
            //if (intTree != null && intTree.treeNodes.Count > 0)
            //if (intTree != null)
            //{
                drawTree(intTree, highlightedNode);
            //} 
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            lblDebug.Text = "";
            highlightedNode = 0;
            if (tbNode.Text != String.Empty)
            {
                int currentNode = 0;
                if (Int32.TryParse(tbNode.Text, out currentNode))
                {
                    try
                    {
                        intTree.Remove(currentNode);
                        lblInfo.Text = "Item " + tbNode.Text + " removed";
                        lblInfo.ForeColor = Color.Black;
                        if (intTree.treeNodes.Count == 0) intTree = null;
                        pbTree.Refresh();
                    }
                    catch (ItemNotFoundException ife)
                    {
                        lblInfo.Text = "Item " + tbNode.Text + " not found";
                        lblInfo.ForeColor = Color.Red;
                    }
                    catch (NullReferenceException nre)
                    {
                        lblInfo.Text = "Tree is empty";
                    }
                }
            }
            if (intTree != null) lblDebug.Text = intTree.printDebugInfo();
                  
        }

        private void btnRemoveMin_Click(object sender, EventArgs e)
        {
            lblInfo.Text = "";
            lblInfo.ForeColor = Color.Black;
            highlightedNode = 0;
            if (intTree != null)
            {
                int minNode = intTree.FindMin();
                intTree.RemoveMin();
                lblInfo.Text = "Item " + minNode + " removed";
                lblDebug.Text = intTree.printDebugInfo();
                if (intTree.treeNodes.Count == 0)
                {
                    intTree = null;
                }
            }
            else
            {
                lblInfo.Text = "Tree is empty";
            }
        }

        private void btnFindMin_Click(object sender, EventArgs e)
        {
            lblInfo.Text = "";
            if (intTree != null)
            {
                highlightedNode = intTree.FindMin();
                pbTree.Refresh();
            }
            else
            {
                lblInfo.Text = "Tree is empty";
            }
        }

        private void btnFindMax_Click(object sender, EventArgs e)
        {
            lblInfo.Text = "";
            if (intTree != null)
            {
                highlightedNode = intTree.FindMax();
                pbTree.Refresh();
            }
            else
            {
                lblInfo.Text = "Tree is empty";
            }
        }

        private void btnEmptyTree_Click(object sender, EventArgs e)
        {
            lblInfo.Text = "";
            lblTrace.Text = "";
            if (intTree != null)
            {
                intTree.MakeEmpty();
                intTree = null;
                pbTree.Refresh();
            }
            lblInfo.Text = "Tree is empty";
        }

        private void btnTrace_Click(object sender, EventArgs e)
        {
            if (intTree != null)
            {
                StringBuilder trace = new StringBuilder();
                trace.Append("Trace: ");
                foreach (TreeNode<int> n in intTree.treeNodes)
                {
                    trace.Append(n.Element.ToString() + " ");
                }
                lblTrace.Text = trace.ToString();
            }
        }
    }
    




}

