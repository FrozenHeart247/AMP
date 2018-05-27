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
using System.IO;

namespace AMP_Proggramv0._00001
{
    public partial class Lookup : MetroFramework.Forms.MetroForm
    {                  
        SqlConnection sqlConnection;
        public Lookup()
        {
            InitializeComponent();
        }
                
        private void Lookup_Load(object sender, EventArgs e)
        {
            
            metroGrid2.Visible = false;
            pictureBox1.Visible = false;
            bunifuCheckbox1.Checked = !bunifuCheckbox1.Checked;
            DataSet ds = new DataSet();
            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\AMP\AMP_Proggramv0.00002\AMP_Proggramv0.00001\AMPDB.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand("SELECT * FROM BillofLanding1", con);
                con.Open();
                da.Fill(ds);
                metroGrid1.DataSource = ds.Tables[0];
            }
            ////////////////////////////////////
            DataSet dss = new DataSet();
            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\AMP\AMP_Proggramv0.00002\AMP_Proggramv0.00001\AMPDB.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                SqlDataAdapter daa = new SqlDataAdapter();
                daa.SelectCommand = new SqlCommand("SELECT * FROM InvoiceBill", con);
                con.Open();
                daa.Fill(dss);
                metroGrid2.DataSource = dss.Tables[0];
            }

            metroGrid1.Columns[0].HeaderText = "Номер накладной";
            metroGrid1.Columns[1].HeaderText = "Дата";
            metroGrid1.Columns[2].HeaderText = "Название Судна";
            metroGrid1.Columns[3].HeaderText = "Имя отправляющей компании";
            metroGrid1.Columns[4].HeaderText = "Адрес отправки";
            metroGrid1.Columns[5].HeaderText = "Отправной город";
            metroGrid1.Columns[6].HeaderText = "Имя получающей компании";
            metroGrid1.Columns[7].HeaderText = "Адрес прибытия";
            metroGrid1.Columns[8].HeaderText = "Город прибытия";
            metroGrid1.Columns[9].HeaderText = "Телефон отправителя";
            metroGrid1.Columns[10].HeaderText = "Телефон получателя";
            metroGrid1.Columns[11].HeaderText = "Специальная информация";
            metroGrid1.Columns[12].HeaderText = "Номер заказа товара";
            metroGrid1.Columns[13].HeaderText = "Номер пломбы контейнера";
            metroGrid1.Columns[14].HeaderText = "Объем";
            metroGrid1.Columns[15].HeaderText = "Вес";
            metroGrid1.Columns[16].HeaderText = "Тип контейнера";
            metroGrid1.Columns[17].HeaderText = "Внутрение размеры";
            metroGrid1.Columns[18].HeaderText = "Внешние размеры";
            metroGrid1.Columns[19].HeaderText = "TEU";
                      //конасамент (бланк происхождения) , пдф

