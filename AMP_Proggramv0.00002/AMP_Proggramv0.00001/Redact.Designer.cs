namespace AMP_Proggramv0._00001
{
    partial class Redact
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Redact));
            this.productsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aMPDBDataSet = new AMP_Proggramv0._00001.AMPDBDataSet();
            this.metroContextMenu4 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.менбToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsTableAdapter1 = new AMP_Proggramv0._00001.AMPDBDSforRedactTableAdapters.ProductsTableAdapter();
            this.productsTableAdapter = new AMP_Proggramv0._00001.AMPDBDataSetTableAdapters.ProductsTableAdapter();
            this.productsTableAdapter2 = new AMP_Proggramv0._00001.AMPDBDataSetForRedactMMTableAdapters.ProductsTableAdapter();
            this.backBtn = new System.Windows.Forms.Button();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.goRedactTile = new MetroFramework.Controls.MetroTile();
            this.goAddTile = new MetroFramework.Controls.MetroTile();
            this.goDelTile = new MetroFramework.Controls.MetroTile();
            this.goAuditTile = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aMPDBDataSet)).BeginInit();
            this.metroContextMenu4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // productsBindingSource1
            // 
            this.productsBindingSource1.DataMember = "Products";
            this.productsBindingSource1.DataSource = this.productsBindingSource;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataSource = this.aMPDBDataSet;
            this.productsBindingSource.Position = 0;
            // 
            // aMPDBDataSet
            // 
            this.aMPDBDataSet.DataSetName = "AMPDBDataSet";
            this.aMPDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // metroContextMenu4
            // 
            this.metroContextMenu4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менбToolStripMenuItem});
            this.metroContextMenu4.Name = "metroContextMenu4";
            this.metroContextMenu4.Size = new System.Drawing.Size(106, 26);
            // 
            // менбToolStripMenuItem
            // 
            this.менбToolStripMenuItem.Name = "менбToolStripMenuItem";
            this.менбToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.менбToolStripMenuItem.Text = "Менб";
            // 
            // productsTableAdapter1
            // 
            this.productsTableAdapter1.ClearBeforeFill = true;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // productsTableAdapter2
            // 
            this.productsTableAdapter2.ClearBeforeFill = true;
            // 
            // backBtn
            // 
            this.backBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.backBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backBtn.BackgroundImage")));
            this.backBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Location = new System.Drawing.Point(16, 22);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(32, 32);
            this.backBtn.TabIndex = 11;
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(70, 21);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(713, 25);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // goRedactTile
            // 
            this.goRedactTile.ActiveControl = null;
            this.goRedactTile.Location = new System.Drawing.Point(23, 99);
            this.goRedactTile.Name = "goRedactTile";
            this.goRedactTile.Size = new System.Drawing.Size(222, 108);
            this.goRedactTile.Style = MetroFramework.MetroColorStyle.Silver;
            this.goRedactTile.TabIndex = 8;
            this.goRedactTile.Text = "Редактировать";
            this.goRedactTile.UseSelectable = true;
            this.goRedactTile.Click += new System.EventHandler(this.goRedactTile_Click);
            // 
            // goAddTile
            // 
            this.goAddTile.ActiveControl = null;
            this.goAddTile.Location = new System.Drawing.Point(266, 99);
            this.goAddTile.Name = "goAddTile";
            this.goAddTile.Size = new System.Drawing.Size(219, 108);
            this.goAddTile.Style = MetroFramework.MetroColorStyle.Teal;
            this.goAddTile.TabIndex = 9;
            this.goAddTile.Text = "Добавить Накладную";
            this.goAddTile.UseSelectable = true;
            this.goAddTile.Click += new System.EventHandler(this.goAddTile_Click);
            // 
            // goDelTile
            // 
            this.goDelTile.ActiveControl = null;
            this.goDelTile.Location = new System.Drawing.Point(507, 99);
            this.goDelTile.Name = "goDelTile";
            this.goDelTile.Size = new System.Drawing.Size(220, 108);
            this.goDelTile.Style = MetroFramework.MetroColorStyle.Orange;
            this.goDelTile.TabIndex = 10;
            this.goDelTile.Text = "Удалить";
            this.goDelTile.UseSelectable = true;
            this.goDelTile.Click += new System.EventHandler(this.goDelTile_Click);
            // 
            // goAuditTile
            // 
            this.goAuditTile.ActiveControl = null;
            this.goAuditTile.Location = new System.Drawing.Point(23, 213);
            this.goAuditTile.Name = "goAuditTile";
            this.goAuditTile.Size = new System.Drawing.Size(462, 107);
            this.goAuditTile.Style = MetroFramework.MetroColorStyle.Yellow;
            this.goAuditTile.TabIndex = 12;
            this.goAuditTile.Text = "Аудит";
            this.goAuditTile.UseSelectable = true;
            this.goAuditTile.Click += new System.EventHandler(this.goAuditTile_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(507, 213);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(220, 108);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroTile1.TabIndex = 13;
            this.metroTile1.Text = "Информация о складах";
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // Redact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(753, 354);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.goAuditTile);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.goDelTile);
            this.Controls.Add(this.goAddTile);
            this.Controls.Add(this.goRedactTile);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Redact";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "    Документооборот";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Redact_FormClosed);
            this.Load += new System.EventHandler(this.Redact_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aMPDBDataSet)).EndInit();
            this.metroContextMenu4.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.BindingSource productsBindingSource;
       
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
       
       
        private MetroFramework.Controls.MetroContextMenu metroContextMenu4;
        private System.Windows.Forms.ToolStripMenuItem менбToolStripMenuItem;
        private System.Windows.Forms.Button backBtn;
        private AMPDBDSforRedactTableAdapters.ProductsTableAdapter productsTableAdapter1;
        private AMPDBDataSet aMPDBDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource1;
        private AMPDBDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private AMPDBDataSetForRedactMMTableAdapters.ProductsTableAdapter productsTableAdapter2;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private MetroFramework.Controls.MetroTile goRedactTile;
        private MetroFramework.Controls.MetroTile goAddTile;
        private MetroFramework.Controls.MetroTile goDelTile;
        private MetroFramework.Controls.MetroTile goAuditTile;
        private MetroFramework.Controls.MetroTile metroTile1;
    }
}