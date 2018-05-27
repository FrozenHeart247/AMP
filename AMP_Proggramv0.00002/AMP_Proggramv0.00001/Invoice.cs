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
using System.IO;
using System.Windows.Forms;
using MetroFramework;

namespace AMP_Proggramv0._00001
{
    public partial class Invoice : MetroFramework.Forms.MetroForm
    {
        SqlConnection sqlConnection;
        string imgLocation = "";
        public Invoice()
        {
            InitializeComponent();
        }

        private async void Invoice_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\AMP\AMP_Proggramv0.00002\AMP_Proggramv0.00001\AMPDB.mdf;Integrated Security=True;Connect Timeout=30";
            sqlConnection = new SqlConnection(connectionString);
            await sqlConnection.OpenAsync();
        }
       
        private void backBnt_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddWaybill addw = new AddWaybill();
            addw.ShowDialog();
        }

        private void addInvoiceBtn_Click(object sender, EventArgs e)
        {

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

        private void addInvoiceBtn_Click_1(object sender, EventArgs e)
        {
            if (imgList.Image == null)
            {
                MetroMessageBox.Show(this,"Error","Графический файл не загружен!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                byte[] images = null;
                FileStream Stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(Stream);
                images = brs.ReadBytes((int)Stream.Length);

                SqlCommand command = new SqlCommand("INSERT INTO  [InvoiceBill] (Company_Name_From,Company_Location_From,Phone_From,Fax_From,Web_Site_From,Email_From,Date,Company_Name_To,Contact_Name,Phone_To,Fax_To,Company_Location_To,Goods_Img_List) VALUES(@Company_Name_From,@Company_Location_From,@Phone_From,@Fax_From,@Web_Site_From,@Email_From,@Date,@Company_Name_To,@Contact_Name,@Phone_To,@Fax_To,@Company_Location_To,@images)", sqlConnection);
                command.Parameters.AddWithValue("Company_Name_From", compNameBox.Text);
                command.Parameters.AddWithValue("Company_Location_From", complocBox.Text);
                command.Parameters.AddWithValue("Phone_From", phoneBox.Text);
                command.Parameters.AddWithValue("Fax_From", faxBox.Text);
                command.Parameters.AddWithValue("Web_Site_From", webBox.Text);
                command.Parameters.AddWithValue("Email_From", emailBox.Text);
                command.Parameters.AddWithValue("Date", metroDateTime1.Value.ToString("MM/dd/yyyy"));
                command.Parameters.AddWithValue("Company_Name_To", compNameToBox.Text);
                command.Parameters.AddWithValue("Contact_Name", conactNameBox.Text);
                command.Parameters.AddWithValue("Phone_To", phoneToBox.Text);
                command.Parameters.AddWithValue("Fax_To", faxToBox.Text);
                command.Parameters.AddWithValue("Company_Location_To", compRegToBox.Text);
                command.Parameters.AddWithValue("@images", images);
                command.ExecuteNonQuery();
            } 
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
            red.ShowDialog();
        }

        private void gotoAudit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Audit aud = new Audit();
            aud.ShowDialog();
        }

        private void gotoSettings_Click(object sender, EventArgs e)
        {
            this.Hide();
            Settings setts = new Settings();
            setts.ShowDialog();

        }

        private void Invoice_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();
            Application.Exit();
        }


        private void faxBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"[0,1,2,3,4,5,6,7,8,9,\b]");
        }

        private void phoneBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"[0,1,2,3,4,5,6,7,8,9,\b]");
        }

        private void phoneToBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"[0,1,2,3,4,5,6,7,8,9,\b]");
        }

        private void faxToBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"[0,1,2,3,4,5,6,7,8,9,\b]");
        }

       

        
       
    }
}
