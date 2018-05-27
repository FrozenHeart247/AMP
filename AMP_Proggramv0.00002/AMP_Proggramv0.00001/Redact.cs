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
    public partial class Redact : MetroFramework.Forms.MetroForm
    {
        public Redact()
        {
            InitializeComponent();
        }




        private void Redact_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aMPDBDataSet.Products". При необходимости она может быть перемещена или удалена.
             /* 
            metroGrid1.Columns[0].HeaderText = "ID";
            metroGrid1.Columns[0].Width = 20;
            metroGrid1.Columns[1].HeaderText = "Имя";
            metroGrid1.Columns[2].HeaderText = "Тип товара";
            metroGrid1.Columns[3].HeaderText = "Номер места на складе";
            metroGrid1.Columns[4].HeaderText = "Тип склада";
            metroGrid1.Columns[5].HeaderText = "Номер склада";
            metroGrid1.Columns[6].HeaderText = "Номер контейнера";
            metroGrid1.Columns[7].HeaderText = "Дата прибытия";
            metroGrid1.Columns[8].HeaderText = "Дата отправки";
            metroGrid1.Columns[9].HeaderText = "Номер судна";
           metroGrid1.Columns[10].HeaderText = "Номер(название)порта";
               */
        }
        

        private void goRedactTile_Click(object sender, EventArgs e)
        {
            this.Hide();
            Change changeform = new Change();
            changeform.Show();
        }

        private void goAddTile_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddWaybill addw = new AddWaybill();
            addw.Show();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Show();

        }

        private void goDelTile_Click(object sender, EventArgs e)
        {
            this.Hide();
            Delete del = new Delete();
            del.Show();

        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void goAuditTile_Click(object sender, EventArgs e)
        {
            this.Hide();
            Audit audit = new Audit();
            audit.Show();
        }

       

        private void metroTile1_Click(object sender, EventArgs e)
        {
            LookUpStorages lkupstr = new LookUpStorages();
            lkupstr.Show();
        }

        private void Redact_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

      
       

  }
}
