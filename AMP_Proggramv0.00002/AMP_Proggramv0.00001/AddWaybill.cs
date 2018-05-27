using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;

namespace AMP_Proggramv0._00001
{
    public partial class AddWaybill : MetroFramework.Forms.MetroForm
    {
        public AddWaybill()
        {
            InitializeComponent();
        }

        private void AddWaybill_Load(object sender, EventArgs e)
        {
            
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Redact main = new Redact();
            main.ShowDialog();
        }

        private void goAddBill1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddFrom addwb = new AddFrom();
            addwb.ShowDialog();
        }

     

        private void metroTile1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Invoice inv = new Invoice();
            inv.ShowDialog();
        }

       
      
       

    }
}
