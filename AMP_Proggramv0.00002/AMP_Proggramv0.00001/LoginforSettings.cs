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
    public partial class LoginforSettings : MetroFramework.Forms.MetroForm
    {
        SqlConnection sqlConnection;
        public LoginforSettings()
        {
            InitializeComponent();
        }

        private async void LoginforSettings_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\AMP\AMP_Proggramv0.00002\AMP_Proggramv0.00001\AMPDB.mdf;Integrated Security=True;Connect Timeout=30";
            sqlConnection = new SqlConnection(connectionString);
            await sqlConnection.OpenAsync();
        }

    
        private void LoginforSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();
            {
                Application.Exit();
            }


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
                Settings setts = new Settings();
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




    }
}
