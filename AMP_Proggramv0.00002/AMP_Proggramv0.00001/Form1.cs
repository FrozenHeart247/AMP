using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMP_Proggramv0._00001
{
    public partial class Form1 : Form
    {
        private Form2 frm2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            frm2 =  new Form2();
            frm2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = frm2.textBox1.Text;
        }
    }
}
