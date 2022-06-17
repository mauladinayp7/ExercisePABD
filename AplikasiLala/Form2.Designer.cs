namespace AplikasiLala
{
    partial class Form2
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tugasLalaDataSet = new AplikasiLala.TugasLalaDataSet();
            this.tugasLalaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tugasLalaDataSet2 = new AplikasiLala.TugasLalaDataSet2();
            this.tugasLalaDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.catatanHarianBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.catatanHarianTableAdapter = new AplikasiLala.TugasLalaDataSet2TableAdapters.CatatanHarianTableAdapter();
            this.tanggalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catatanKuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tugasLalaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tugasLalaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tugasLalaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tugasLalaDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catatanHarianBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tugasLalaDataSet
            // 
            this.tugasLalaDataSet.DataSetName = "TugasLalaDataSet";
            this.tugasLalaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tugasLalaDataSetBindingSource
            // 
            this.tugasLalaDataSetBindingSource.DataSource = this.tugasLalaDataSet;
            this.tugasLalaDataSetBindingSource.Position = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "CATATAN HARIAN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Location = new System.Drawing.Point(27, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 43);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.Location = new System.Drawing.Point(295, 359);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 42);
            this.button2.TabIndex = 5;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button3.Location = new System.Drawing.Point(523, 359);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 42);
            this.button3.TabIndex = 6;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tanggalDataGridViewTextBoxColumn,
            this.catatanKuDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.catatanHarianBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(27, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(571, 232);
            this.dataGridView1.TabIndex = 7;
            // 
            // tugasLalaDataSet2
            // 
            this.tugasLalaDataSet2.DataSetName = "TugasLalaDataSet2";
            this.tugasLalaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tugasLalaDataSet2BindingSource
            // 
            this.tugasLalaDataSet2BindingSource.DataSource = this.tugasLalaDataSet2;
            this.tugasLalaDataSet2BindingSource.Position = 0;
            // 
            // catatanHarianBindingSource
            // 
            this.catatanHarianBindingSource.DataMember = "CatatanHarian";
            this.catatanHarianBindingSource.DataSource = this.tugasLalaDataSet2BindingSource;
            // 
            // catatanHarianTableAdapter
            // 
            this.catatanHarianTableAdapter.ClearBeforeFill = true;
            // 
            // tanggalDataGridViewTextBoxColumn
            // 
            this.tanggalDataGridViewTextBoxColumn.DataPropertyName = "Tanggal";
            this.tanggalDataGridViewTextBoxColumn.HeaderText = "Tanggal";
            this.tanggalDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tanggalDataGridViewTextBoxColumn.Name = "tanggalDataGridViewTextBoxColumn";
            this.tanggalDataGridViewTextBoxColumn.Width = 150;
            // 
            // catatanKuDataGridViewTextBoxColumn
            // 
            this.catatanKuDataGridViewTextBoxColumn.DataPropertyName = "CatatanKu";
            this.catatanKuDataGridViewTextBoxColumn.HeaderText = "CatatanKu";
            this.catatanKuDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.catatanKuDataGridViewTextBoxColumn.Name = "catatanKuDataGridViewTextBoxColumn";
            this.catatanKuDataGridViewTextBoxColumn.Width = 150;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.Location = new System.Drawing.Point(550, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 33);
            this.button4.TabIndex = 8;
            this.button4.Text = "next";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button5.Location = new System.Drawing.Point(12, 17);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 28);
            this.button5.TabIndex = 9;
            this.button5.Text = "exit";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tugasLalaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tugasLalaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tugasLalaDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tugasLalaDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catatanHarianBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.BindingSource tugasLalaDataSetBindingSource;
        private TugasLalaDataSet tugasLalaDataSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource tugasLalaDataSet2BindingSource;
        private TugasLalaDataSet2 tugasLalaDataSet2;
        private System.Windows.Forms.BindingSource catatanHarianBindingSource;
        private TugasLalaDataSet2TableAdapters.CatatanHarianTableAdapter catatanHarianTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn catatanKuDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}