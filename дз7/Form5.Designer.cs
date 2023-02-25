
namespace дз7
{
    partial class Form5
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.створитиПапкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видалитиПапкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.створитиПапкуToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.видалитиПапкуToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(263, 97);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(503, 341);
            this.textBox1.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(27, 48);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(212, 390);
            this.treeView1.TabIndex = 1;
            this.treeView1.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView1_BeforeExpand);
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(263, 48);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(503, 27);
            this.textBox2.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.створитиПапкуToolStripMenuItem,
            this.видалитиПапкуToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // створитиПапкуToolStripMenuItem
            // 
            this.створитиПапкуToolStripMenuItem.Name = "створитиПапкуToolStripMenuItem";
            this.створитиПапкуToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.створитиПапкуToolStripMenuItem.Text = "Створити папку";
            this.створитиПапкуToolStripMenuItem.Click += new System.EventHandler(this.createFolderButton_Click);
            // 
            // видалитиПапкуToolStripMenuItem
            // 
            this.видалитиПапкуToolStripMenuItem.Name = "видалитиПапкуToolStripMenuItem";
            this.видалитиПапкуToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.видалитиПапкуToolStripMenuItem.Text = "Видалити папку";
            this.видалитиПапкуToolStripMenuItem.Click += new System.EventHandler(this.deleteFolderButton_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.створитиПапкуToolStripMenuItem1,
            this.видалитиПапкуToolStripMenuItem1});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(242, 80);
            // 
            // створитиПапкуToolStripMenuItem1
            // 
            this.створитиПапкуToolStripMenuItem1.Name = "створитиПапкуToolStripMenuItem1";
            this.створитиПапкуToolStripMenuItem1.Size = new System.Drawing.Size(241, 24);
            this.створитиПапкуToolStripMenuItem1.Text = "Створити папку";
            this.створитиПапкуToolStripMenuItem1.Click += new System.EventHandler(this.createFolderButton_Click);
            // 
            // видалитиПапкуToolStripMenuItem1
            // 
            this.видалитиПапкуToolStripMenuItem1.Name = "видалитиПапкуToolStripMenuItem1";
            this.видалитиПапкуToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.видалитиПапкуToolStripMenuItem1.Size = new System.Drawing.Size(241, 24);
            this.видалитиПапкуToolStripMenuItem1.Text = "Видалити папку";
            this.видалитиПапкуToolStripMenuItem1.Click += new System.EventHandler(this.deleteFolderButton_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.contextMenuStrip2;
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form5";
            this.Text = "Form5";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem створитиПапкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видалитиПапкуToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem створитиПапкуToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem видалитиПапкуToolStripMenuItem1;
    }
}