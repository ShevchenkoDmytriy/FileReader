using System;
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
    public partial class EditForm : Form
    {
        public Form1 MainForm;

        public EditForm(Form1 f1)
        {
            MainForm = f1;
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            button1.Click += button1_Click;
            textBox1.Text = MainForm.MainText;
            button2.Click += button2_Click;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MainForm.MainText = textBox1.Text;
            this.Close();
        }
    }
}
