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
    public partial class AddBill2 : MetroFramework.Forms.MetroForm
    {
        SqlConnection sqlConnection;
        public AddBill2()
        {
            InitializeComponent();
        }

        private async void AddBill2_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\AMP\AMP_Proggramv0.00002\AMP_Proggramv0.00001\AMPDB.mdf;Integrated Security=True;Connect Timeout=30";
            sqlConnection = new SqlConnection(connectionString);
            await sqlConnection.OpenAsync();
        }

        private async void addBnt_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(dateBox.Text) && !string.IsNullOrWhiteSpace(dateBox.Text) &&
               !string.IsNullOrEmpty(billLandBox.Text) && !string.IsNullOrWhiteSpace(billLandBox.Text) &&
               !string.IsNullOrEmpty(carriernmBox.Text) && !string.IsNullOrWhiteSpace(carriernmBox.Text) &&
                !string.IsNullOrEmpty(addressFromBox.Text) && !string.IsNullOrWhiteSpace(addressFromBox.Text) &&
                !string.IsNullOrEmpty(cityFromBox.Text) && !string.IsNullOrWhiteSpace(cityFromBox.Text) &&
                !string.IsNullOrEmpty(nameToBox.Text) && !string.IsNullOrWhiteSpace(nameToBox.Text) &&
                !string.IsNullOrEmpty(addressToBox.Text) && !string.IsNullOrWhiteSpace(addressToBox.Text) &&
                !string.IsNullOrEmpty(phoneBox.Text) && !string.IsNullOrWhiteSpace(phoneBox.Text) &&
                // !string.IsNullOrEmpty(specialInfBox.Text) && !string.IsNullOrWhiteSpace(specialInfBox.Text) &&
                !string.IsNullOrEmpty(custmrOrdrNmbrBox.Text) && !string.IsNullOrWhiteSpace(custmrOrdrNmbrBox.Text) &&
                !string.IsNullOrEmpty(goodNameBox.Text) && !string.IsNullOrWhiteSpace(goodNameBox.Text) &&
                !string.IsNullOrEmpty(goodsTypeCmbBox.Text) && !string.IsNullOrWhiteSpace(goodsTypeCmbBox.Text) &&
                !string.IsNullOrEmpty(weightBox.Text) && !string.IsNullOrWhiteSpace(weightBox.Text))
            {
                //SqlCommand command = new SqlCommand("INSERT INTO [Products] (Name,Goods_Type,Number_of_Place_on_Storage,Type_of_Storage,Number_of_Storage,Number_of_Container,Arrival_Date,Dispatch_Date,Number_of_Ship,Number_of_Port) VALUES(@Name,@Goods_Type,@Number_of_Place_on_Storage,@Type_of_Storage,@Number_of_Storage,@Number_of_Container,@Arrival_Date,@Dispatch_Date,@Number_of_Ship,@Number_of_Port)", sqlConnection);
                SqlCommand command = new SqlCommand("INSERT INTO [BillofLanding2] (Date_of_Bill,Landing_Bill_Number,Carrier_Name,Name_Ship_From,Address_From,City_From,Name_Ship_To,Address_To,City_To,Phone,Special_Information,Customer_Order_Number,Goods_Name,Goods_Type,Weight) VALUES(@Date_of_Bill,@Landing_Bill_Number,@Carrier_Name,@Name_Ship_From,@Address_From,@City_From,@Name_Ship_To,@Address_To,@City_To,@Phone,@Special_Information,@Customer_Order_Number,@Goods_Name,@Goods_Type,@Weight)", sqlConnection);
                command.Parameters.AddWithValue("Date_of_Bill", dateBox.Text);
                command.Parameters.AddWithValue("Landing_Bill_Number", billLandBox.Text);
                command.Parameters.AddWithValue("Carrier_Name", carriernmBox.Text);
                command.Parameters.AddWithValue("Name_Ship_From", nameFromBox.Text);
                command.Parameters.AddWithValue("Address_From", addressFromBox.Text);
                command.Parameters.AddWithValue("City_From", cityFromBox.Text);
                command.Parameters.AddWithValue("Name_Ship_To", nameToBox.Text);
                command.Parameters.AddWithValue("Address_To", addressToBox.Text);
                command.Parameters.AddWithValue("City_To", CityToBox.Text);
                command.Parameters.AddWithValue("Phone", phoneBox.Text);
                command.Parameters.AddWithValue("Special_Information", specialInfBox.Text);
                command.Parameters.AddWithValue("Customer_Order_Number", custmrOrdrNmbrBox.Text);
                command.Parameters.AddWithValue("Goods_Name", goodNameBox.Text);
                command.Parameters.AddWithValue("Goods_Type", goodsTypeCmbBox.Text);
                command.Parameters.AddWithValue("Weight", weightBox.Text);
                await command.ExecuteNonQueryAsync();
                MetroMessageBox.Show(this, "Накладная успешно добавлена. Чтобы ее просмотреть зайдите в меню 'Просмотр'", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MetroMessageBox.Show(this, "Заполните все поля (Поле 'Special Information' не является обязательным для заполнения", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddWaybill addwb = new AddWaybill();
            addwb.Show();
        }



    }
}
