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

namespace Lab9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DirectoryInfo dir = new DirectoryInfo(textBox1.Text.ToString());
            int Size = int.Parse(textBox2.Text);
            FileInfo[] infos = dir.GetFiles();
            FilesNames.Items.Clear();
            var get = from i in infos where i.Length <= Size select i;
            foreach (var i in get)
            {
                FilesNames.Items.Add(i.Name);
            }
        }
    }
}
