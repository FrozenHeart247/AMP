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
    public partial class Registration : MetroFramework.Forms.MetroForm
    {
        SqlConnection sqlConnection;
        public Registration()
        {
            InitializeComponent();
        }

        private async void Registration_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\AMP\AMP_Proggramv0.00002\AMP_Proggramv0.00001\AMPDB.mdf;Integrated Security=True;Connect Timeout=30";
            sqlConnection = new SqlConnection(connectionString);
            await sqlConnection.OpenAsync();
        }
        
        private void Registration_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();
            Application.Exit();
            
              }

        private async void registerBtn_Click(object sender, EventArgs e)
        {     
           
              
            if (!string.IsNullOrEmpty(nameBox.Text) && !string.IsNullOrWhiteSpace(nameBox.Text) &&
               !string.IsNullOrEmpty(loginBox.Text) && !string.IsNullOrWhiteSpace(loginBox.Text) &&
               !string.IsNullOrEmpty(passwordBox.Text) && !string.IsNullOrWhiteSpace(passwordBox.Text) &&
               !string.IsNullOrEmpty(mailBox.Text) && !string.IsNullOrWhiteSpace(mailBox.Text) &&
               !string.IsNullOrEmpty(phoneBox.Text) && !string.IsNullOrWhiteSpace(phoneBox.Text))
            {
                SqlCommand command = new SqlCommand("INSERT INTO [Login] (Name,Login,Password,Mail,Phone) VALUES(@Name,@Login,@Password,@Mail,@Phone)", sqlConnection);
                command.Parameters.AddWithValue("Name", nameBox.Text);
                command.Parameters.AddWithValue("Login", loginBox.Text);
                command.Parameters.AddWithValue("Password", passwordBox.Text);
                command.Parameters.AddWithValue("Mail", mailBox.Text);
                command.Parameters.AddWithValue("Phone", phoneBox.Text);
                await command.ExecuteNonQueryAsync();
                 DialogResult result = MetroMessageBox.Show(this, "Регистрация Завершена", "Success", MessageBoxButtons.OK, MessageBoxIcon.Question);
                if(result == DialogResult.OK) 
                {
                    this.Hide();
                    Main main = new Main();
                    main.Show();


                }
            }
            else
                MetroMessageBox.Show(this, "Вы заполнили не все проля", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Show();
        }

        private void checkbox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox1.Checked)
            {
                registerBtn.Visible = true;
            }
            else
            {
                registerBtn.Visible = false;
            }
        }

       

       
    }
}
