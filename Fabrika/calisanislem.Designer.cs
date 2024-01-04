namespace Fabrika
{
    partial class calisanislem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(calisanislem));
            this.txtAlan = new System.Windows.Forms.TextBox();
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hareketSirasiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xKonumuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yKonumuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.robotBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fabrikaDataSet1 = new Fabrika.FabrikaDataSet1();
            this.btnHareket = new System.Windows.Forms.Button();
            this.txtHareket = new System.Windows.Forms.TextBox();
            this.comboYon = new System.Windows.Forms.ComboBox();
            this.btnKonumlandır = new System.Windows.Forms.Button();
            this.robotTableAdapter = new Fabrika.FabrikaDataSet1TableAdapters.robotTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.robotBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fabrikaDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAlan
            // 
            this.txtAlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAlan.Location = new System.Drawing.Point(78, 70);
            this.txtAlan.Name = "txtAlan";
            this.txtAlan.Size = new System.Drawing.Size(154, 30);
            this.txtAlan.TabIndex = 0;
            this.txtAlan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // txtX
            // 
            this.txtX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtX.Location = new System.Drawing.Point(273, 70);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(154, 30);
            this.txtX.TabIndex = 1;
            this.txtX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // txtY
            // 
            this.txtY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtY.Location = new System.Drawing.Point(467, 70);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(154, 30);
            this.txtY.TabIndex = 2;
            this.txtY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.btnHareket);
            this.groupBox1.Controls.Add(this.txtHareket);
            this.groupBox1.Location = new System.Drawing.Point(19, 230);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(845, 425);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(54, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Komutlar";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(20, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(808, 314);
            this.panel1.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hareketSirasiDataGridViewTextBoxColumn,
            this.xKonumuDataGridViewTextBoxColumn,
            this.yKonumuDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.robotBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(808, 314);
            this.dataGridView1.TabIndex = 0;
            // 
            // hareketSirasiDataGridViewTextBoxColumn
            // 
            this.hareketSirasiDataGridViewTextBoxColumn.DataPropertyName = "Hareket_Sirasi";
            this.hareketSirasiDataGridViewTextBoxColumn.HeaderText = "Hareket_Sirasi";
            this.hareketSirasiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hareketSirasiDataGridViewTextBoxColumn.Name = "hareketSirasiDataGridViewTextBoxColumn";
            this.hareketSirasiDataGridViewTextBoxColumn.ReadOnly = true;
            this.hareketSirasiDataGridViewTextBoxColumn.Width = 125;
            // 
            // xKonumuDataGridViewTextBoxColumn
            // 
            this.xKonumuDataGridViewTextBoxColumn.DataPropertyName = "X_Konumu";
            this.xKonumuDataGridViewTextBoxColumn.HeaderText = "X_Konumu";
            this.xKonumuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.xKonumuDataGridViewTextBoxColumn.Name = "xKonumuDataGridViewTextBoxColumn";
            this.xKonumuDataGridViewTextBoxColumn.ReadOnly = true;
            this.xKonumuDataGridViewTextBoxColumn.Width = 125;
            // 
            // yKonumuDataGridViewTextBoxColumn
            // 
            this.yKonumuDataGridViewTextBoxColumn.DataPropertyName = "Y_Konumu";
            this.yKonumuDataGridViewTextBoxColumn.HeaderText = "Y_Konumu";
            this.yKonumuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yKonumuDataGridViewTextBoxColumn.Name = "yKonumuDataGridViewTextBoxColumn";
            this.yKonumuDataGridViewTextBoxColumn.ReadOnly = true;
            this.yKonumuDataGridViewTextBoxColumn.Width = 125;
            // 
            // robotBindingSource
            // 
            this.robotBindingSource.DataMember = "robot";
            this.robotBindingSource.DataSource = this.fabrikaDataSet1;
            // 
            // fabrikaDataSet1
            // 
            this.fabrikaDataSet1.DataSetName = "FabrikaDataSet1";
            this.fabrikaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnHareket
            // 
            this.btnHareket.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnHareket.FlatAppearance.BorderSize = 0;
            this.btnHareket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHareket.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHareket.Image = ((System.Drawing.Image)(resources.GetObject("btnHareket.Image")));
            this.btnHareket.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHareket.Location = new System.Drawing.Point(448, 28);
            this.btnHareket.Name = "btnHareket";
            this.btnHareket.Size = new System.Drawing.Size(190, 57);
            this.btnHareket.TabIndex = 6;
            this.btnHareket.Text = "Hareket Ettir";
            this.btnHareket.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHareket.UseVisualStyleBackColor = false;
            this.btnHareket.Click += new System.EventHandler(this.btnHareket_Click);
            // 
            // txtHareket
            // 
            this.txtHareket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtHareket.Location = new System.Drawing.Point(164, 42);
            this.txtHareket.Name = "txtHareket";
            this.txtHareket.Size = new System.Drawing.Size(244, 30);
            this.txtHareket.TabIndex = 4;
            this.txtHareket.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox2_KeyPress);
            // 
            // comboYon
            // 
            this.comboYon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboYon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboYon.FormattingEnabled = true;
            this.comboYon.Location = new System.Drawing.Point(659, 68);
            this.comboYon.Name = "comboYon";
            this.comboYon.Size = new System.Drawing.Size(154, 33);
            this.comboYon.TabIndex = 4;
            // 
            // btnKonumlandır
            // 
            this.btnKonumlandır.BackColor = System.Drawing.Color.Turquoise;
            this.btnKonumlandır.FlatAppearance.BorderSize = 0;
            this.btnKonumlandır.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKonumlandır.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKonumlandır.Image = ((System.Drawing.Image)(resources.GetObject("btnKonumlandır.Image")));
            this.btnKonumlandır.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKonumlandır.Location = new System.Drawing.Point(273, 129);
            this.btnKonumlandır.Name = "btnKonumlandır";
            this.btnKonumlandır.Size = new System.Drawing.Size(348, 45);
            this.btnKonumlandır.TabIndex = 5;
            this.btnKonumlandır.Text = "KONUMLANDIR";
            this.btnKonumlandır.UseVisualStyleBackColor = false;
            this.btnKonumlandır.Click += new System.EventHandler(this.btnKonumlandır_Click);
            // 
            // robotTableAdapter
            // 
            this.robotTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(97, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Alan Boyutu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(304, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "X Konumu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(497, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Y Konumu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(702, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Yönü";
            // 
            // calisanislem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(890, 676);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKonumlandır);
            this.Controls.Add(this.comboYon);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.txtAlan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "calisanislem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Çalışan Ekranı";
            this.Load += new System.EventHandler(this.calisanislem_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.robotBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fabrikaDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAlan;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnHareket;
        private System.Windows.Forms.TextBox txtHareket;
        private System.Windows.Forms.ComboBox comboYon;
        private System.Windows.Forms.Button btnKonumlandır;
        private FabrikaDataSet1 fabrikaDataSet1;
        private System.Windows.Forms.BindingSource robotBindingSource;
        private FabrikaDataSet1TableAdapters.robotTableAdapter robotTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn hareketSirasiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xKonumuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yKonumuDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}