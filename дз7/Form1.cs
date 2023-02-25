using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace дз7
{
    public partial class Form1 : Form
    {
        string openPath = "";
        public Form1()
        {
            InitializeComponent();
            richTextBox1.ContextMenuStrip = contextMenuStrip1;
          
        }

        public void SaveFile(string path)
        {
            StreamWriter writer = new StreamWriter(path);
            writer.Write(richTextBox1.Text);
            writer.Close();
        }
        public void SaveFileAs(string path)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Text Files(*.txt)|*.txt";
            saveFile.DefaultExt = "txt";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                openPath = saveFile.FileName;
                SaveFile(saveFile.FileName);
            }
        }
        public void OpenFile()
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "All Files(*.*)|*.*|Text Files(*.txt)|*.txt";
            openFile.FilterIndex = 2;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                openPath = openFile.FileName;
                StreamReader reader = File.OpenText(openFile.FileName);

                richTextBox1.Text = reader.ReadToEnd();

                reader.Close();
                this.Text = openFile.FileName;
            }
            
        }
        public void FontEdit()
        {
            FontDialog font = new FontDialog();
            font.Font = richTextBox1.Font;
            if (font.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = font.Font;
            }
        }
        public void ColorEdit()
        {
            ColorDialog color = new ColorDialog();
            color.Color = richTextBox1.ForeColor;
            if (color.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = color.Color;
            }
        }
        public void BackColorEdit()
        {
            ColorDialog color = new ColorDialog();
            color.Color = richTextBox1.BackColor;
            if (color.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.BackColor = color.Color;
            }
           
        }
        public void NewDocument()
        {
            if (openPath != "")
            {
              
                DialogResult result = MessageBox.Show("Save change", "Massage", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                switch (result)
                {
                    case DialogResult.OK:
                        SaveFile(openPath);
                        break;
                    case DialogResult.Cancel:
                        break;
                }
               
                this.Text = "";
            }
            richTextBox1.ResetText();
            richTextBox1.BackColor = Color.White;
           
        }

       

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openPath == "")
            {
                SaveFileAs(openPath);
            }
            else SaveFile(openPath);
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileAs(openPath);
        }

        private void newDocumentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewDocument();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void colorEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColorEdit();
        }

        private void colorFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorEdit();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontEdit();
        }

        private void selecAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }
    }
}
