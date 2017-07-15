using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinarySearchTree
{
    public partial class NodesNumber : Form
    {
        public NodesNumber()
        {
            InitializeComponent();
        }

        private void tbNodesNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (tbNodesNumber.Text != String.Empty)
                {
                    int numberOfNodes = 0;
                    if (Int32.TryParse(tbNodesNumber.Text, out numberOfNodes))
                    {
                        if (numberOfNodes > Form1.MAX_NODES)
                        {
                            lblError.Text = "Up to " + Form1.MAX_NODES + " nodes allowed";
                            return;
                        }
                        else if (numberOfNodes < 1) {
                            lblError.Text = "Number of nodes must be positive";
                            return;
                        }   
                        else
                        {
                            Form1.totalTreeNodes = numberOfNodes;
                            e.Handled = true;
                            e.SuppressKeyPress = true;
                            this.Close();
                        }
                    }
                }
            }
        }
    }
}
