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
    public partial class Storage2 : MetroFramework.Forms.MetroForm
    {
        SqlConnection sqlConnection;
        public Storage2()
        {
            InitializeComponent();
        }
        
        private void Storage2_Load(object sender, EventArgs e)
        {

            metroGrid2.Visible = false;
            DataSet ds = new DataSet();
            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\AMP\AMP_Proggramv0.00002\AMP_Proggramv0.00001\AMPDB.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand("select * from Storage2", con);
                con.Open();
                da.Fill(ds);
                metroGrid1.DataSource = ds.Tables[0];
            }
                  //////////////////////////
            DataSet dss = new DataSet();
            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\AMP\AMP_Proggramv0.00002\AMP_Proggramv0.00001\AMPDB.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                SqlDataAdapter daa = new SqlDataAdapter();
                daa.SelectCommand = new SqlCommand("select * from StorageCongestion", con);
                con.Open();
                daa.Fill(dss);
                metroGrid2.DataSource = dss.Tables[0];
            }
            stor2Picker.Text = metroGrid2.CurrentRow.Cells[2].Value.ToString();
            int a = Convert.ToInt32(stor2Picker.Text);
            bunifuGauge1.Value = a;
          
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\AMP\AMP_Proggramv0.00002\AMP_Proggramv0.00001\AMPDB.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand("select * from Storage2", con);
                con.Open();
                da.Fill(ds);
                metroGrid1.DataSource = ds.Tables[0];
            }
        }

        private void goLoolStorageBtn_Click(object sender, EventArgs e)
        {
            LookUpStorages lookupstorages = new LookUpStorages();
            lookupstorages.ShowDialog();
        }

        private void status2Btn_Click(object sender, EventArgs e)
        {
            stor2Picker.Text = metroGrid2.CurrentRow.Cells[2].Value.ToString();
            int a = Convert.ToInt32(stor2Picker.Text);
            bunifuGauge1.Value = a;
        }

        private void reload2Btn_Click(object sender, EventArgs e)
        {
            DataSet dss = new DataSet();
            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\AMP\AMP_Proggramv0.00002\AMP_Proggramv0.00001\AMPDB.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                SqlDataAdapter daa = new SqlDataAdapter();
                daa.SelectCommand = new SqlCommand("select * from StorageCongestion", con);
                con.Open();
                daa.Fill(dss);
                metroGrid2.DataSource = dss.Tables[0];
            }
        }

        private async void delStrg2_Click(object sender, EventArgs e)
        {
            DialogResult result = MetroMessageBox.Show(this, "Вы точно хотите удалить эту запись?", "Question", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\AMP\AMP_Proggramv0.00002\AMP_Proggramv0.00001\AMPDB.mdf;Integrated Security=True;Connect Timeout=30";
                sqlConnection = new SqlConnection(connectionString);
                await sqlConnection.OpenAsync();
                SqlCommand command = new SqlCommand("DELETE FROM Storage2 WHERE (Number_of_Bill = '" + stor2Picker.Text + "')", sqlConnection);
                await command.ExecuteNonQueryAsync();
                MetroMessageBox.Show(this, "Запись удалена, для отображения нажмите кнопку 'Обновить'", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            stor2Picker.Text = metroGrid1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

      
    }
}
