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
    public partial class Storage5 : MetroFramework.Forms.MetroForm
    {
        SqlConnection sqlConnection;
        public Storage5()
        {
            InitializeComponent();
        }

        private async void Storage5_Load(object sender, EventArgs e)
        {
            metroGrid2.Visible = false;
            DataSet ds = new DataSet();
            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\AMP\AMP_Proggramv0.00002\AMP_Proggramv0.00001\AMPDB.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand("select * from Storage5", con);
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
            stor5Picker.Text = metroGrid2.CurrentRow.Cells[5].Value.ToString();
            int a = Convert.ToInt32(stor5Picker.Text);
            bunifuGauge1.Value = a;
            string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\AMP\AMP_Proggramv0.00002\AMP_Proggramv0.00001\AMPDB.mdf;Integrated Security=True;Connect Timeout=30";
            sqlConnection = new SqlConnection(connectionString);
            await sqlConnection.OpenAsync();

        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\AMP\AMP_Proggramv0.00002\AMP_Proggramv0.00001\AMPDB.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand("select * from Storage5", con);
                con.Open();
                da.Fill(ds);
                metroGrid1.DataSource = ds.Tables[0];
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LookUpStorages lookstrgs = new LookUpStorages();
            lookstrgs.ShowDialog();
        }


        private void status5Btn_Click(object sender, EventArgs e)
        {
            stor5Picker.Text = metroGrid2.CurrentRow.Cells[5].Value.ToString();
            int a = Convert.ToInt32(stor5Picker.Text);
            bunifuGauge1.Value = a;
        }

        private void reload5Btn_Click(object sender, EventArgs e)
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

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            nmbrBillBox.Text = metroGrid1.Rows[e.RowIndex].Cells[1].Value.ToString();
            typeContBox.Text = metroGrid1.Rows[e.RowIndex].Cells[2].Value.ToString();
            goodsTypeBox.Text = metroGrid1.Rows[e.RowIndex].Cells[3].Value.ToString();
            weightBox.Text = metroGrid1.Rows[e.RowIndex].Cells[4].Value.ToString();
            teuBox.Text = metroGrid1.Rows[e.RowIndex].Cells[5].Value.ToString();
            specinfBox.Text = metroGrid1.Rows[e.RowIndex].Cells[6].Value.ToString();
            
        }

        private async void sendonStrgBtn_Click(object sender, EventArgs e)
        {
            if (storageNmbrBox.Text == "1")
            {
                DialogResult result = MetroMessageBox.Show(this, "Вы точно хотите переместить этот груз на 'Склад1'?", "Question", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    SqlCommand command = new SqlCommand("INSERT INTO [Storage1] (Number_of_Bill,Type_of_Container,Goods_Type,Weight,Teu,Special_Information) VALUES(@Number_of_Bill,@Type_of_Container,@Goods_Type,@Weight,@Teu,@Special_Information)", sqlConnection);
                    command.Parameters.AddWithValue("Number_of_Bill", nmbrBillBox.Text);
                    command.Parameters.AddWithValue("Type_of_Container", typeContBox.Text);
                    command.Parameters.AddWithValue("Goods_Type", goodsTypeBox.Text);
                    command.Parameters.AddWithValue("Weight", weightBox.Text);
                    command.Parameters.AddWithValue("Teu", teuBox.Text);
                    command.Parameters.AddWithValue("Special_Information", specinfBox.Text);
                    await command.ExecuteNonQueryAsync();
                    DialogResult dialog1 = MetroMessageBox.Show(this, "Груз перемещен на склад 1", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dialog1 == DialogResult.OK)
                    {
                        SqlCommand command2 = new SqlCommand("UPDATE StorageCongestion SET Storage1 = Storage1 - @Teu where id=1", sqlConnection);
                        command2.Parameters.AddWithValue("Teu", teuBox.Text);
                        //   command.Parameters.AddWithValue("znach", znachBox.Text);
                        //  command.Parameters.AddWithValue("Id", idBox.Text);
                        await command2.ExecuteNonQueryAsync();
                    }

                }





            }
        }
    }
}