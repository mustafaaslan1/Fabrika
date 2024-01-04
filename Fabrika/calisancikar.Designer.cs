namespace Fabrika
{
    partial class calisancikar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(calisancikar));
            this.txtTC = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.calisanTCNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sicilNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinsiyetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calisanekleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fabrikaDataSet = new Fabrika.FabrikaDataSet();
            this.btnCikar = new System.Windows.Forms.Button();
            this.calisanekleTableAdapter = new Fabrika.FabrikaDataSetTableAdapters.calisanekleTableAdapter();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calisanekleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fabrikaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTC
            // 
            this.txtTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTC.Location = new System.Drawing.Point(160, 42);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(321, 34);
            this.txtTC.TabIndex = 0;
            this.txtTC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTC_KeyPress);
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAra.FlatAppearance.BorderSize = 0;
            this.btnAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAra.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.Image = ((System.Drawing.Image)(resources.GetObject("btnAra.Image")));
            this.btnAra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAra.Location = new System.Drawing.Point(507, 31);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(147, 59);
            this.btnAra.TabIndex = 1;
            this.btnAra.Text = "ARA";
            this.btnAra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(46, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 477);
            this.panel1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.calisanTCNODataGridViewTextBoxColumn,
            this.sicilNODataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.cinsiyetDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.calisanekleBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(650, 477);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // calisanTCNODataGridViewTextBoxColumn
            // 
            this.calisanTCNODataGridViewTextBoxColumn.DataPropertyName = "CalisanTC_NO";
            this.calisanTCNODataGridViewTextBoxColumn.HeaderText = "CalisanTC_NO";
            this.calisanTCNODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.calisanTCNODataGridViewTextBoxColumn.Name = "calisanTCNODataGridViewTextBoxColumn";
            this.calisanTCNODataGridViewTextBoxColumn.ReadOnly = true;
            this.calisanTCNODataGridViewTextBoxColumn.Width = 125;
            // 
            // sicilNODataGridViewTextBoxColumn
            // 
            this.sicilNODataGridViewTextBoxColumn.DataPropertyName = "Sicil_NO";
            this.sicilNODataGridViewTextBoxColumn.HeaderText = "Sicil_NO";
            this.sicilNODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sicilNODataGridViewTextBoxColumn.Name = "sicilNODataGridViewTextBoxColumn";
            this.sicilNODataGridViewTextBoxColumn.ReadOnly = true;
            this.sicilNODataGridViewTextBoxColumn.Width = 125;
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "Ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "Ad";
            this.adDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            this.adDataGridViewTextBoxColumn.ReadOnly = true;
            this.adDataGridViewTextBoxColumn.Width = 125;
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            this.soyadDataGridViewTextBoxColumn.DataPropertyName = "Soyad";
            this.soyadDataGridViewTextBoxColumn.HeaderText = "Soyad";
            this.soyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            this.soyadDataGridViewTextBoxColumn.ReadOnly = true;
            this.soyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // cinsiyetDataGridViewTextBoxColumn
            // 
            this.cinsiyetDataGridViewTextBoxColumn.DataPropertyName = "Cinsiyet";
            this.cinsiyetDataGridViewTextBoxColumn.HeaderText = "Cinsiyet";
            this.cinsiyetDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cinsiyetDataGridViewTextBoxColumn.Name = "cinsiyetDataGridViewTextBoxColumn";
            this.cinsiyetDataGridViewTextBoxColumn.ReadOnly = true;
            this.cinsiyetDataGridViewTextBoxColumn.Width = 125;
            // 
            // calisanekleBindingSource
            // 
            this.calisanekleBindingSource.DataMember = "calisanekle";
            this.calisanekleBindingSource.DataSource = this.fabrikaDataSet;
            // 
            // fabrikaDataSet
            // 
            this.fabrikaDataSet.DataSetName = "FabrikaDataSet";
            this.fabrikaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnCikar
            // 
            this.btnCikar.BackColor = System.Drawing.Color.IndianRed;
            this.btnCikar.FlatAppearance.BorderSize = 0;
            this.btnCikar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikar.Image = ((System.Drawing.Image)(resources.GetObject("btnCikar.Image")));
            this.btnCikar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCikar.Location = new System.Drawing.Point(308, 589);
            this.btnCikar.Name = "btnCikar";
            this.btnCikar.Size = new System.Drawing.Size(184, 59);
            this.btnCikar.TabIndex = 3;
            this.btnCikar.Text = "Çalışan Çıkar";
            this.btnCikar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCikar.UseVisualStyleBackColor = false;
            this.btnCikar.Click += new System.EventHandler(this.btnCikar_Click);
            // 
            // calisanekleTableAdapter
            // 
            this.calisanekleTableAdapter.ClearBeforeFill = true;
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.FlatAppearance.BorderSize = 0;
            this.btnGeriDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeriDon.Image = ((System.Drawing.Image)(resources.GetObject("btnGeriDon.Image")));
            this.btnGeriDon.Location = new System.Drawing.Point(12, 594);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(68, 57);
            this.btnGeriDon.TabIndex = 8;
            this.btnGeriDon.UseVisualStyleBackColor = true;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnListele.FlatAppearance.BorderSize = 0;
            this.btnListele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListele.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListele.Image = ((System.Drawing.Image)(resources.GetObject("btnListele.Image")));
            this.btnListele.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListele.Location = new System.Drawing.Point(512, 589);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(184, 59);
            this.btnListele.TabIndex = 4;
            this.btnListele.Text = "LİSTELE";
            this.btnListele.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // calisancikar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(745, 660);
            this.Controls.Add(this.btnGeriDon);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.btnCikar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtTC);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "calisancikar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Çalışan Çıkar";
            this.Load += new System.EventHandler(this.calisancikar_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calisanekleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fabrikaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCikar;
        private FabrikaDataSet fabrikaDataSet;
        private System.Windows.Forms.BindingSource calisanekleBindingSource;
        private FabrikaDataSetTableAdapters.calisanekleTableAdapter calisanekleTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn calisanTCNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sicilNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cinsiyetDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnGeriDon;
        private System.Windows.Forms.Button btnListele;
    }
}