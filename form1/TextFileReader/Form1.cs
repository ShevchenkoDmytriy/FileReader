using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextFileReader
{
    public partial class Form1 : Form
    {
        public string MainText {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            button1.Click += button1_Click;
            button2.Click += button2_Click;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            EditForm ef = new EditForm(this);
            ef.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
           
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "(*.txt)|*.txt";
            file.FilterIndex = 1;
            file.RestoreDirectory = true;                

            if (file.ShowDialog() == DialogResult.OK)
            {
                MainText = File.ReadAllText(file.FileName, Encoding.Default);
                file.Dispose();
                button2.Enabled = true;
            }
        }
        private void button2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
