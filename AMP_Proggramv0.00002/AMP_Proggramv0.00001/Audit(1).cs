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
    public partial class Audit : MetroFramework.Forms.MetroForm
    {
        SqlConnection sqlConnection;
        public Audit()
        {
            InitializeComponent();
        }
                   
        private async void Audit_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aMPDBDFriday.BillofLanding1". При необходимости она может быть перемещена или удалена.

           

            // TODO: данная строка кода позволяет загрузить данные в таблицу "aMPDBDQWERTY.BillofLanding1". При необходимости она может быть перемещена или удалена.
            string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\AMP\AMP_Proggramv0.00002\AMP_Proggramv0.00001\AMPDB.mdf;Integrated Security=True;Connect Timeout=30";
            sqlConnection = new SqlConnection(connectionString);
            await sqlConnection.OpenAsync();
            DataSet ds = new DataSet();
            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\AMP\AMP_Proggramv0.00002\AMP_Proggramv0.00001\AMPDB.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand("select * from BillofLanding1", con);
                con.Open();
                da.Fill(ds);
                metroGrid1.DataSource = ds.Tables[0];
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

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Redact red = new Redact();
            red.Show();
        }


       
        
        private void bntSlide_Click_1(object sender, EventArgs e)
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

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            nmbrBillBox.Text = metroGrid1.Rows[e.RowIndex].Cells[0].Value.ToString();
            typeContBox.Text = metroGrid1.Rows[e.RowIndex].Cells[17].Value.ToString();
            goodsTypeBox.Text = metroGrid1.Rows[e.RowIndex].Cells[14].Value.ToString();
            weightBox.Text = metroGrid1.Rows[e.RowIndex].Cells[16].Value.ToString();
            specinfBox.Text = metroGrid1.Rows[e.RowIndex].Cells[11].Value.ToString();
            teuBox.Text = metroGrid1.Rows[e.RowIndex].Cells[20].Value.ToString();

        }

        private async void sendOnStrgBtn_Click_1(object sender, EventArgs e)
        {
            
           
                
////////////////////////////////////////////// 1 склад  Foodstuffs
            if (nmbrStorageBox.Text != "1" && goodsTypeBox.Text == "Foodstuffs" )   
            {
                MetroMessageBox.Show(this, "Данный тип товара невозможно отправить на этот склад");
                return;
            }
            else
            {
                if (nmbrStorageBox.Text == "1" && goodsTypeBox.Text == "Foodstuffs")
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
                        DialogResult dialog1 =  MetroMessageBox.Show(this, "Груз перемещен на склад 1", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if(dialog1 == DialogResult.OK)
                        {
                            SqlCommand command2 = new SqlCommand("UPDATE StorageCongestion SET Storage1 = Storage1 - @Teu where id=1", sqlConnection);
                            command2.Parameters.AddWithValue("Teu", teuBox.Text);
                            //   command.Parameters.AddWithValue("znach", znachBox.Text);
                            //  command.Parameters.AddWithValue("Id", idBox.Text);
                            await command2.ExecuteNonQueryAsync();
                        }
                        return;
                    }


                }
            }
///////////////////////////////////////////// 2 Склад      

            if (nmbrStorageBox.Text != "2" && goodsTypeBox.Text == "Electronic Goods")
            {
                MetroMessageBox.Show(this, "Данный тип товара невозможно отправить на этот склад");
                return;
            }
            else

                if (nmbrStorageBox.Text == "2" && goodsTypeBox.Text == "Electronic Goods" )
            {
                DialogResult result2 = MetroMessageBox.Show(this, "Вы точно хотите переместить этот груз на 'Склад2'?", "Question", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result2 == DialogResult.Yes)
                {
                    SqlCommand command = new SqlCommand("INSERT INTO [Storage2] (Number_of_Bill,Type_of_Container,Goods_Type,Weight,Teu,Special_Information) VALUES(@Number_of_Bill,@Type_of_Container,@Goods_Type,@Weight,@Teu,@Special_Information)", sqlConnection);
                    command.Parameters.AddWithValue("Number_of_Bill", nmbrBillBox.Text);
                    command.Parameters.AddWithValue("Type_of_Container", typeContBox.Text);
                    command.Parameters.AddWithValue("Goods_Type", goodsTypeBox.Text);
                    command.Parameters.AddWithValue("Weight", weightBox.Text);
                    command.Parameters.AddWithValue("Teu", teuBox.Text);
                    command.Parameters.AddWithValue("Special_Information", specinfBox.Text);
                    await command.ExecuteNonQueryAsync();
                    DialogResult dialog2 = MetroMessageBox.Show(this, "Груз перемещен на склад 2", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dialog2 == DialogResult.OK)
                    {
                        SqlCommand command3 = new SqlCommand("UPDATE StorageCongestion SET Storage2 = Storage2 - @Teu where id=1", sqlConnection);
                        command3.Parameters.AddWithValue("Teu", teuBox.Text);
                        //   command.Parameters.AddWithValue("znach", znachBox.Text);
                        //  command.Parameters.AddWithValue("Id", idBox.Text);
                        await command3.ExecuteNonQueryAsync();
                    }
                    return;
                }
            }
