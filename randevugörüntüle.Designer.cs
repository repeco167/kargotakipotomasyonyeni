namespace KargoTakipOtomasonu2
{
    partial class randevugörüntüle
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
            this.buttonAppCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.kargotakipDataSet1 = new KargoTakipOtomasonu2.kargotakipDataSet1();
            this.tblrandevuoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_randevuoTableAdapter = new KargoTakipOtomasonu2.kargotakipDataSet1TableAdapters.tbl_randevuoTableAdapter();
            this.kargotakipDataSet2 = new KargoTakipOtomasonu2.kargotakipDataSet2();
            this.tblrandevuekleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_randevuekleTableAdapter = new KargoTakipOtomasonu2.kargotakipDataSet2TableAdapters.tbl_randevuekleTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kargotakipDataSet3 = new KargoTakipOtomasonu2.kargotakipDataSet3();
            this.tblrandevueklemeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_randevueklemeTableAdapter = new KargoTakipOtomasonu2.kargotakipDataSet3TableAdapters.tbl_randevueklemeTableAdapter();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randevusaatiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.kargotakipDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblrandevuoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kargotakipDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblrandevuekleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kargotakipDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblrandevueklemeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAppCancel
            // 
            this.buttonAppCancel.BackColor = System.Drawing.Color.Khaki;
            this.buttonAppCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonAppCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAppCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonAppCancel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonAppCancel.Location = new System.Drawing.Point(729, 159);
            this.buttonAppCancel.Name = "buttonAppCancel";
            this.buttonAppCancel.Size = new System.Drawing.Size(101, 33);
            this.buttonAppCancel.TabIndex = 12;
            this.buttonAppCancel.Text = "İptal Et";
            this.buttonAppCancel.UseVisualStyleBackColor = false;
            this.buttonAppCancel.Click += new System.EventHandler(this.buttonAppCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(363, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Randevular";
            // 
            // kargotakipDataSet1
            // 
            this.kargotakipDataSet1.DataSetName = "kargotakipDataSet1";
            this.kargotakipDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblrandevuoBindingSource
            // 
            this.tblrandevuoBindingSource.DataMember = "tbl_randevuo";
            this.tblrandevuoBindingSource.DataSource = this.kargotakipDataSet1;
            // 
            // tbl_randevuoTableAdapter
            // 
            this.tbl_randevuoTableAdapter.ClearBeforeFill = true;
            // 
            // kargotakipDataSet2
            // 
            this.kargotakipDataSet2.DataSetName = "kargotakipDataSet2";
            this.kargotakipDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblrandevuekleBindingSource
            // 
            this.tblrandevuekleBindingSource.DataMember = "tbl_randevuekle";
            this.tblrandevuekleBindingSource.DataSource = this.kargotakipDataSet2;
            // 
            // tbl_randevuekleTableAdapter
            // 
            this.tbl_randevuekleTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDDataGridViewTextBoxColumn,
            this.dtarihDataGridViewTextBoxColumn,
            this.randevusaatiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblrandevueklemeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(172, 159);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(515, 179);
            this.dataGridView1.TabIndex = 15;
            // 
            // kargotakipDataSet3
            // 
            this.kargotakipDataSet3.DataSetName = "kargotakipDataSet3";
            this.kargotakipDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblrandevueklemeBindingSource
            // 
            this.tblrandevueklemeBindingSource.DataMember = "tbl_randevuekleme";
            this.tblrandevueklemeBindingSource.DataSource = this.kargotakipDataSet3;
            // 
            // tbl_randevueklemeTableAdapter
            // 
            this.tbl_randevueklemeTableAdapter.ClearBeforeFill = true;
            // 
            // ıDDataGridViewTextBoxColumn
            // 
            this.ıDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.ıDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.ıDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıDDataGridViewTextBoxColumn.Name = "ıDDataGridViewTextBoxColumn";
            this.ıDDataGridViewTextBoxColumn.Width = 125;
            // 
            // dtarihDataGridViewTextBoxColumn
            // 
            this.dtarihDataGridViewTextBoxColumn.DataPropertyName = "dtarih";
            this.dtarihDataGridViewTextBoxColumn.HeaderText = "dtarih";
            this.dtarihDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dtarihDataGridViewTextBoxColumn.Name = "dtarihDataGridViewTextBoxColumn";
            this.dtarihDataGridViewTextBoxColumn.Width = 125;
            // 
            // randevusaatiDataGridViewTextBoxColumn
            // 
            this.randevusaatiDataGridViewTextBoxColumn.DataPropertyName = "randevusaati";
            this.randevusaatiDataGridViewTextBoxColumn.HeaderText = "randevusaati";
            this.randevusaatiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.randevusaatiDataGridViewTextBoxColumn.Name = "randevusaatiDataGridViewTextBoxColumn";
            this.randevusaatiDataGridViewTextBoxColumn.Width = 125;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(739, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Geri Dön";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // randevugörüntüle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(883, 412);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonAppCancel);
            this.Controls.Add(this.label1);
            this.Name = "randevugörüntüle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "randevugörüntüle";
            this.Load += new System.EventHandler(this.randevugörüntüle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kargotakipDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblrandevuoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kargotakipDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblrandevuekleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kargotakipDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblrandevueklemeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAppCancel;
        private System.Windows.Forms.Label label1;
        private kargotakipDataSet1 kargotakipDataSet1;
        private System.Windows.Forms.BindingSource tblrandevuoBindingSource;
        private kargotakipDataSet1TableAdapters.tbl_randevuoTableAdapter tbl_randevuoTableAdapter;
        private kargotakipDataSet2 kargotakipDataSet2;
        private System.Windows.Forms.BindingSource tblrandevuekleBindingSource;
        private kargotakipDataSet2TableAdapters.tbl_randevuekleTableAdapter tbl_randevuekleTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private kargotakipDataSet3 kargotakipDataSet3;
        private System.Windows.Forms.BindingSource tblrandevueklemeBindingSource;
        private kargotakipDataSet3TableAdapters.tbl_randevueklemeTableAdapter tbl_randevueklemeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn randevusaatiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}