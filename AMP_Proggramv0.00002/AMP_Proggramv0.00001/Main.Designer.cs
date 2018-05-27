namespace AMP_Proggramv0._00001
{
    partial class Main
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
            this.lookTile = new MetroFramework.Controls.MetroTile();
            this.redactTile = new MetroFramework.Controls.MetroTile();
            this.settingsTile = new MetroFramework.Controls.MetroTile();
            this.exitTile = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // lookTile
            // 
            this.lookTile.ActiveControl = null;
            this.lookTile.Location = new System.Drawing.Point(23, 73);
            this.lookTile.Name = "lookTile";
            this.lookTile.Size = new System.Drawing.Size(184, 117);
            this.lookTile.TabIndex = 2;
            this.lookTile.Text = "Просмотр";
            this.lookTile.UseSelectable = true;
            this.lookTile.Click += new System.EventHandler(this.lookTile_Click);
            // 
            // redactTile
            // 
            this.redactTile.ActiveControl = null;
            this.redactTile.BackColor = System.Drawing.Color.White;
            this.redactTile.Location = new System.Drawing.Point(213, 73);
            this.redactTile.Name = "redactTile";
            this.redactTile.PaintTileCount = false;
            this.redactTile.Size = new System.Drawing.Size(180, 117);
            this.redactTile.Style = MetroFramework.MetroColorStyle.Green;
            this.redactTile.TabIndex = 4;
            this.redactTile.Text = "Документооборот";
            this.redactTile.UseSelectable = true;
            this.redactTile.Click += new System.EventHandler(this.redactTile_Click);
            // 
            // settingsTile
            // 
            this.settingsTile.ActiveControl = null;
            this.settingsTile.Location = new System.Drawing.Point(23, 196);
            this.settingsTile.Name = "settingsTile";
            this.settingsTile.Size = new System.Drawing.Size(370, 114);
            this.settingsTile.Style = MetroFramework.MetroColorStyle.Silver;
            this.settingsTile.TabIndex = 6;
            this.settingsTile.Text = "Регистрация";
            this.settingsTile.UseSelectable = true;
            this.settingsTile.Click += new System.EventHandler(this.settingsTile_Click);
            // 
            // exitTile
            // 
            this.exitTile.ActiveControl = null;
            this.exitTile.Location = new System.Drawing.Point(23, 316);
            this.exitTile.Name = "exitTile";
            this.exitTile.Size = new System.Drawing.Size(266, 104);
            this.exitTile.Style = MetroFramework.MetroColorStyle.Purple;
            this.exitTile.TabIndex = 7;
            this.exitTile.Text = "Выход";
            this.exitTile.UseSelectable = true;
            this.exitTile.Click += new System.EventHandler(this.exitTile_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(327, 369);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(75, 23);
            this.metroTile1.TabIndex = 8;
            this.metroTile1.Text = "metroTile1";
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Visible = false;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 448);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.exitTile);
            this.Controls.Add(this.settingsTile);
            this.Controls.Add(this.redactTile);
            this.Controls.Add(this.lookTile);
            this.Name = "Main";
            this.Text = "Главное Меню";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile lookTile;
        private MetroFramework.Controls.MetroTile redactTile;
        private MetroFramework.Controls.MetroTile settingsTile;
        private MetroFramework.Controls.MetroTile exitTile;
        private MetroFramework.Controls.MetroTile metroTile1;
    }
}