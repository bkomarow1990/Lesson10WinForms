using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ListViewItem;

namespace Explorer
{
    public partial class Form1 : Form
    {
        string current;
        public Form1()
        {
            InitializeComponent();
            var drives = DriveInfo.GetDrives();
            foreach (var item in drives)
            {
                treeView1.Nodes.Add(item.Name);
            }
            
            //string[] directoryInfoD = Directory.GetDirectories("D:/");
            //string[] filesC = Directory.GetFiles("C:/");
            //string[] filesD = Directory.GetFiles("D:/");
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                //MessageBox.Show(e.Node.FullPath);
                string[] directories = Directory.GetDirectories(e.Node.FullPath);
                ListView ls;
                listView1.Items.Clear();
                string size,name,date;
                foreach (var item in directories)
                {
                    name = new FileInfo(item).Name;
                    listView1.Items.Add(name,0);
                    listView1.Items[listView1.Items.Count - 1].Group = listView1.Groups[0];
                    e.Node.Nodes.Add(new TreeNode(new DirectoryInfo(item).Name, 0, 0));
                    date = new FileInfo(item).CreationTime.ToString();
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(new ListViewSubItem());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(new ListViewSubItem());
                    listView1.Items[listView1.Items.Count - 1].SubItems[2].Text = date;
                }
                string[] files = Directory.GetFiles(e.Node.FullPath);
                
                foreach (var item in files)
                {
                    name = new DirectoryInfo(item).Name;
                    date = new FileInfo(item).CreationTime.ToString();
                    listView1.Items.Add(name, 1);
                    listView1.Items[listView1.Items.Count-1].Group = listView1.Groups[1];
                    size = (new FileInfo(item).Length).ToString();
                    e.Node.Nodes.Add(new TreeNode(new DirectoryInfo(item).Name, 1, 1));
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(new ListViewSubItem());
                    
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(new ListViewSubItem());
                    listView1.Items[listView1.Items.Count - 1].SubItems[1].Text = size;// = new ListViewSubItem(listView1.Items[listView1.Items.Count-1],size);
                    listView1.Items[listView1.Items.Count - 1].SubItems[2].Text = date;// = new ListViewSubItem(listView1.Items[listView1.Items.Count-1],size);
                }
                //listView1.Items[listView1.Items.Count - 1].Tag = new List<string>(item);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (listView1.SelectedItems.Count == 0)
            //{
            //    throw new Exception("Empty");
            //}
            

        }

        private void listView1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems == null)
            {
                throw new Exception("Empty");
            }
            
            //listView1.SelectedItems[0].Tag[0]
        }
    }
}