/////////////////////////////////////////////////// 3 Склад
            if (nmbrStorageBox.Text != "3" && goodsTypeBox.Text == "Agricultural Goods")
            {
                MetroMessageBox.Show(this, "Данный тип товара невозможно отправить на этот склад");
                return;
            }
            else

                if (nmbrStorageBox.Text == "3" && goodsTypeBox.Text == "Agricultural Goods" )
                {
                    DialogResult result3 = MetroMessageBox.Show(this, "Вы точно хотите переместить этот груз на 'Склад3'?", "Question", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (result3 == DialogResult.Yes)
                    {
                        SqlCommand command = new SqlCommand("INSERT INTO [Storage3] (Number_of_Bill,Type_of_Container,Goods_Type,Weight,Teu,Special_Information) VALUES(@Number_of_Bill,@Type_of_Container,@Goods_Type,@Weight,@Teu,@Special_Information)", sqlConnection);
                        command.Parameters.AddWithValue("Number_of_Bill", nmbrBillBox.Text);
                        command.Parameters.AddWithValue("Type_of_Container", typeContBox.Text);
                        command.Parameters.AddWithValue("Goods_Type", goodsTypeBox.Text);
                        command.Parameters.AddWithValue("Weight", weightBox.Text);
                        command.Parameters.AddWithValue("Teu", teuBox.Text);
                        command.Parameters.AddWithValue("Special_Information", specinfBox.Text);
                        await command.ExecuteNonQueryAsync();
                        DialogResult dialog3 = MetroMessageBox.Show(this, "Груз перемещен на склад 3", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (dialog3 == DialogResult.OK)
                        {
                            SqlCommand command4 = new SqlCommand("UPDATE StorageCongestion SET Storage3 = Storage3 - @Teu where id=1", sqlConnection);
                            command4.Parameters.AddWithValue("Teu", teuBox.Text);
                            //   command.Parameters.AddWithValue("znach", znachBox.Text);
                            //  command.Parameters.AddWithValue("Id", idBox.Text);
                            await command4.ExecuteNonQueryAsync();
                        }
                        return;
                    }
                }
/////////////////////////////////    4-sklad
            if (nmbrStorageBox.Text != "4" && goodsTypeBox.Text == "Construction Materials")
            {
                MetroMessageBox.Show(this, "Данный тип товара невозможно отправить на этот склад");
                return;
            }
            else

                if (nmbrStorageBox.Text == "4" && goodsTypeBox.Text == "Construction Materials" )
                {
                    DialogResult result4 = MetroMessageBox.Show(this, "Вы точно хотите переместить этот груз на 'Склад4'?", "Question", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (result4 == DialogResult.Yes)
                    {
                        SqlCommand command = new SqlCommand("INSERT INTO [Storage4] (Number_of_Bill,Type_of_Container,Goods_Type,Weight,Teu,Special_Information) VALUES(@Number_of_Bill,@Type_of_Container,@Goods_Type,@Weight,@Teu,@Special_Information)", sqlConnection);
                        command.Parameters.AddWithValue("Number_of_Bill", nmbrBillBox.Text);
                        command.Parameters.AddWithValue("Type_of_Container", typeContBox.Text);
                        command.Parameters.AddWithValue("Goods_Type", goodsTypeBox.Text);
                        command.Parameters.AddWithValue("Weight", weightBox.Text);
                        command.Parameters.AddWithValue("Teu", teuBox.Text);
                        command.Parameters.AddWithValue("Special_Information", specinfBox.Text);
                        await command.ExecuteNonQueryAsync();
                        DialogResult dialog4 = MetroMessageBox.Show(this, "Груз перемещен на склад 4", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (dialog4 == DialogResult.OK)
                        {
                            SqlCommand command5 = new SqlCommand("UPDATE StorageCongestion SET Storage4 = Storage4 - @Teu where id=1", sqlConnection);
                            command5.Parameters.AddWithValue("Teu", teuBox.Text);
                            //   command.Parameters.AddWithValue("znach", znachBox.Text);
                            //  command.Parameters.AddWithValue("Id", idBox.Text);
                            await command5.ExecuteNonQueryAsync();
                        }
                        return;
                    }
                }
                                           
////////////////////////////////////////////// 

            
               
            
///////////////////////////////////
           
 //конец      
        }

        private void gotoLookUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lookup look = new Lookup();
            look.ShowDialog();
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

        private void goLoolStorageBtn_Click(object sender, EventArgs e)
        {
            LookUpStorages lookstore = new LookUpStorages();
            lookstore.Show();
        }
                                                                                    
        private void bntSlide2_Click(object sender, EventArgs e)
        {
            if (slidemenu2.Width == 364 && slidemenu2.Height == 174)
            {
                slidemenu2.Visible = false;
                slidemenu2.Width = 365;
                slidemenu2.Height = 175;
                                                     

                panelAnimator2.ShowSync(slidemenu2);
            }
            else
            {
                slidemenu2.Visible = false;
                slidemenu2.Width = 364;
                slidemenu2.Height = 174;
                

               // panelAnimator.ShowSync(slidemenu2);
            }
        }

        private void bunifuGradientPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sendOnStrgBtn_MouseClick(object sender, MouseEventArgs e)
        {
            if (nmbrStorageBox.Text != "5" && nmbrStorageBox.Text != "4" && nmbrStorageBox.Text != "3" && nmbrStorageBox.Text != "2" && nmbrStorageBox.Text != "1")
            {
                MetroMessageBox.Show(this, "Такого склада не существует. Для большей информации перейдите в меню 'Посмотрет информацю о складах'","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
             
            }
            

        }

        private async void sendOnStrgTimeBtn_Click(object sender, EventArgs e)
        {
            if (nmbrStorageBox.Text == "5" || nmbrStorageBox.Text == "4" || nmbrStorageBox.Text == "3" || nmbrStorageBox.Text == "2" || nmbrStorageBox.Text == "1")
            {
                DialogResult result = MetroMessageBox.Show(this, "Вы точно хотите переместить этот груз на 'Склад5'?", "Question", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    SqlCommand command = new SqlCommand("INSERT INTO [Storage5] (Number_of_Bill,Type_of_Container,Goods_Type,Weight,Teu,Special_Information) VALUES(@Number_of_Bill,@Type_of_Container,@Goods_Type,@Weight,@Teu,@Special_Information)", sqlConnection);
                    command.Parameters.AddWithValue("Number_of_Bill", nmbrBillBox.Text);
                    command.Parameters.AddWithValue("Type_of_Container", typeContBox.Text);
                    command.Parameters.AddWithValue("Goods_Type", goodsTypeBox.Text);
                    command.Parameters.AddWithValue("Weight", weightBox.Text);
                    command.Parameters.AddWithValue("Teu", teuBox.Text);
                    command.Parameters.AddWithValue("Special_Information", specinfBox.Text);
                    await command.ExecuteNonQueryAsync();
                    DialogResult dialog = MetroMessageBox.Show(this, "Груз перемещен на склад 5", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dialog == DialogResult.OK)
                    {
                        SqlCommand command6 = new SqlCommand("UPDATE StorageCongestion SET Storage5 = Storage5 - @Teu where id=5", sqlConnection);
                        command6.Parameters.AddWithValue("Teu", teuBox.Text);
                        //   command.Parameters.AddWithValue("znach", znachBox.Text);
                        //  command.Parameters.AddWithValue("Id", idBox.Text);
                        await command6.ExecuteNonQueryAsync();
                    }
                    
                }
            }
            if (nmbrStorageBox.Text != "5" || nmbrStorageBox.Text != "4" || nmbrStorageBox.Text != "3" || nmbrStorageBox.Text != "2" || nmbrStorageBox.Text != "1")
            {
                return;
                MetroMessageBox.Show(this, "Такого склада не существует, проверьте введенные данные. Для большей информации перейдите в меню 'Посмотрет информацю о складах'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (goodsTypeBox.Text == "Toys")
            {
                nmbrStorageBox.Text = "1";
            }
        }

       
        private void slidemenu2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void billnmbrSearchBox_KeyUp(object sender, KeyEventArgs e)
        {
            SqlConnection sqlConn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\AMP\AMP_Proggramv0.00002\AMP_Proggramv0.00001\AMPDB.mdf;Integrated Security=True;Connect Timeout=30");
            sqlConn.Open();
            //выполняем запрос
            SqlCommand sqlCom = new SqlCommand("SELECT * FROM BillofLanding1 WHERE (Landing_Bill_Number LIKE '%" + billnmbrSearchBox.Text + "%')", sqlConn);
            SqlDataReader dr = sqlCom.ExecuteReader();
            //результат запроса суем в таблицу
            DataTable dt = new DataTable();
            dt.Load(dr);
            //заполняем datagridview - (поле данных...где выводится результат поиска)
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

        private void Audit_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();
            Application.Exit();
        }

       
       /*
        private void nmbrStorageBox_Click(object sender, EventArgs e)
        {
            if (goodsTypeBox.Text=="Electronic Goods")
            {
                nmbrStorageBox.Text = "1";
            }


        }
        */
        

        


    }
}
