namespace AMP_Proggramv0._00001
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.goRegistrTile = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.backBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // goRegistrTile
            // 
            this.goRegistrTile.ActiveControl = null;
            this.goRegistrTile.Location = new System.Drawing.Point(23, 83);
            this.goRegistrTile.Name = "goRegistrTile";
            this.goRegistrTile.Size = new System.Drawing.Size(184, 89);
            this.goRegistrTile.Style = MetroFramework.MetroColorStyle.Silver;
            this.goRegistrTile.TabIndex = 0;
            this.goRegistrTile.Text = "Регистрация";
            this.goRegistrTile.UseSelectable = true;
            this.goRegistrTile.Click += new System.EventHandler(this.goRegistrTile_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(225, 83);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(184, 89);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroTile1.TabIndex = 1;
            this.metroTile1.Text = "Настройки языка";
            this.metroTile1.UseSelectable = true;
            // 
            // backBtn
            // 
            this.backBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backBtn.BackgroundImage")));
            this.backBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Location = new System.Drawing.Point(20, 22);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(32, 32);
            this.backBtn.TabIndex = 2;
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 220);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.goRegistrTile);
            this.Name = "Settings";
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "    Настройки";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile goRegistrTile;
        private MetroFramework.Controls.MetroTile metroTile1;
        private System.Windows.Forms.Button backBtn;
    }
}