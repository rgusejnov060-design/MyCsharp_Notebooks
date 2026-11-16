using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace bloknot_2
{
    public partial class Form1 : Form
    {
        public string fname;
        public Form1()
        {
            InitializeComponent();
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fname = null;
            richTextBox1.Clear();
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fname = saveFileDialog1.FileName;
                File.WriteAllText(fname, richTextBox1.Text);
            }
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                fname=openFileDialog1.FileName;
                richTextBox1.Text   = File.ReadAllText(fname);
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fname == null || fname == "")
            {
                MessageBox.Show("Файл не найден");
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    fname = saveFileDialog1.FileName;
                    File.WriteAllText(fname, richTextBox1.Text);
                }
            }
            else
            {
                File.WriteAllText(fname, richTextBox1.Text);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
