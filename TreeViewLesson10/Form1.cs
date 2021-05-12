using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeViewLesson10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            toolStripStatusInfo.Text = $"{e.Node}";
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try { 
            if (String.IsNullOrWhiteSpace(nameTxtBox.Text))
            {
                throw new ApplicationException("Incorrecct Name");
            }
            TreeNode treeNode = new TreeNode(nameTxtBox.Text, 1,2);
                if (treeView1.Nodes.Count == 0  )
                {
                    treeView1.Nodes.Add(treeNode);
                    return;
                }
            treeView1.SelectedNode.Nodes.Add(nameTxtBox.Text);
            //treeView1.SelectedNode.Expand();
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string []roots= new string[3];
            if (treeView1.SelectedNode == null)
            {
                MessageBox.Show("Empty");
                return;
            }
            if (true)//treeView1.SelectedNode.Text.Contains())
            {

            }
            treeView1.SelectedNode.Remove();
        }

        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
            toolStripStatusActivateInfo.Text = $"{e.Node} Path: {e.Node.FullPath}";
        }

        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            //e.Node.Nodes.Add("NoName");
        }
    }
}
