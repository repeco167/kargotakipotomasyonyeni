namespace KargoTakipOtomasonu2
{
    partial class kargogörüntüle
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullaniciadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gonderilentarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teslimtipiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ödemetipiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ürünaciklamasiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gönderilenilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alınacakilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alıcıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kargotipiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ağırlıkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kargoekleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kargotakipDataSet = new KargoTakipOtomasonu2.kargotakipDataSet();
            this.kargoekleTableAdapter = new KargoTakipOtomasonu2.kargotakipDataSetTableAdapters.kargoekleTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kargoekleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kargotakipDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDDataGridViewTextBoxColumn,
            this.kullaniciadiDataGridViewTextBoxColumn,
            this.gonderilentarihDataGridViewTextBoxColumn,
            this.teslimtipiDataGridViewTextBoxColumn,
            this.ödemetipiDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn,
            this.ürünaciklamasiDataGridViewTextBoxColumn,
            this.gönderilenilDataGridViewTextBoxColumn,
            this.alınacakilDataGridViewTextBoxColumn,
            this.alıcıDataGridViewTextBoxColumn,
            this.kargotipiDataGridViewTextBoxColumn,
            this.ağırlıkDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kargoekleBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(34, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(930, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // ıDDataGridViewTextBoxColumn
            // 
            this.ıDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.ıDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.ıDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıDDataGridViewTextBoxColumn.Name = "ıDDataGridViewTextBoxColumn";
            this.ıDDataGridViewTextBoxColumn.Width = 125;
            // 
            // kullaniciadiDataGridViewTextBoxColumn
            // 
            this.kullaniciadiDataGridViewTextBoxColumn.DataPropertyName = "kullanici_adi";
            this.kullaniciadiDataGridViewTextBoxColumn.HeaderText = "kullanici_adi";
            this.kullaniciadiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kullaniciadiDataGridViewTextBoxColumn.Name = "kullaniciadiDataGridViewTextBoxColumn";
            this.kullaniciadiDataGridViewTextBoxColumn.Width = 125;
            // 
            // gonderilentarihDataGridViewTextBoxColumn
            // 
            this.gonderilentarihDataGridViewTextBoxColumn.DataPropertyName = "gonderilentarih";
            this.gonderilentarihDataGridViewTextBoxColumn.HeaderText = "gonderilentarih";
            this.gonderilentarihDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gonderilentarihDataGridViewTextBoxColumn.Name = "gonderilentarihDataGridViewTextBoxColumn";
            this.gonderilentarihDataGridViewTextBoxColumn.Width = 125;
            // 
            // teslimtipiDataGridViewTextBoxColumn
            // 
            this.teslimtipiDataGridViewTextBoxColumn.DataPropertyName = "teslimtipi";
            this.teslimtipiDataGridViewTextBoxColumn.HeaderText = "teslimtipi";
            this.teslimtipiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.teslimtipiDataGridViewTextBoxColumn.Name = "teslimtipiDataGridViewTextBoxColumn";
            this.teslimtipiDataGridViewTextBoxColumn.Width = 125;
            // 
            // ödemetipiDataGridViewTextBoxColumn
            // 
            this.ödemetipiDataGridViewTextBoxColumn.DataPropertyName = "ödemetipi";
            this.ödemetipiDataGridViewTextBoxColumn.HeaderText = "ödemetipi";
            this.ödemetipiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ödemetipiDataGridViewTextBoxColumn.Name = "ödemetipiDataGridViewTextBoxColumn";
            this.ödemetipiDataGridViewTextBoxColumn.Width = 125;
            // 
            // adresDataGridViewTextBoxColumn
            // 
            this.adresDataGridViewTextBoxColumn.DataPropertyName = "adres";
            this.adresDataGridViewTextBoxColumn.HeaderText = "adres";
            this.adresDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            this.adresDataGridViewTextBoxColumn.Width = 125;
            // 
            // ürünaciklamasiDataGridViewTextBoxColumn
            // 
            this.ürünaciklamasiDataGridViewTextBoxColumn.DataPropertyName = "ürünaciklamasi";
            this.ürünaciklamasiDataGridViewTextBoxColumn.HeaderText = "ürünaciklamasi";
            this.ürünaciklamasiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ürünaciklamasiDataGridViewTextBoxColumn.Name = "ürünaciklamasiDataGridViewTextBoxColumn";
            this.ürünaciklamasiDataGridViewTextBoxColumn.Width = 125;
            // 
            // gönderilenilDataGridViewTextBoxColumn
            // 
            this.gönderilenilDataGridViewTextBoxColumn.DataPropertyName = "gönderilenil";
            this.gönderilenilDataGridViewTextBoxColumn.HeaderText = "gönderilenil";
            this.gönderilenilDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gönderilenilDataGridViewTextBoxColumn.Name = "gönderilenilDataGridViewTextBoxColumn";
            this.gönderilenilDataGridViewTextBoxColumn.Width = 125;
            // 
            // alınacakilDataGridViewTextBoxColumn
            // 
            this.alınacakilDataGridViewTextBoxColumn.DataPropertyName = "alınacakil";
            this.alınacakilDataGridViewTextBoxColumn.HeaderText = "alınacakil";
            this.alınacakilDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.alınacakilDataGridViewTextBoxColumn.Name = "alınacakilDataGridViewTextBoxColumn";
            this.alınacakilDataGridViewTextBoxColumn.Width = 125;
            // 
            // alıcıDataGridViewTextBoxColumn
            // 
            this.alıcıDataGridViewTextBoxColumn.DataPropertyName = "alıcı";
            this.alıcıDataGridViewTextBoxColumn.HeaderText = "alıcı";
            this.alıcıDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.alıcıDataGridViewTextBoxColumn.Name = "alıcıDataGridViewTextBoxColumn";
            this.alıcıDataGridViewTextBoxColumn.Width = 125;
            // 
            // kargotipiDataGridViewTextBoxColumn
            // 
            this.kargotipiDataGridViewTextBoxColumn.DataPropertyName = "kargotipi";
            this.kargotipiDataGridViewTextBoxColumn.HeaderText = "kargotipi";
            this.kargotipiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kargotipiDataGridViewTextBoxColumn.Name = "kargotipiDataGridViewTextBoxColumn";
            this.kargotipiDataGridViewTextBoxColumn.Width = 125;
            // 
            // ağırlıkDataGridViewTextBoxColumn
            // 
            this.ağırlıkDataGridViewTextBoxColumn.DataPropertyName = "ağırlık";
            this.ağırlıkDataGridViewTextBoxColumn.HeaderText = "ağırlık";
            this.ağırlıkDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ağırlıkDataGridViewTextBoxColumn.Name = "ağırlıkDataGridViewTextBoxColumn";
            this.ağırlıkDataGridViewTextBoxColumn.Width = 125;
            // 
            // kargoekleBindingSource
            // 
            this.kargoekleBindingSource.DataMember = "kargoekle";
            this.kargoekleBindingSource.DataSource = this.kargotakipDataSet;
            // 
            // kargotakipDataSet
            // 
            this.kargotakipDataSet.DataSetName = "kargotakipDataSet";
            this.kargotakipDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kargoekleTableAdapter
            // 
            this.kargoekleTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(695, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "Güncelle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(863, 189);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 45);
            this.button2.TabIndex = 2;
            this.button2.Text = "Sil";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(186, 211);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(326, 210);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Ara";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(898, 273);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(107, 40);
            this.button7.TabIndex = 31;
            this.button7.Text = "Geri Dön";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // kargogörüntüle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 325);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "kargogörüntüle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "kargogörüntüle";
            this.Load += new System.EventHandler(this.kargogörüntüle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kargoekleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kargotakipDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private kargotakipDataSet kargotakipDataSet;
        private System.Windows.Forms.BindingSource kargoekleBindingSource;
        private kargotakipDataSetTableAdapters.kargoekleTableAdapter kargoekleTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gonderilentarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teslimtipiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ödemetipiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ürünaciklamasiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gönderilenilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alınacakilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alıcıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kargotipiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ağırlıkDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button7;
    }
}