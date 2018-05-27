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
    public partial class AddFrom : MetroFramework.Forms.MetroForm
    {
        
        SqlConnection sqlConnection;
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\AMP\AMP_Proggramv0.00002\AMP_Proggramv0.00001\AMPDB.mdf;Integrated Security=True;Connect Timeout=30");
        string imgLocation = "";
        SqlCommand cmd;
        public AddFrom()
        {
            InitializeComponent();
           
        }



        private async void AddFrom_Load(object sender, EventArgs e)
        {      /*
            dataGridView2.Columns[0].HeaderText = "ID";
            dataGridView2.Columns[0].Width = 20;
            dataGridView2.Columns[1].HeaderText = "Имя";
            dataGridView2.Columns[2].HeaderText = "Тип товара";
            dataGridView2.Columns[3].HeaderText = "Номер места на складе";
            dataGridView2.Columns[4].HeaderText = "Тип склада";
            dataGridView2.Columns[5].HeaderText = "Номер склада";
            dataGridView2.Columns[6].HeaderText = "Номер контейнера";
            dataGridView2.Columns[7].HeaderText = "Дата прибытия";
            dataGridView2.Columns[8].HeaderText = "Дата отправки";
            dataGridView2.Columns[9].HeaderText = "Номер судна";
            dataGridView2.Columns[10].HeaderText = "Номер(название)порта";
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aMPDBDSforAddForm.Products". При необходимости она может быть перемещена или удалена.
            this.productsTableAdapter.Fill(this.aMPDBDSforAddForm.Products);
               */

            string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\AMP\AMP_Proggramv0.00002\AMP_Proggramv0.00001\AMPDB.mdf;Integrated Security=True;Connect Timeout=30";
            sqlConnection = new SqlConnection(connectionString);
            await sqlConnection.OpenAsync();
            /*
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
             */

        }


        private void AddFrom_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();
           // Application.Exit();
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


      
        private void backBnt_Click(object sender, EventArgs e)
        {
            this.Hide();
            Redact red = new Redact();
            red.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Show();
        }

       


        

      

        private void bntSlide_Click(object sender, EventArgs e)
        {
            if (slidemenu.Width == 200)
            {
                slidemenu.Visible = false;
                slidemenu.Width = 50;

                panelAnimator.ShowSync(slidemenu);
            }
            else
            {
                slidemenu.Visible = false;
                slidemenu.Width = 200;

                panelAnimator.ShowSync(slidemenu);
            }
        }

        private async void addBnt_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(metroDateTime1.Value.ToString("MM/dd/yyyy")) && !string.IsNullOrWhiteSpace(metroDateTime1.Value.ToString("MM/dd/yyyy")) &&
  // !string.IsNullOrEmpty(billLandBox.Text) && !string.IsNullOrWhiteSpace(billLandBox.Text) &&
   !string.IsNullOrEmpty(carriernmBox.Text) && !string.IsNullOrWhiteSpace(carriernmBox.Text) &&
    !string.IsNullOrEmpty(addressFromBox.Text) && !string.IsNullOrWhiteSpace(addressFromBox.Text) &&
    !string.IsNullOrEmpty(cityFromBox.Text) && !string.IsNullOrWhiteSpace(cityFromBox.Text) &&
    !string.IsNullOrEmpty(nameToBox.Text) && !string.IsNullOrWhiteSpace(nameToBox.Text) &&
    !string.IsNullOrEmpty(addressToBox.Text) && !string.IsNullOrWhiteSpace(addressToBox.Text) &&
    !string.IsNullOrEmpty(phoneToBox.Text) && !string.IsNullOrWhiteSpace(phoneToBox.Text) &&
                // !string.IsNullOrEmpty(specialInfBox.Text) && !string.IsNullOrWhiteSpace(specialInfBox.Text) &&
    !string.IsNullOrEmpty(phoneFromBox.Text) && !string.IsNullOrWhiteSpace(phoneFromBox.Text) &&
    !string.IsNullOrEmpty(custmrOrdrNmbrBox.Text) && !string.IsNullOrWhiteSpace(custmrOrdrNmbrBox.Text) &&
  //  !string.IsNullOrEmpty(goodNameBox.Text) && !string.IsNullOrWhiteSpace(goodNameBox.Text) &&
    !string.IsNullOrEmpty(goodsTypeCmbBox.Text) && !string.IsNullOrWhiteSpace(goodsTypeCmbBox.Text) &&
    !string.IsNullOrEmpty(nmbrPlombBox.Text) && !string.IsNullOrWhiteSpace(nmbrPlombBox.Text) &&
    !string.IsNullOrEmpty(capacityBox.Text) && !string.IsNullOrWhiteSpace(capacityBox.Text) &&
    !string.IsNullOrEmpty(weightBox.Text) && !string.IsNullOrWhiteSpace(weightBox.Text) &&
    !string.IsNullOrEmpty(weightBox.Text) && !string.IsNullOrWhiteSpace(weightBox.Text) && 
    !string.IsNullOrEmpty(typeContBox.Text) && !string.IsNullOrWhiteSpace(typeContBox.Text) &&  
    !string.IsNullOrEmpty(capacityInsBox.Text) && !string.IsNullOrWhiteSpace(capacityInsBox.Text) && 
    !string.IsNullOrEmpty(capacityOutBox.Text) && !string.IsNullOrWhiteSpace(capacityOutBox.Text) &&                                                               
    !string.IsNullOrEmpty(teuBox.Text) && !string.IsNullOrWhiteSpace(teuBox.Text))
                


            {
                //SqlCommand command = new SqlCommand("INSERT INTO [Products] (Name,Goods_Type,Number_of_Place_on_Storage,Type_of_Storage,Number_of_Storage,Number_of_Container,Arrival_Date,Dispatch_Date,Number_of_Ship,Number_of_Port) VALUES(@Name,@Goods_Type,@Number_of_Place_on_Storage,@Type_of_Storage,@Number_of_Storage,@Number_of_Container,@Arrival_Date,@Dispatch_Date,@Number_of_Ship,@Number_of_Port)", sqlConnection);
             //   byte[] images = null;
             //   FileStream Stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
              //  BinaryReader brs = new BinaryReader(Stream);
              //  images = brs.ReadBytes((int)Stream.Length);

                // pictureBox1.Image = System.Drawing.Image.FromStream(new MemoryStream((byte[])metroGrid1.Rows[e.RowIndex].Cells[20].Value));

                SqlCommand command = new SqlCommand("INSERT INTO  [BillofLanding1] (Date_of_Bill,Carrier_Name,Name_Ship_From,Address_From,City_From,Name_Ship_To,Address_To,City_To,Phone_To,Phone_From,Special_Information,Customer_Order_Number,Container_Plomb_Nmbr,Goods_Type,Capacity,Weight,Type_of_Container,Capacity_Ins,Capacity_Out,Teu) VALUES(@Date_of_Bill,@Carrier_Name,@Name_Ship_From,@Address_From,@City_From,@Name_Ship_To,@Address_To,@City_To,@Phone_To,@Phone_From,@Special_Information,@Customer_Order_Number,@Container_Plomb_Nmbr,@Goods_Type,@Capacity,@Weight,@Type_of_Container,@Capacity_Ins,@Capacity_Out,@Teu)", sqlConnection);
                    command.Parameters.AddWithValue("Date_of_Bill", metroDateTime1.Value.ToString("MM/dd/yyyy"));
                 //   command.Parameters.AddWithValue("Landing_Bill_Number", billLandBox.Text);
                    command.Parameters.AddWithValue("Carrier_Name", carriernmBox.Text);
                    command.Parameters.AddWithValue("Name_Ship_From", nameFromBox.Text);
                    command.Parameters.AddWithValue("Address_From", addressFromBox.Text);      
                    command.Parameters.AddWithValue("Name_Ship_To", nameToBox.Text);
                    command.Parameters.AddWithValue("City_From", cityFromBox.Text);
                    command.Parameters.AddWithValue("Address_To", addressToBox.Text);
                    command.Parameters.AddWithValue("City_To", CityToBox.Text);
                    command.Parameters.AddWithValue("Phone_From", phoneFromBox.Text);
                    command.Parameters.AddWithValue("Phone_To", phoneToBox.Text);
                    command.Parameters.AddWithValue("Special_Information", specialInfBox.Text);         
                    command.Parameters.AddWithValue("Customer_Order_Number", custmrOrdrNmbrBox.Text);
                   // command.Parameters.AddWithValue("Goods_Name", goodNameBox.Text);
                    command.Parameters.AddWithValue("Container_Plomb_Nmbr", nmbrPlombBox.Text);
                    command.Parameters.AddWithValue("Goods_Type", goodsTypeCmbBox.Text);
                    command.Parameters.AddWithValue("Capacity", capacityBox.Text);
                    command.Parameters.AddWithValue("Weight", weightBox.Text);
                    command.Parameters.AddWithValue("Type_of_Container", typeContBox.Text);
                    command.Parameters.AddWithValue("Capacity_Ins", capacityInsBox.Text);
                    command.Parameters.AddWithValue("Capacity_Out", capacityOutBox.Text);
                    command.Parameters.AddWithValue("Teu", teuBox.Text);
                 //   command.Parameters.AddWithValue("@images", images);  
                    await command.ExecuteNonQueryAsync();
                   DialogResult result = MetroMessageBox.Show(this, "Накладная успешно добавлена. Чтобы ее просмотреть зайдите в меню 'Просмотр'", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                   if (result == DialogResult.OK)
                   {
                       SqlCommand command2 = new SqlCommand("INSERT INTO  [PurchaseInvoice] (Date_of_Bill,Carrier_Name,Name_Ship_From,Address_From,City_From,Name_Ship_To,Address_To,City_To,Phone_To,Phone_From,Special_Information,Customer_Order_Number,Container_Plomb_Nmbr,Goods_Type,Capacity,Weight,Type_of_Container,Capacity_Ins,Capacity_Out,Teu) VALUES(@Date_of_Bill,@Carrier_Name,@Name_Ship_From,@Address_From,@City_From,@Name_Ship_To,@Address_To,@City_To,@Phone_To,@Phone_From,@Special_Information,@Customer_Order_Number,@Container_Plomb_Nmbr,@Goods_Type,@Capacity,@Weight,@Type_of_Container,@Capacity_Ins,@Capacity_Out,@Teu)", sqlConnection);
                       command2.Parameters.AddWithValue("Date_of_Bill", metroDateTime1.Value.ToString("MM/dd/yyyy"));
                       //   command.Parameters.AddWithValue("Landing_Bill_Number", billLandBox.Text);
                       command2.Parameters.AddWithValue("Carrier_Name", carriernmBox.Text);
                       command2.Parameters.AddWithValue("Name_Ship_From", nameFromBox.Text);
                       command2.Parameters.AddWithValue("Address_From", addressFromBox.Text);
                       command2.Parameters.AddWithValue("Name_Ship_To", nameToBox.Text);
                       command2.Parameters.AddWithValue("City_From", cityFromBox.Text);
                       command2.Parameters.AddWithValue("Address_To", addressToBox.Text);
                       command2.Parameters.AddWithValue("City_To", CityToBox.Text);
                       command2.Parameters.AddWithValue("Phone_From", phoneFromBox.Text);
                       command2.Parameters.AddWithValue("Phone_To", phoneToBox.Text);
                       command2.Parameters.AddWithValue("Special_Information", specialInfBox.Text);
                       command2.Parameters.AddWithValue("Customer_Order_Number", custmrOrdrNmbrBox.Text);
                       // command.Parameters.AddWithValue("Goods_Name", goodNameBox.Text);
                       command2.Parameters.AddWithValue("Container_Plomb_Nmbr", nmbrPlombBox.Text);
                       command2.Parameters.AddWithValue("Goods_Type", goodsTypeCmbBox.Text);
                       command2.Parameters.AddWithValue("Capacity", capacityBox.Text);
                       command2.Parameters.AddWithValue("Weight", weightBox.Text);
                       command2.Parameters.AddWithValue("Type_of_Container", typeContBox.Text);
                       command2.Parameters.AddWithValue("Capacity_Ins", capacityInsBox.Text);
                       command2.Parameters.AddWithValue("Capacity_Out", capacityOutBox.Text);
                       command2.Parameters.AddWithValue("Teu", teuBox.Text);
                    //   command2.Parameters.AddWithValue("@images", images);
                       await command2.ExecuteNonQueryAsync();
                   }
                
            }  
            else
            {
                MetroMessageBox.Show(this, "Заполните все поля (Поле 'Special Information' не является обязательным для заполнения", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


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
            red.ShowDialog();
        }

        private void gotoAudit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Audit audit = new Audit();
            audit.ShowDialog();
        }

        private void gotoSettings_Click(object sender, EventArgs e)
        {
            this.Hide();
            Settings sets = new Settings();
            sets.ShowDialog();
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

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            capacityBox.Text = "33 м3";
            weightBox.Text = "2 - 2,3 т";
            typeContBox.Text = "Standart | 20-футовый Dry Van ";
            capacityOutBox.Text = "2.43 | 6 | 2.59";
            capacityInsBox.Text = "2.35 / 5.9 / 2.39";
            teuBox.Text = "1";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            slideContMenu.Visible = false;
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
        private void bunifuImageButton4_Click(object sender, EventArgs e)
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

        private void bunifuImageButton7_Click(object sender, EventArgs e)
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

        private void cleanBtn_Click(object sender, EventArgs e)
        {
            capacityBox.Text = "";
            weightBox.Text = "";
            typeContBox.Text = "";
            capacityOutBox.Text = "";
            capacityInsBox.Text = "";
            teuBox.Text = "";

        }

        private void phoneFromBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"[0,1,2,3,4,5,6,7,8,9,\b]");
        }

        private void phoneToBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"[0,1,2,3,4,5,6,7,8,9,\b]");
        }

       
      /*
        private void loadBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png | jpg files(*.jpg) | *.jpg| ALL files(*.*)| *.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                imgList.ImageLocation = imgLocation;
            }
        }
                 /*
        private void saveBtn_Click(object sender, EventArgs e)
        {
            byte[] images = null;
            FileStream Stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(Stream);
            images = brs.ReadBytes((int)Stream.Length);

            connection.Open();
            string sqlQeury = "Insert into BillofLanding1 (Customer_Order_Number, Goods_List_Img) Values('" + custmrOrdrNmbrBox.Text + "',@images)";
            cmd = new SqlCommand(sqlQeury, connection);

            cmd.Parameters.Add(new SqlParameter("@images", images));
                                                                                             
            cmd.ExecuteNonQuery();
            connection.Close();
            MetroMessageBox.Show(this, "Data Saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
       */
        /*
        private void viewBtn_Click(object sender, EventArgs e)
        {
            connection.Open();
            string sqlQeury = "Select Goods_List_Img from BillofLanding1 where Landing_Bill_Number = '" + custmrOrdrNmbrBox.Text + "'";
            cmd = new SqlCommand(sqlQeury, connection);
            SqlDataReader DataRead = cmd.ExecuteReader();
            DataRead.Read();

            if (DataRead.HasRows)
            {
               // custmrOrdrNmbrBox.Text = DataRead[12].ToString();
                byte[] images = ((byte[])DataRead[0]);

                if (images == null)
                {
                    imgList.Image = null;
                }
                else
                {
                    MemoryStream mstream = new MemoryStream(images);
                    imgList.Image = Image.FromStream(mstream);

                }
            }
            else
            {
                MessageBox.Show("tasdasdnotabaasd");
            }
            connection.Close();
           */
        

       

    

        

        

        
       


     
       


    }

}