            /*
          string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Frozen_Heart\Documents\Visual Studio 2013\Projects\AMP_Proggramv0.00001\AMP_Proggramv0.00001\AMPDB.mdf;Integrated Security=True";
           sqlConnection = new SqlConnection(connectionString);
           await sqlConnection.OpenAsync();
            
           /*
           SqlCommand command = new SqlCommand("SELECT * FROM [Products]", sqlConnection);

           try
           {
               sqlReader = await command.ExecuteReaderAsync();
               while (await sqlReader.ReadAsync())
               {
                   lookBox.Items.Add(Convert.ToString(sqlReader["ID"]) + "  " + Convert.ToString(sqlReader["Name"]) + "  " + Convert.ToString(sqlReader["Price"]));
               }
           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
           finally
           {
               if (sqlReader != null)
                   sqlReader.Close();
           }
            */

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main mainform = new Main();
            mainform.Show();
        }

       

        private void backBtn_Click(object sender, EventArgs e)
        {

            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();
            {
                this.Hide();
                Main main = new Main();
                main.Show();
            }
        }











        private void справкаToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\AMP\AMP_Proggramv0.00002\AMP_Proggramv0.00001\AMPDB.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand("SELECT * FROM BillofLanding1", con);
                con.Open();
                da.Fill(ds);
                metroGrid1.DataSource = ds.Tables[0];
            }
        }




        private void metroTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            SqlConnection sqlConn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\AMP\AMP_Proggramv0.00002\AMP_Proggramv0.00001\AMPDB.mdf;Integrated Security=True;Connect Timeout=30");
            sqlConn.Open();
            //выполняем запрос
            SqlCommand sqlCom = new SqlCommand("SELECT * FROM BillofLanding1 WHERE (Landing_Bill_Number LIKE '%" + metroTextBox1.Text + "%')", sqlConn);
            SqlDataReader dr = sqlCom.ExecuteReader();
            //результат запроса суем в таблицу
            DataTable dt = new DataTable();
            dt.Load(dr);
            //заполняем datagridview - (поле данных...где выводится результат поиска)
            metroGrid1.DataSource = dt;
        }

        private void metroTextBox2_KeyUp(object sender, KeyEventArgs e)
        {
            SqlConnection sqlConn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\AMP\AMP_Proggramv0.00002\AMP_Proggramv0.00001\AMPDB.mdf;Integrated Security=True;Connect Timeout=30");
            sqlConn.Open();
            SqlCommand sqlCom = new SqlCommand("SELECT * FROM BillofLanding1 WHERE (Carrier_Name LIKE '%" + metroTextBox2.Text + "%')", sqlConn);
            SqlDataReader dr = sqlCom.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            metroGrid1.DataSource = dt;
        }

        private void dateSearch_KeyUp(object sender, KeyEventArgs e)
        {
            SqlConnection sqlConn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\AMP\AMP_Proggramv0.00002\AMP_Proggramv0.00001\AMPDB.mdf;Integrated Security=True;Connect Timeout=30");
            sqlConn.Open();
            SqlCommand sqlCom = new SqlCommand("SELECT * FROM BillofLanding1 WHERE (Date_of_Bill LIKE '%" + dateSearch.Text + "%')", sqlConn);
            SqlDataReader dr = sqlCom.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            metroGrid1.DataSource = dt;
        }

        private void bunifuCheckbox1_OnChange(object sender, EventArgs e)
        {
            if (!bunifuCheckbox1.Checked)               ///rash
            {
               
                metroGrid2.Visible = false;
                pictureBox1.Visible = false;
                pictureBox1.Image = null;
                
            }
            else
                
                metroGrid2.Visible = true;
                pictureBox1.Visible = true;                              //inv
                
        }

        private void Lookup_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();
            Application.Exit();
        }

        private void metroGrid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            pictureBox1.Image = System.Drawing.Image.FromStream(new MemoryStream((byte[])metroGrid2.Rows[e.RowIndex].Cells[13].Value));
        }

       

  
           
       










    }
    /*
private async void обновитьToolStripMenuItem_Click(object sender, EventArgs e)
{
 lookBox.Items.Clear();
 string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Frozen_Heart\Documents\Visual Studio 2013\Projects\AMP_Proggramv0.00001\AMP_Proggramv0.00001\AMPDB.mdf;Integrated Security=True";
 sqlConnection = new SqlConnection(connectionString);
 await sqlConnection.OpenAsync();
 SqlDataReader sqlReader = null;
 SqlCommand command = new SqlCommand("SELECT * FROM [Products]", sqlConnection);

 try
 {
     sqlReader = await command.ExecuteReaderAsync();
     while (await sqlReader.ReadAsync())
     {
        lookBox.Items.Add(Convert.ToString(sqlReader["ID"]) + "  " + Convert.ToString(sqlReader["Name"]) + "  " + Convert.ToString(sqlReader["Price"]));
     }
 }
 catch (Exception ex)
 {
     MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
 }
 finally
 {
     if (sqlReader != null)
         sqlReader.Close();
 }
}

*/
}



