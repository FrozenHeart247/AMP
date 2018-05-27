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
    public partial class LookUpStorages : MetroFramework.Forms.MetroForm
    {
        public LookUpStorages()
        {
            InitializeComponent();
        }

        private void LookUpStorages_Load(object sender, EventArgs e)
        {

        }

       

        private void strg1Btn_Click_1(object sender, EventArgs e)
        {
            Storage1 storage1 = new Storage1();
            storage1.ShowDialog();
        }

       

        private void strg2Btn_Click_1(object sender, EventArgs e)
        {
            Storage2 storage2 = new Storage2();
            storage2.ShowDialog();
        }

        private void strg3Btn_Click(object sender, EventArgs e)
        {
            Storage3 storage3 = new Storage3();
            storage3.ShowDialog();
        }

        private void strg4Btn_Click(object sender, EventArgs e)
        {
            Storage4 storage4 = new Storage4();
            storage4.ShowDialog();
        }

        private void strg5Btn_Click(object sender, EventArgs e)
        {
            Storage5 storage5 = new Storage5();
            storage5.ShowDialog();
        }

      
    }
}
