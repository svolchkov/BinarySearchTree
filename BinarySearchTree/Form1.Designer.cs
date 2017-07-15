namespace BinarySearchTree
{
    partial class Form1
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
            this.pbTree = new System.Windows.Forms.PictureBox();
            this.btnNewTree = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.tbNode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblDebug = new System.Windows.Forms.Label();
            this.btnRemoveMin = new System.Windows.Forms.Button();
            this.btnFindMin = new System.Windows.Forms.Button();
            this.btnFindMax = new System.Windows.Forms.Button();
            this.btnEmptyTree = new System.Windows.Forms.Button();
            this.btnTrace = new System.Windows.Forms.Button();
            this.lblTrace = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbTree)).BeginInit();
            this.SuspendLayout();
            // 
            // pbTree
            // 
            this.pbTree.Location = new System.Drawing.Point(23, 21);
            this.pbTree.Name = "pbTree";
            this.pbTree.Size = new System.Drawing.Size(632, 500);
            this.pbTree.TabIndex = 0;
            this.pbTree.TabStop = false;
            this.pbTree.Paint += new System.Windows.Forms.PaintEventHandler(this.pbTree_Paint);
            // 
            // btnNewTree
            // 
            this.btnNewTree.Location = new System.Drawing.Point(49, 550);
            this.btnNewTree.Name = "btnNewTree";
            this.btnNewTree.Size = new System.Drawing.Size(105, 23);
            this.btnNewTree.TabIndex = 1;
            this.btnNewTree.Text = "New Tree";
            this.btnNewTree.UseVisualStyleBackColor = true;
            this.btnNewTree.Click += new System.EventHandler(this.btnNewTree_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(490, 576);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 2;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // tbNode
            // 
            this.tbNode.Location = new System.Drawing.Point(587, 527);
            this.tbNode.Name = "tbNode";
            this.tbNode.Size = new System.Drawing.Size(57, 22);
            this.tbNode.TabIndex = 3;
            this.tbNode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(487, 528);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter node #";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(490, 549);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 5;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(580, 549);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblInfo.Location = new System.Drawing.Point(276, 603);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(368, 17);
            this.lblInfo.TabIndex = 7;
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDebug
            // 
            this.lblDebug.AutoSize = true;
            this.lblDebug.ForeColor = System.Drawing.Color.Red;
            this.lblDebug.Location = new System.Drawing.Point(20, 603);
            this.lblDebug.Name = "lblDebug";
            this.lblDebug.Size = new System.Drawing.Size(0, 17);
            this.lblDebug.TabIndex = 8;
            // 
            // btnRemoveMin
            // 
            this.btnRemoveMin.Location = new System.Drawing.Point(170, 550);
            this.btnRemoveMin.Name = "btnRemoveMin";
            this.btnRemoveMin.Size = new System.Drawing.Size(98, 23);
            this.btnRemoveMin.TabIndex = 9;
            this.btnRemoveMin.Text = "Remove Min";
            this.btnRemoveMin.UseVisualStyleBackColor = true;
            this.btnRemoveMin.Click += new System.EventHandler(this.btnRemoveMin_Click);
            // 
            // btnFindMin
            // 
            this.btnFindMin.Location = new System.Drawing.Point(296, 550);
            this.btnFindMin.Name = "btnFindMin";
            this.btnFindMin.Size = new System.Drawing.Size(75, 23);
            this.btnFindMin.TabIndex = 10;
            this.btnFindMin.Text = "Find Min";
            this.btnFindMin.UseVisualStyleBackColor = true;
            this.btnFindMin.Click += new System.EventHandler(this.btnFindMin_Click);
            // 
            // btnFindMax
            // 
            this.btnFindMax.Location = new System.Drawing.Point(296, 576);
            this.btnFindMax.Name = "btnFindMax";
            this.btnFindMax.Size = new System.Drawing.Size(75, 23);
            this.btnFindMax.TabIndex = 11;
            this.btnFindMax.Text = "Find Max";
            this.btnFindMax.UseVisualStyleBackColor = true;
            this.btnFindMax.Click += new System.EventHandler(this.btnFindMax_Click);
            // 
            // btnEmptyTree
            // 
            this.btnEmptyTree.Location = new System.Drawing.Point(49, 579);
            this.btnEmptyTree.Name = "btnEmptyTree";
            this.btnEmptyTree.Size = new System.Drawing.Size(105, 23);
            this.btnEmptyTree.TabIndex = 12;
            this.btnEmptyTree.Text = "Empty Tree";
            this.btnEmptyTree.UseVisualStyleBackColor = true;
            this.btnEmptyTree.Click += new System.EventHandler(this.btnEmptyTree_Click);
            // 
            // btnTrace
            // 
            this.btnTrace.Location = new System.Drawing.Point(391, 550);
            this.btnTrace.Name = "btnTrace";
            this.btnTrace.Size = new System.Drawing.Size(75, 23);
            this.btnTrace.TabIndex = 13;
            this.btnTrace.Text = "Trace";
            this.btnTrace.UseVisualStyleBackColor = true;
            this.btnTrace.Click += new System.EventHandler(this.btnTrace_Click);
            // 
            // lblTrace
            // 
            this.lblTrace.AutoSize = true;
            this.lblTrace.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrace.Location = new System.Drawing.Point(20, 524);
            this.lblTrace.MaximumSize = new System.Drawing.Size(450, 0);
            this.lblTrace.Name = "lblTrace";
            this.lblTrace.Size = new System.Drawing.Size(0, 13);
            this.lblTrace.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 629);
            this.Controls.Add(this.lblTrace);
            this.Controls.Add(this.btnTrace);
            this.Controls.Add(this.btnEmptyTree);
            this.Controls.Add(this.btnFindMax);
            this.Controls.Add(this.btnFindMin);
            this.Controls.Add(this.btnRemoveMin);
            this.Controls.Add(this.lblDebug);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNode);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnNewTree);
            this.Controls.Add(this.pbTree);
            this.Name = "Form1";
            this.Text = "Binary Tree";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pbTree)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbTree;
        private System.Windows.Forms.Button btnNewTree;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox tbNode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblInfo;
        public System.Windows.Forms.Label lblDebug;
        private System.Windows.Forms.Button btnRemoveMin;
        private System.Windows.Forms.Button btnFindMin;
        private System.Windows.Forms.Button btnFindMax;
        private System.Windows.Forms.Button btnEmptyTree;
        private System.Windows.Forms.Button btnTrace;
        private System.Windows.Forms.Label lblTrace;
    }
}

