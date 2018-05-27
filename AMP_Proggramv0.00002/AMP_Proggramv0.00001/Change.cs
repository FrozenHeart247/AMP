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
    public partial class Change : MetroFramework.Forms.MetroForm
    {
        SqlConnection sqlConnection;
        public Change()
        {
            InitializeComponent();
        }
        private async void Change_Load(object sender, EventArgs e)
        {

            string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\AMP\AMP_Proggramv0.00002\AMP_Proggramv0.00001\AMPDB.mdf;Integrated Security=True;Connect Timeout=30";
            sqlConnection = new SqlConnection(connectionString);
            await sqlConnection.OpenAsync();

            DataSet ds = new DataSet();
            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\AMP\AMP_Proggramv0.00002\AMP_Proggramv0.00001\AMPDB.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand("SELECT * FROM BillofLanding1", con);
                con.Open();
                da.Fill(ds);
                metroGrid1.DataSource = ds.Tables[0];
            }
            /*
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
             * */
        }
        private async void changeButton_Click(object sender, EventArgs e)
        {          /*
            if (!string.IsNullOrEmpty(idBox.Text) && !string.IsNullOrWhiteSpace(idBox.Text) &&
                !string.IsNullOrEmpty(nameBox.Text) && !string.IsNullOrWhiteSpace(nameBox.Text) &&
                !string.IsNullOrEmpty(priceBox.Text) && !string.IsNullOrWhiteSpace(priceBox.Text))
            {
                SqlCommand command = new SqlCommand("UPDATE [BillofLanding1] SET [Date_of_Bill] = @Date_of_Bill, [Landing_Bill_Number] = @Landing_Bill_Number, [Carrier_Name] = @Carrier_Name, [Name_Ship_From] = @Name_Ship_From, [Address_From] = @Address_From, [City_From] = @City_From, [Name_Ship_To] = @Name_Ship_To, [City_To] = @City_To, [Phone] = @Phone, [Special_Information] = @Special_Information, [Customer_Order_Number] = @Customer_Order_Number,[Goods_Name] = @Goods_Name,[Goods_Type] = @Goods_Type,[Weight] = @Weight WHERE [Id] = @Id", sqlConnection);
                command.Parameters.AddWithValue("Date_of_Bill", dateBox.Text);
                command.Parameters.AddWithValue("Landing_Bill_Number", billLandBox.Text);
                command.Parameters.AddWithValue("Carrier_Name", carriernmBox.Text);
                command.Parameters.AddWithValue("Name_Ship_From", nameFromBox.Text);
                command.Parameters.AddWithValue("Address_From", addressFromBox.Text);
                command.Parameters.AddWithValue("City_From", cityFromBox.Text);
                command.Parameters.AddWithValue("Name_Ship_To", nameToBox.Text);
                command.Parameters.AddWithValue("City_To", CityToBox.Text);
                command.Parameters.AddWithValue("Phone", phoneBox.Text);
                command.Parameters.AddWithValue("Special_Information", specialInfBox.Text);
                command.Parameters.AddWithValue("Customer_Order_Number", custmrOrdrNmbrBox.Text);
                command.Parameters.AddWithValue("Goods_Name", goodNameBox.Text);
                command.Parameters.AddWithValue("Goods_Type", goodsTypeBox.Text);
                command.Parameters.AddWithValue("Weight", weightBox.Text);
                command.Parameters.AddWithValue("Id", idupdBox.Text);
                await command.ExecuteNonQueryAsync();

            }
                    * */

        }

        private void Change_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();
            Application.Exit();
        }

        private void lookBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Redact red = new Redact();
            red.Show();
        }

       
       
       

        private async void addupdBtn_Click_1(object sender, EventArgs e)
        {
            {
                if (!string.IsNullOrEmpty(metroDateTime1.Value.ToString("MM/dd/yyyy")) && !string.IsNullOrWhiteSpace(metroDateTime1.Value.ToString("MM/dd/yyyy")) &&
             !string.IsNullOrEmpty(billLandBox.Text) && !string.IsNullOrWhiteSpace(billLandBox.Text) &&
             !string.IsNullOrEmpty(carriernmBox.Text) && !string.IsNullOrWhiteSpace(carriernmBox.Text) &&
             !string.IsNullOrEmpty(addressFromBox.Text) && !string.IsNullOrWhiteSpace(addressFromBox.Text) &&
             !string.IsNullOrEmpty(cityFromBox.Text) && !string.IsNullOrWhiteSpace(cityFromBox.Text) &&
             !string.IsNullOrEmpty(nameToBox.Text) && !string.IsNullOrWhiteSpace(nameToBox.Text) &&
             !string.IsNullOrEmpty(addressToBox.Text) && !string.IsNullOrWhiteSpace(addressToBox.Text) &&
             !string.IsNullOrEmpty(phoneToBox.Text) && !string.IsNullOrWhiteSpace(phoneToBox.Text) &&
             !string.IsNullOrEmpty(phoneFromBox.Text) && !string.IsNullOrWhiteSpace(phoneFromBox.Text) &&
              // !string.IsNullOrEmpty(specialInfBox.Text) && !string.IsNullOrWhiteSpace(specialInfBox.Text) &&
             !string.IsNullOrEmpty(custmrOrdrNmbrBox.Text) && !string.IsNullOrWhiteSpace(custmrOrdrNmbrBox.Text) &&
           //!string.IsNullOrEmpty(goodNameBox.Text) && !string.IsNullOrWhiteSpace(goodNameBox.Text) &&
             !string.IsNullOrEmpty(nmbrPlombBox.Text) && !string.IsNullOrWhiteSpace(nmbrPlombBox.Text) &&
             !string.IsNullOrEmpty(goodsTypeCmbBox.Text) && !string.IsNullOrWhiteSpace(goodsTypeCmbBox.Text) && 
             !string.IsNullOrEmpty(capacityBox.Text) && !string.IsNullOrWhiteSpace(capacityBox.Text) &&
             !string.IsNullOrEmpty(weightBox.Text) && !string.IsNullOrWhiteSpace(weightBox.Text) &&
             !string.IsNullOrEmpty(typeContBox.Text) && !string.IsNullOrWhiteSpace(typeContBox.Text) &&
             !string.IsNullOrEmpty(capacityOutBox.Text) && !string.IsNullOrWhiteSpace(capacityOutBox.Text) &&
             !string.IsNullOrEmpty(capacityInsBox.Text) && !string.IsNullOrWhiteSpace(capacityInsBox.Text) &&
             !string.IsNullOrEmpty(teuBox.Text) && !string.IsNullOrWhiteSpace(teuBox.Text))
                {
                    DialogResult dialog = MetroMessageBox.Show(this, "Вы точно хотите изменить запись?", "Qestion", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                    if (dialog == DialogResult.Yes)
                    {
                        SqlCommand command = new SqlCommand("UPDATE [BillofLanding1] SET Date_of_Bill = @Date_of_Bill, Carrier_Name = @Carrier_Name, Name_Ship_From = @Name_Ship_From, Address_From = @Address_From, City_From = @City_From, Name_Ship_To = @Name_Ship_To, City_To = @City_To, Phone_To = @Phone_To, Phone_From = @Phone_From, Special_Information = @Special_Information, Customer_Order_Number = @Customer_Order_Number,Container_Plomb_Nmbr = @Container_Plomb_Nmbr,Goods_Type = @Goods_Type,Capacity = @Capacity,Weight = @Weight,Type_of_Container = @Type_of_Container,Capacity_Ins = @Capacity_Ins,Capacity_Out = @Capacity_Out, Teu = @Teu WHERE Landing_Bill_Number = @Landing_Bill_Number", sqlConnection);
                        command.Parameters.AddWithValue("Date_of_Bill", metroDateTime1.Value.ToString("MM/dd/yyyy"));
                        command.Parameters.AddWithValue("Landing_Bill_Number", billLandBox.Text);
                        command.Parameters.AddWithValue("Carrier_Name", carriernmBox.Text);
                        command.Parameters.AddWithValue("Name_Ship_From", nameFromBox.Text);
                        command.Parameters.AddWithValue("Address_From", addressFromBox.Text);
                        command.Parameters.AddWithValue("City_From", cityFromBox.Text);
                        command.Parameters.AddWithValue("Name_Ship_To", nameToBox.Text);
                        command.Parameters.AddWithValue("City_To", CityToBox.Text);
                        command.Parameters.AddWithValue("Phone_From", phoneFromBox.Text);
                        command.Parameters.AddWithValue("Phone_To", phoneToBox.Text);
                        command.Parameters.AddWithValue("Special_Information", specialInfBox.Text);
                        command.Parameters.AddWithValue("Customer_Order_Number", custmrOrdrNmbrBox.Text);
                    //    command.Parameters.AddWithValue("Goods_Name", goodNameBox.Text);
                        command.Parameters.AddWithValue("Container_Plomb_Nmbr", nmbrPlombBox.Text);
                        command.Parameters.AddWithValue("Goods_Type", goodsTypeCmbBox.Text);
                        command.Parameters.AddWithValue("Capacity", capacityBox.Text);
                        command.Parameters.AddWithValue("Weight", weightBox.Text);
                        command.Parameters.AddWithValue("Type_of_Container", typeContBox.Text);
                        command.Parameters.AddWithValue("Capacity_Ins", capacityInsBox.Text);
                        command.Parameters.AddWithValue("Capacity_Out", capacityOutBox.Text);
                        command.Parameters.AddWithValue("Teu", teuBox.Text);
                        await command.ExecuteNonQueryAsync();
                        MetroMessageBox.Show(this, "Данные измнены, нажмите кнопку 'Обновить'","Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "Заполните все поля (Поле 'Special Information' не является обязательным для заполнения", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void updBtn_Click_1(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\AMP\AMP_Proggramv0.00002\AMP_Proggramv0.00001\AMPDB.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand("select * from BillofLanding1", con);
                con.Open();
                da.Fill(ds);
                metroGrid1.DataSource = ds.Tables[0];
            }
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

        private void metroGrid1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            billLandBox.Text = metroGrid1.Rows[e.RowIndex].Cells[0].Value.ToString();
            metroDateTime1.Text = metroGrid1.Rows[e.RowIndex].Cells[1].Value.ToString();
            carriernmBox.Text = metroGrid1.Rows[e.RowIndex].Cells[2].Value.ToString();
            nameFromBox.Text = metroGrid1.Rows[e.RowIndex].Cells[3].Value.ToString();
            addressFromBox.Text = metroGrid1.Rows[e.RowIndex].Cells[4].Value.ToString();
            cityFromBox.Text = metroGrid1.Rows[e.RowIndex].Cells[5].Value.ToString();
            nameToBox.Text = metroGrid1.Rows[e.RowIndex].Cells[6].Value.ToString();
            addressToBox.Text = metroGrid1.Rows[e.RowIndex].Cells[7].Value.ToString();
            CityToBox.Text = metroGrid1.Rows[e.RowIndex].Cells[8].Value.ToString();
            phoneFromBox.Text = metroGrid1.Rows[e.RowIndex].Cells[9].Value.ToString();
            phoneToBox.Text = metroGrid1.Rows[e.RowIndex].Cells[10].Value.ToString();
            specialInfBox.Text = metroGrid1.Rows[e.RowIndex].Cells[11].Value.ToString();
            custmrOrdrNmbrBox.Text = metroGrid1.Rows[e.RowIndex].Cells[12].Value.ToString();
            nmbrPlombBox.Text = metroGrid1.Rows[e.RowIndex].Cells[13].Value.ToString();
            goodsTypeCmbBox.Text = metroGrid1.Rows[e.RowIndex].Cells[14].Value.ToString();
            capacityBox.Text = metroGrid1.Rows[e.RowIndex].Cells[15].Value.ToString();
            weightBox.Text = metroGrid1.Rows[e.RowIndex].Cells[16].Value.ToString();
            typeContBox.Text = metroGrid1.Rows[e.RowIndex].Cells[17].Value.ToString();
            capacityInsBox.Text = metroGrid1.Rows[e.RowIndex].Cells[18].Value.ToString();
            capacityOutBox.Text = metroGrid1.Rows[e.RowIndex].Cells[19].Value.ToString();
            teuBox.Text = metroGrid1.Rows[e.RowIndex].Cells[20].Value.ToString();




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

        private void billnmbrSearchBox_KeyUp(object sender, KeyEventArgs e)
        {
            SqlConnection sqlConn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\AMP\AMP_Proggramv0.00002\AMP_Proggramv0.00001\AMPDB.mdf;Integrated Security=True;Connect Timeout=30");
            sqlConn.Open();
            SqlCommand sqlCom = new SqlCommand("SELECT * FROM BillofLanding1 WHERE (Landing_Bill_Number LIKE '%" + billnmbrSearchBox.Text + "%')", sqlConn);
            SqlDataReader dr = sqlCom.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            metroGrid1.DataSource = dt;
        }

        private void carriernameSearchBox_KeyUp(object sender, KeyEventArgs e)
        {
            SqlConnection sqlConn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\AMP\AMP_Proggramv0.00002\AMP_Proggramv0.00001\AMPDB.mdf;Integrated Security=True;Connect Timeout=30");
            sqlConn.Open();
            SqlCommand sqlCom = new SqlCommand("SELECT * FROM BillofLanding1 WHERE (Carrier_Name LIKE '%" + carriernameSearchBox.Text + "%')", sqlConn);
            SqlDataReader dr = sqlCom.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            metroGrid1.DataSource = dt;
        }

        private void dateSearchBox_KeyUp(object sender, KeyEventArgs e)
        {
            SqlConnection sqlConn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\AMP\AMP_Proggramv0.00002\AMP_Proggramv0.00001\AMPDB.mdf;Integrated Security=True;Connect Timeout=30");
            sqlConn.Open();
            SqlCommand sqlCom = new SqlCommand("SELECT * FROM BillofLanding1 WHERE (Date_of_Bill LIKE '%" + dateSearchBox.Text + "%')", sqlConn);
            SqlDataReader dr = sqlCom.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            metroGrid1.DataSource = dt;
        }

        private void gotoContLkp_Click(object sender, EventArgs e)
        {
            if (slideContMenu.Width == 27 && slideContMenu.Height == 19)   //27;19
            {
                slideContMenu.Visible = false;
                slideContMenu.Width = 954;
                slideContMenu.Height = 530;     //   990; 440      954; 530
                slideContMenu.Left = 55;



                animatorContMenu.ShowSync(slideContMenu);
            }
            else
            {
                slideContMenu.Visible = false;
                slideContMenu.Width = 27;
                slideContMenu.Height = 19;


                // panelAnimator.ShowSync(slidemenu2);
            }
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            capacityBox.Text = "33 м3";
            weightBox.Text = "2 - 2,3 т";
            typeContBox.Text = "Standart | 20-футовый Dry Van ";
            capacityOutBox.Text = "2.43 | 6 | 2.59";
            capacityInsBox.Text = "2.35 / 5.9 / 2.39";
            teuBox.Text = "1";
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            capacityBox.Text = "67 м3";
            weightBox.Text = "3.7 - 3.9 т";
            typeContBox.Text = "Standart | 40-футовый Dry Van ";
            capacityOutBox.Text = "2.43 / 12.19 / 2.59";
            capacityInsBox.Text = "2.35 / 12 / 2.39";
            teuBox.Text = "2";
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            capacityBox.Text = "85 м3";
            weightBox.Text = "4.1 - 4.5 т";
            typeContBox.Text = "Standart | 45-футовый High Cube";
            capacityOutBox.Text = "2.43 / 13.7 / 2.89";
            capacityInsBox.Text = "2.35 / 13.5 / 2.69";
            teuBox.Text = "2";
        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            capacityBox.Text = "28 м3";
            weightBox.Text = "2.5 - 3.2 т";
            typeContBox.Text = "RE | 20-футовый Reefer";
            capacityOutBox.Text = "2.43 / 6 / 2.59";
            capacityInsBox.Text = "2.28 / 5.4 / 2.28";
            teuBox.Text = "1";
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            capacityBox.Text = "60 м3";
            weightBox.Text = "4.3 - 4.5 т";
            typeContBox.Text = "RE | 40-футовый Reefer";
            capacityOutBox.Text = "2.43 / 12.19 / 2.59";
            capacityInsBox.Text = "2.28 / 11.55 / 2.28";
            teuBox.Text = "2";
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            capacityBox.Text = "66 м3";
            weightBox.Text = "4.2 т";
            typeContBox.Text = "RE | 40-футовый Reefer High Cube";
            capacityOutBox.Text = "2.43 / 12.19 / 2.89";
            capacityInsBox.Text = "2.28 / 11.55 / 2.5";
            teuBox.Text = "2";
        }

        private void bunifuImageButton10_Click(object sender, EventArgs e)
        {
            capacityBox.Text = "32 м3";
            weightBox.Text = "2.2 - 2.4 т";
            typeContBox.Text = "Open Top | 20-футовый Open Top";
            capacityOutBox.Text = "2.43 / 6 / 2.59";
            capacityInsBox.Text = "2.35 / 5.9 / 2.35";
            teuBox.Text = "1";
        }

        private void bunifuImageButton8_Click(object sender, EventArgs e)
        {
            capacityBox.Text = "66 м3";
            weightBox.Text = "3.8 - 4.4 т";
            typeContBox.Text = "Open Top | 40-футовый Open Top";
            capacityOutBox.Text = "2.43 / 12.19 / 2.59";
            capacityInsBox.Text = "2.35 / 12 / 2.35";
            teuBox.Text = "2";
        }

        private void bunifuImageButton9_Click(object sender, EventArgs e)
        {
            capacityBox.Text = "32 м3";
            weightBox.Text = "2.4 - 2.5 т";
            typeContBox.Text = "Bulk| 20-футовый Bulk";
            capacityOutBox.Text = "2.43 / 6 / 2.59";
            capacityInsBox.Text = "2.35/5.9/2.34-2.37";
            teuBox.Text = "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void cleanBtn_Click(object sender, EventArgs e)
        {
            capacityBox.Text = "";
            weightBox.Text = "";
            typeContBox.Text = "";
            capacityOutBox.Text = "";
            capacityInsBox.Text = "";
            teuBox.Text = "";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            slideContMenu.Visible = false;
        }


       

       

       

       




    }
}
