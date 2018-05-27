namespace AMP_Proggramv0._00001
{
    partial class StartLogin
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.passBox = new ns1.BunifuMaterialTextbox();
            this.loginBox = new ns1.BunifuMaterialTextbox();
            this.exitBnt = new ns1.BunifuFlatButton();
            this.loginBnt = new ns1.BunifuFlatButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // passBox
            // 
            this.passBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.passBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.passBox.HintForeColor = System.Drawing.Color.Empty;
            this.passBox.HintText = "Password";
            this.passBox.isPassword = true;
            this.passBox.LineFocusedColor = System.Drawing.Color.Purple;
            this.passBox.LineIdleColor = System.Drawing.Color.Gray;
            this.passBox.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.passBox.LineThickness = 3;
            this.passBox.Location = new System.Drawing.Point(87, 117);
            this.passBox.Margin = new System.Windows.Forms.Padding(4);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(191, 33);
            this.passBox.TabIndex = 132;
            this.passBox.Text = "123";
            this.passBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.passBox_KeyUp);
            // 
            // loginBox
            // 
            this.loginBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.loginBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.loginBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loginBox.HintForeColor = System.Drawing.Color.Empty;
            this.loginBox.HintText = "";
            this.loginBox.isPassword = false;
            this.loginBox.LineFocusedColor = System.Drawing.Color.Purple;
            this.loginBox.LineIdleColor = System.Drawing.Color.Gray;
            this.loginBox.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.loginBox.LineThickness = 3;
            this.loginBox.Location = new System.Drawing.Point(87, 60);
            this.loginBox.Margin = new System.Windows.Forms.Padding(4);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(191, 33);
            this.loginBox.TabIndex = 131;
            this.loginBox.Text = "user";
            this.loginBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.loginBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.loginBox_KeyUp);
            // 
            // exitBnt
            // 
            this.exitBnt.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.exitBnt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.exitBnt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitBnt.BorderRadius = 0;
            this.exitBnt.ButtonText = "              Выход";
            this.exitBnt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitBnt.DisabledColor = System.Drawing.Color.Gray;
            this.exitBnt.Iconcolor = System.Drawing.Color.Transparent;
            this.exitBnt.Iconimage = null;
            this.exitBnt.Iconimage_right = null;
            this.exitBnt.Iconimage_right_Selected = null;
            this.exitBnt.Iconimage_Selected = null;
            this.exitBnt.IconMarginLeft = 0;
            this.exitBnt.IconMarginRight = 0;
            this.exitBnt.IconRightVisible = true;
            this.exitBnt.IconRightZoom = 0D;
            this.exitBnt.IconVisible = true;
            this.exitBnt.IconZoom = 90D;
            this.exitBnt.IsTab = false;
            this.exitBnt.Location = new System.Drawing.Point(154, 157);
            this.exitBnt.Name = "exitBnt";
            this.exitBnt.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.exitBnt.OnHovercolor = System.Drawing.Color.MediumOrchid;
            this.exitBnt.OnHoverTextColor = System.Drawing.Color.White;
            this.exitBnt.selected = false;
            this.exitBnt.Size = new System.Drawing.Size(131, 38);
            this.exitBnt.TabIndex = 134;
            this.exitBnt.Text = "              Выход";
            this.exitBnt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitBnt.Textcolor = System.Drawing.Color.White;
            this.exitBnt.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBnt.Click += new System.EventHandler(this.exitBnt_Click);
            // 
            // loginBnt
            // 
            this.loginBnt.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.loginBnt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.loginBnt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginBnt.BorderRadius = 0;
            this.loginBnt.ButtonText = "               Авторизоваться";
            this.loginBnt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBnt.DisabledColor = System.Drawing.Color.Gray;
            this.loginBnt.Iconcolor = System.Drawing.Color.Transparent;
            this.loginBnt.Iconimage = null;
            this.loginBnt.Iconimage_right = null;
            this.loginBnt.Iconimage_right_Selected = null;
            this.loginBnt.Iconimage_Selected = null;
            this.loginBnt.IconMarginLeft = 0;
            this.loginBnt.IconMarginRight = 0;
            this.loginBnt.IconRightVisible = true;
            this.loginBnt.IconRightZoom = 0D;
            this.loginBnt.IconVisible = true;
            this.loginBnt.IconZoom = 90D;
            this.loginBnt.IsTab = false;
            this.loginBnt.Location = new System.Drawing.Point(17, 157);
            this.loginBnt.Name = "loginBnt";
            this.loginBnt.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.loginBnt.OnHovercolor = System.Drawing.Color.MediumOrchid;
            this.loginBnt.OnHoverTextColor = System.Drawing.Color.White;
            this.loginBnt.selected = false;
            this.loginBnt.Size = new System.Drawing.Size(131, 38);
            this.loginBnt.TabIndex = 133;
            this.loginBnt.Text = "               Авторизоваться";
            this.loginBnt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.loginBnt.Textcolor = System.Drawing.Color.White;
            this.loginBnt.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBnt.Click += new System.EventHandler(this.loginBnt_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(17, 128);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(56, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel2.TabIndex = 132;
            this.metroLabel2.Text = "Пароль";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(32, 74);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(47, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel1.TabIndex = 131;
            this.metroLabel1.Text = "Логин";
            // 
            // StartLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(319, 220);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.loginBox);
            this.Controls.Add(this.exitBnt);
            this.Controls.Add(this.loginBnt);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.MaximumSize = new System.Drawing.Size(500, 260);
            this.MinimumSize = new System.Drawing.Size(319, 220);
            this.Name = "StartLogin";
            this.Text = "Авторизация";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StartLogin_FormClosing);
            this.Load += new System.EventHandler(this.StartLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ns1.BunifuMaterialTextbox passBox;
        private ns1.BunifuMaterialTextbox loginBox;
        private ns1.BunifuFlatButton exitBnt;
        private ns1.BunifuFlatButton loginBnt;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;

    }
}

