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

namespace AMP_Proggramv0._00001
{               
    public partial class Main : MetroFramework.Forms.MetroForm
    {
        SqlConnection sqlConnection;
        public Main()
        {
            InitializeComponent();
        }
        private  void Main_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\AMP\AMP_Proggramv0.00002\AMP_Proggramv0.00001\AMPDB.mdf;Integrated Security=True;Connect Timeout=30";
            sqlConnection = new SqlConnection(connectionString);
             sqlConnection.Open();
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartLogin st = new StartLogin();
            st.Show();
        }

    

        private void lookTile_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lookup lookform = new Lookup();
            lookform.Show();
        }

    

        private void redactTile_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartLogin  start = new  StartLogin();
            start.ShowDialog();
        }

        private void exitTile_Click(object sender, EventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();
                Application.Exit();
            
        }

        

        private void settingsTile_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginforSettings logforsetts = new LoginforSettings();
            logforsetts.Show();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormForTesting form = new FormForTesting();
            form.Show();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();
               Application.Exit();
        }

      

       

       

       
    }
}
