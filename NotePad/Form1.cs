using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotePad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog omkar = new OpenFileDialog();
            omkar.Title = "Open";
            omkar.Filter = "Text Documents(*.txt)|*.txt|All Files(*.*)|*.*";
            if (omkar.ShowDialog() == DialogResult.OK)
                richTextBox1.LoadFile(omkar.FileName, RichTextBoxStreamType.PlainText);
            this.Text = omkar.FileName;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog omkar = new SaveFileDialog();
            omkar.Title = "Save";
            omkar.Filter = "Text Documents(*.txt)|*.txt|All Files(*.*)|*.*";
            if (omkar.ShowDialog() == DialogResult.OK)
                richTextBox1.SaveFile(omkar.FileName, RichTextBoxStreamType.PlainText);
            this.Text = omkar.FileName;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timeDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = System.DateTime.Now.ToString();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void selcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fnt = new FontDialog();
            if(fnt.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fnt.Font;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog fnt = new ColorDialog();
            if (fnt.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.ForeColor = fnt.Color;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
