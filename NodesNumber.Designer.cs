namespace BinarySearchTree
{
    partial class NodesNumber
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbNodesNumber = new System.Windows.Forms.TextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the desired number of nodes: ";
            // 
            // tbNodesNumber
            // 
            this.tbNodesNumber.Location = new System.Drawing.Point(289, 29);
            this.tbNodesNumber.Name = "tbNodesNumber";
            this.tbNodesNumber.Size = new System.Drawing.Size(49, 22);
            this.tbNodesNumber.TabIndex = 1;
            this.tbNodesNumber.Text = "20";
            this.tbNodesNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbNodesNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbNodesNumber_KeyDown);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(31, 53);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 17);
            this.lblError.TabIndex = 2;
            // 
            // NodesNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 78);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.tbNodesNumber);
            this.Controls.Add(this.label1);
            this.Name = "NodesNumber";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNodesNumber;
        private System.Windows.Forms.Label lblError;
    }
}