namespace AMP_Proggramv0._00001
{
    partial class AddWaybill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddWaybill));
            this.goAddBill1 = new MetroFramework.Controls.MetroTile();
            this.backBtn = new System.Windows.Forms.Button();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // goAddBill1
            // 
            this.goAddBill1.ActiveControl = null;
            this.goAddBill1.Location = new System.Drawing.Point(23, 73);
            this.goAddBill1.Name = "goAddBill1";
            this.goAddBill1.Size = new System.Drawing.Size(219, 108);
            this.goAddBill1.TabIndex = 0;
            this.goAddBill1.Text = "Добавить расходную накладную";
            this.goAddBill1.UseSelectable = true;
            this.goAddBill1.Click += new System.EventHandler(this.goAddBill1_Click);
            // 
            // backBtn
            // 
            this.backBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backBtn.BackgroundImage")));
            this.backBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Location = new System.Drawing.Point(19, 22);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(32, 32);
            this.backBtn.TabIndex = 2;
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(260, 73);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(219, 108);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTile1.TabIndex = 3;
            this.metroTile1.Text = "Добавить Инвойс";
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // AddWaybill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 210);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.goAddBill1);
            this.Name = "AddWaybill";
            this.Text = "    Выбор накладной для добавления";
            this.Load += new System.EventHandler(this.AddWaybill_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile goAddBill1;
        private System.Windows.Forms.Button backBtn;
        private MetroFramework.Controls.MetroTile metroTile1;
    }
}