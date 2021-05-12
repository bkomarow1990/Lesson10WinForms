
namespace TreeViewLesson10
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Vadim");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Alex");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Proggramers", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Designers");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("System Engineers");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SmallIcons = new System.Windows.Forms.ImageList(this.components);
            this.StateIcons = new System.Windows.Forms.ImageList(this.components);
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusActivateInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.CheckBoxes = true;
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.SmallIcons;
            this.treeView1.LabelEdit = true;
            this.treeView1.Location = new System.Drawing.Point(32, 36);
            this.treeView1.Name = "treeView1";
            treeNode1.ImageIndex = 1;
            treeNode1.Name = "Node3";
            treeNode1.Text = "Vadim";
            treeNode2.ImageIndex = 1;
            treeNode2.Name = "Node7";
            treeNode2.Text = "Alex";
            treeNode3.Name = "Node0";
            treeNode3.Text = "Proggramers";
            treeNode4.Name = "Node1";
            treeNode4.Text = "Designers";
            treeNode5.Name = "Node2";
            treeNode5.Text = "System Engineers";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4,
            treeNode5});
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(413, 264);
            this.treeView1.StateImageList = this.StateIcons;
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterCheck);
            this.treeView1.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView1_BeforeExpand);
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // SmallIcons
            // 
            this.SmallIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("SmallIcons.ImageStream")));
            this.SmallIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.SmallIcons.Images.SetKeyName(0, "student_cap.png");
            this.SmallIcons.Images.SetKeyName(1, "Student-id-icon.png");
            this.SmallIcons.Images.SetKeyName(2, "student-icon.png");
            this.SmallIcons.Images.SetKeyName(3, "Professor-icon.png");
            // 
            // StateIcons
            // 
            this.StateIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("StateIcons.ImageStream")));
            this.StateIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.StateIcons.Images.SetKeyName(0, "math-minus-icon.png");
            this.StateIcons.Images.SetKeyName(1, "add-icon.png");
            this.StateIcons.Images.SetKeyName(2, "blue-plus-icon.png");
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(452, 36);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(116, 20);
            this.nameTxtBox.TabIndex = 1;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(452, 63);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(116, 23);
            this.addBtn.TabIndex = 2;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(451, 92);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(116, 23);
            this.deleteBtn.TabIndex = 3;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusInfo,
            this.toolStripStatusActivateInfo});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusInfo
            // 
            this.toolStripStatusInfo.Name = "toolStripStatusInfo";
            this.toolStripStatusInfo.Size = new System.Drawing.Size(28, 17);
            this.toolStripStatusInfo.Text = "Info";
            // 
            // toolStripStatusActivateInfo
            // 
            this.toolStripStatusActivateInfo.Name = "toolStripStatusActivateInfo";
            this.toolStripStatusActivateInfo.Size = new System.Drawing.Size(71, 17);
            this.toolStripStatusActivateInfo.Text = "ActivateInfo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.nameTxtBox);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ImageList SmallIcons;
        private System.Windows.Forms.ImageList StateIcons;
        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusInfo;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusActivateInfo;
    }
}

