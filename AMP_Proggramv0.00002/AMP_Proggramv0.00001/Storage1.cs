using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;

namespace AMP_Proggramv0._00001
{
    public partial class Storage1 : MetroFramework.Forms.MetroForm
    {
        SqlConnection sqlConnection;
        string s;
        public Storage1()
        {
            InitializeComponent();
        }

        private async void Storage1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aMPDBDataSet3.StorageCongestion". При необходимости она может быть перемещена или удалена.
            this.storageCongestionTableAdapter.Fill(this.aMPDBDataSet3.StorageCongestion);


            metroGrid2.Visible = false;
            string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\AMP\AMP_Proggramv0.00002\AMP_Proggramv0.00001\AMPDB.mdf;Integrated Security=True;Connect Timeout=30";
            sqlConnection = new SqlConnection(connectionString);
            await sqlConnection.OpenAsync();
           

            DataSet ds = new DataSet();
            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\AMP\AMP_Proggramv0.00002\AMP_Proggramv0.00001\AMPDB.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand("select * from Storage1", con);
                con.Open();
                da.Fill(ds);
                metroGrid1.DataSource = ds.Tables[0];
            }
            //////////////
            DataSet dss = new DataSet();
            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\AMP\AMP_Proggramv0.00002\AMP_Proggramv0.00001\AMPDB.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                SqlDataAdapter daa = new SqlDataAdapter();
                daa.SelectCommand = new SqlCommand("select * from StorageCongestion", con);
                con.Open();
                daa.Fill(dss);
                metroGrid2.DataSource = dss.Tables[0];
            }
           storPicker.Text = metroGrid2.CurrentRow.Cells[1].Value.ToString();
           int a = Convert.ToInt32(storPicker.Text);
           bunifuGauge1.Value = a;
        }

       

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\AMP\AMP_Proggramv0.00002\AMP_Proggramv0.00001\AMPDB.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand("select * from Storage1", con);
                con.Open();
                da.Fill(ds);
                metroGrid1.DataSource = ds.Tables[0];
            }
        }

        public void ReadBD()
        {

        }

       
       

        private  void stateBnt_Click(object sender, EventArgs e)
        {   /*
            SqlDataReader dr;
            
            SqlCommand command2 = new SqlCommand(" SELECT Count(Weight) FROM Storage1'" + test1.Text + "'", sqlConnection);
            dr = command2.EndExecuteReader();
             */
//            stateBnt.Click += new EventHandler(metroGrid2_CellContentClick);
            


           

        }
        private void metroGrid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        //    test1.Text = metroGrid2.Rows[e.RowIndex].Cells[1].Value.ToString();
        //    int a = Convert.ToInt32(test1.Text);
        //    bunifuGauge1.Value = a;
        }

        private  async void button1_Click(object sender, EventArgs e)
        {
            
           // SqlCommand command = new SqlCommand("UPDATE StorageCongestion SET Storage1 = Storage1 - @Str where id=1", sqlConnection);
          //  command.Parameters.AddWithValue("Str", test1.Text);
         //   command.Parameters.AddWithValue("znach", znachBox.Text);
          //  command.Parameters.AddWithValue("Id", idBox.Text);
         //   await command.ExecuteNonQueryAsync();

        }

       

        

       private void Storage1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();
            
        }

       
        private void reloadBnt_Click(object sender, EventArgs e)
        {
            DataSet dss = new DataSet();
            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Frozen_Heart\Documents\Visual Studio 2013\Projects\AMP_Proggramv0.00002\AMP_Proggramv0.00001\AMPDB.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                SqlDataAdapter daa = new SqlDataAdapter();
                daa.SelectCommand = new SqlCommand("select * from StorageCongestion", con);
                con.Open();
                daa.Fill(dss);
                metroGrid2.DataSource = dss.Tables[0];
            }
        }

        private async void delFromStrg1Btn_Click(object sender, EventArgs e)
        {
            DialogResult result = MetroMessageBox.Show(this, "Вы точно хотите удалить эту запись?", "Question", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Frozen_Heart\Documents\Visual Studio 2013\Projects\AMP_Proggramv0.00002\AMP_Proggramv0.00001\AMPDB.mdf;Integrated Security=True;Connect Timeout=30";
                sqlConnection = new SqlConnection(connectionString);
                await sqlConnection.OpenAsync();
                SqlCommand command = new SqlCommand("DELETE FROM Storage1 WHERE (Number_of_Bill = '" + nmbrPicker1.Text + "')", sqlConnection);
                await command.ExecuteNonQueryAsync();
                DialogResult dialog1 = MetroMessageBox.Show(this, "Запись удалена, для отображения нажмите кнопку 'Обновить'", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            nmbrPicker1.Text = metroGrid1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void goLoolStorageBtn_Click_1(object sender, EventArgs e)
        {
            LookUpStorages lookupstorages = new LookUpStorages();
            lookupstorages.ShowDialog();
        }

        private void statusBtn_Click(object sender, EventArgs e)
        {
            storPicker.Text = metroGrid2.CurrentRow.Cells[1].Value.ToString();
            int a = Convert.ToInt32(storPicker.Text);
            bunifuGauge1.Value = a;
        }

       

      
         /*
        private async void metroButton1_Click(object sender, EventArgs e)
        {
            if (nmbrStorageBox.Text == "1")
            {
                DialogResult result = MetroMessageBox.Show(this, "Вы точно хотите переместить этот груз на 'Склад1'?", "Question", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    SqlCommand command = new SqlCommand("INSERT INTO [Storage1] (Number_Of_Bill,Goods_Name,Goods_Type,Weight,Special_Information) VALUES(@Number_Of_Bill,@Goods_Name,@Goods_Type,@Weight,@Special_Information)", sqlConnection);
                    command.Parameters.AddWithValue("Number_Of_Bill", nmbrBillBox.Text);
                    command.Parameters.AddWithValue("Goods_Name", nameofGoodsBox.Text);
                    command.Parameters.AddWithValue("Goods_Type", goodsTypeBox.Text);
                    command.Parameters.AddWithValue("Weight", weightBox.Text);
                    command.Parameters.AddWithValue("Special_Information", specinfBox.Text);
                    await command.ExecuteNonQueryAsync();
                    MetroMessageBox.Show(this, "Груз перемещен на склад 1", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

              */
        }
    }
