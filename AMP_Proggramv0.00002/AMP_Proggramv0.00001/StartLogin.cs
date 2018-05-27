using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data.SqlTypes;
using MetroFramework;

namespace AMP_Proggramv0._00001
{
    public partial class StartLogin : MetroFramework.Forms.MetroForm
    {
        SqlConnection sqlConnection;
        public StartLogin()
        {
            InitializeComponent();
        }

        private async void StartLogin_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\AMP\AMP_Proggramv0.00002\AMP_Proggramv0.00001\AMPDB.mdf;Integrated Security=True;Connect Timeout=30";
            sqlConnection = new SqlConnection(connectionString);
            await sqlConnection.OpenAsync();
            
            
        }

       
     

        private void StartLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();
           // Application.Exit();
        }

       
                      

        private void loginBnt_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From Login where Login='" + loginBox.Text + "'and Password='" + passBox.Text + "'", sqlConnection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                MetroMessageBox.Show(this, "Вы успешно зашли в систему", "Success", MessageBoxButtons.OK, MessageBoxIcon.Question);
                this.Hide();
                Redact setts = new Redact();
                setts.Show();
            }
            else
            {
                MetroMessageBox.Show(this, "Проверьте Логин и пароль", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void exitBnt_Click(object sender, EventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();
            {
                this.Hide();
                Main main = new Main();
                main.Show();
            }
        }

        private void loginBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From Login where Login='" + loginBox.Text + "'and Password='" + passBox.Text + "'", sqlConnection);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    MetroMessageBox.Show(this, "Вы успешно зашли в систему", "Success", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    this.Hide();
                    Redact setts = new Redact();
                    setts.Show();
                }
                else
                {
                    MetroMessageBox.Show(this, "Проверьте Логин и пароль", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void passBox_KeyUp(object sender, KeyEventArgs e)
        {
                     if (e.KeyCode == Keys.Enter)
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From Login where Login='" + loginBox.Text + "'and Password='" + passBox.Text + "'", sqlConnection);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    MetroMessageBox.Show(this, "Вы успешно зашли в систему", "Success", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    this.Hide();
                    Redact setts = new Redact();
                    setts.Show();
                }
                else
                {
                    MetroMessageBox.Show(this, "Проверьте Логин и пароль", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        
        }

        private void loginBox_OnValueChanged(object sender, EventArgs e)
        {

        }

       

       

                                                                                                                                                                                                                           

        

       
       

        

        

        

      
        
    }
}
