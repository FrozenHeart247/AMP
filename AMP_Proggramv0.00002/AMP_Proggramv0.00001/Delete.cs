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
    public partial class Delete : MetroFramework.Forms.MetroForm
    {
        SqlConnection sqlConnection;
        SqlCommand sCommand; 
        SqlDataAdapter sAdapter;
        SqlCommandBuilder sBuilder;
        DataTable Produ;
        DataSet sDs;
       
       // DataTable sTable;
        public Delete()
        {
            InitializeComponent();
        }
       
        private   void Delete_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aMPDBDFriday.BillofLanding1". При необходимости она может быть перемещена или удалена.
            DataSet ds = new DataSet();
            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\AMP\AMP_Proggramv0.00002\AMP_Proggramv0.00001\AMPDB.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand("SELECT * FROM BillofLanding1", con);
                con.Open();
                da.Fill(ds);
                metroGrid1.DataSource = ds.Tables[0];
            }
            
           
           
            
        //  metroGrid1.Columns[0].Visible = false;
            /*metroGrid1.Columns[0].HeaderText = "ID";
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
           
          
           // metroGrid1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

      

       private void Delete_FormClosing(object sender, FormClosingEventArgs e)
       {
           if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
               sqlConnection.Close();
           Application.Exit();
       }

      
       private void backBtn_Click(object sender, EventArgs e)
       {
           this.Hide();
           Redact red = new Redact();
           red.Show();
       }

       private void bntSlide_Click(object sender, EventArgs e)
       {
           if (slidemenu.Width == 200)
           {
               slidemenu.Visible = false;
               slidemenu.Width = 55;

               panelAnimator.ShowSync(slidemenu);
           }
           else
           {
               slidemenu.Visible = false;
               slidemenu.Width = 200;

               panelAnimator.ShowSync(slidemenu);
           }
       }

       

      

       private void gotoLookUp_Click(object sender, EventArgs e)
       {
           this.Hide();
           Lookup look = new Lookup();
           look.Show();
       }

       private void gotoRedact_Click(object sender, EventArgs e)
       {
           this.Hide();
           Redact red = new Redact();
           red.Show();
       }

       private void gotoAudit_Click(object sender, EventArgs e)
       {
           this.Hide();
           Audit audit = new Audit();
           audit.Show();
       }

       private void gotoSettings_Click(object sender, EventArgs e)
       {
           this.Hide();
           Settings sets = new Settings();
           sets.Show();
       }

       private async void delBtn_Click(object sender, EventArgs e)
       {
           DialogResult result = MetroMessageBox.Show(this, "Вы точно хотите удалить эту запись?", "Question", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
           if (result == DialogResult.Yes)
           {
               string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\AMP\AMP_Proggramv0.00002\AMP_Proggramv0.00001\AMPDB.mdf;Integrated Security=True;Connect Timeout=30";
               sqlConnection = new SqlConnection(connectionString);
               await sqlConnection.OpenAsync();
               SqlCommand command = new SqlCommand("DELETE FROM BillofLanding1 WHERE (Landing_Bill_Number = '" + delBox.Text + "')", sqlConnection);
               await command.ExecuteNonQueryAsync();
               MetroMessageBox.Show(this, "Запись удалена, для отображения нажмите кнопку 'Обновить'", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
           }
       }

       private void updBnt_Click(object sender, EventArgs e)
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

      

       

       

    

       
       /*
        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
               
             billofLanding1TableAdapter.Update(appData.BillofLanding1);
             metroGrid1.Refresh();
                MetroMessageBox.Show(this, "Sohraneno", "asdads", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                appData.BillofLanding1.RejectChanges();
            }
           
        }
        private void metroGrid1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DialogResult result = MetroMessageBox.Show(this, "udaleno", "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    billofLanding1BindingSource.RemoveCurrent();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            billofLanding1BindingSource.RemoveCurrent();
        }
           /*
        private void metroButton1_Click(object sender, EventArgs e)
        {    
            foreach (DataGridViewRow item in this.metroGrid1.SelectedRows)
            {
                metroGrid1.Rows.RemoveAt(item.Index);
            }
              */

            /*
           metroGrid1.Rows.RemoveAt(metroGrid1.SelectedRows[1].Index);
           sAdapter.Update(sTable);
       }
                 */
        }
    }
