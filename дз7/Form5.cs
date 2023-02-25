using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace дз7
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();

            GetFolder();
        }

        private void GetFolder()
        {
            foreach (var drive in DriveInfo.GetDrives())
            {
                var node = new TreeNode(drive.Name);
                node.Tag = drive.RootDirectory;
                node.Nodes.Add(""); 
                treeView1.Nodes.Add(node);
            }
        }
        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            var currentNode = e.Node;
            if (currentNode.Nodes.Count == 1 && currentNode.Nodes[0].Text == "")
            {

                currentNode.Nodes.RemoveAt(0);
                try
                {
                    var directories = Directory.GetDirectories(currentNode.Tag.ToString());
                    textBox2.Text = currentNode.Tag.ToString();
                    foreach (var directory in directories)
                    {
                        var node = new TreeNode(Path.GetFileName(directory));
                        node.Tag = directory;
                        node.Nodes.Add(""); 
                        currentNode.Nodes.Add(node);
                    }
                }
                catch (UnauthorizedAccessException)
                {
                    
                }
            }
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            
            if (Directory.Exists(e.Node.Tag.ToString()))
            {
                
                textBox1.Clear();
                var files = Directory.GetFiles(e.Node.Tag.ToString());
                foreach (var file in files)
                {
                    textBox1.AppendText(file + Environment.NewLine);
                }
            }
        }
      
        private void createFolderButton_Click(object sender, EventArgs e)
        {
            
            var selectedNode = treeView1.SelectedNode;
            if (selectedNode == null)
            {
                MessageBox.Show("Оберіть вузол для створення нової папки", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
              var currentPath = selectedNode.Tag.ToString();

            try
            {
                var newFolderName = "Нова папка";
                var i = 1;
                while (Directory.Exists(Path.Combine(currentPath, newFolderName)))
                {
                    newFolderName = $"Нова папка ({i++})";
                }
                var newFolderPath = Path.Combine(currentPath, newFolderName);
                Directory.CreateDirectory(newFolderPath);

                var newNode = new TreeNode(newFolderName);
                newNode.Tag = newFolderPath;
                newNode.Nodes.Add(""); 
                selectedNode.Nodes.Add(newNode);

                selectedNode.Expand();
                newNode.EnsureVisible();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при створенні нової папки: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void deleteFolderButton_Click(object sender, EventArgs e)
        {
            var selectedNode = treeView1.SelectedNode;
            if (selectedNode == null || selectedNode.Tag == null)
            {
                MessageBox.Show("Оберіть папку для видалення", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var currentPath = selectedNode.Tag.ToString();

            var result = MessageBox.Show($"Ви впевнені, що хочете видалити папку {currentPath} та всі файли в ній?", "Info", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                try
                {
                    Directory.Delete(currentPath);
                    Console.WriteLine($"Папка {currentPath} видалена успішно.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Помилка при видаленні папки {currentPath}: {ex.Message}");
                }
                treeView1.SelectedNode.Remove();
               
            }
        }

    }
}
    

