using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using MetroFramework;
namespace AMP_Proggramv0._00001
{
    public partial class FormForTesting : Form
    {
        public FormForTesting()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Frozen_Heart\Documents\Visual Studio 2013\Projects\AMP_Proggramv0.00002\AMP_Proggramv0.00001\AMPDB.mdf;Integrated Security=True;Connect Timeout=30");
        string imgLocation = "";
        SqlCommand cmd;

        private void FormForTesting_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            if (sidemenu.Width == 50)
            {
                sidemenu.Visible = false;
                sidemenu.Width = 260;

                panelAnimator.ShowSync(sidemenu);
            }
            else
            {
                sidemenu.Visible = false;
                sidemenu.Width = 50;

                panelAnimator.ShowSync(sidemenu);
            }
        }

        private void FormForTesting_Load(object sender, EventArgs e)
        {

        }
    }
}     /*
        private void bntSlide2_Click(object sender, EventArgs e)
        {
            if (slidemenu2.Width == 27 && slidemenu2.Height == 19)
            {
                slidemenu2.Visible = false;
                slidemenu2.Width = 150;
                slidemenu2.Height = 150;
                

                panelAnimator.ShowSync(slidemenu2);
            }
            else
            {
                slidemenu2.Visible = false;
                slidemenu2.Width = 27;
                slidemenu2.Height = 19;
                

               // panelAnimator.ShowSync(slidemenu2);
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png | jpg files(*.jpg) | *.jpg| ALL files(*.*)| *.*";
            if (dialog.ShowDialog()==DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                pictureBox1.ImageLocation = imgLocation;
            }
        }

        private void saveBnt_Click(object sender, EventArgs e)
        {
            byte[] images = null;
            FileStream Stream = new FileStream(imgLocation,FileMode.Open,FileAccess.Read);
            BinaryReader brs = new BinaryReader(Stream);
            images = brs.ReadBytes((int)Stream.Length);

            connection.Open();
            string sqlQeury = "Insert into TestingTable (Name, Image) Values('"+nameBox.Text+"',@images)";
            cmd = new SqlCommand(sqlQeury, connection);
           
            cmd.Parameters.Add(new SqlParameter("@images", images));

            cmd.ExecuteNonQuery();
            connection.Close();
            MetroMessageBox.Show(this,"Data Saved","Information", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            connection.Open();
            string sqlQeury = "Select Name,Image from TestingTable where id = '"+idBox.Text+"'";
            cmd = new SqlCommand(sqlQeury, connection);
            SqlDataReader DataRead = cmd.ExecuteReader();
            DataRead.Read();

            if (DataRead.HasRows)
            {
                nameBox.Text = DataRead[0].ToString();
                byte[] images = ((byte[])DataRead[1]);

                if (images == null)
                {
                    pictureBox1.Image = null;
                }
                else
                {
                    MemoryStream mstream = new MemoryStream(images);
                    pictureBox1.Image = Image.FromStream(mstream);

                }
                }
            else
            {
                MessageBox.Show("tasdasdnotabaasd");
            }
            connection.Close();
        }

    }
             
       
        }
            */  
    
