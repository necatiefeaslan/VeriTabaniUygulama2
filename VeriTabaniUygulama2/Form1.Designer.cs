namespace VeriTabaniUygulama2
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kutuphane148DataSet = new VeriTabaniUygulama2.kutuphane148DataSet();
            this.kitaplarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kitaplarTableAdapter = new VeriTabaniUygulama2.kutuphane148DataSetTableAdapters.KitaplarTableAdapter();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapTuruDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapYazariDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphane148DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitaplarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.kitapAdiDataGridViewTextBoxColumn,
            this.kitapTuruDataGridViewTextBoxColumn,
            this.kitapYazariDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kitaplarBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(143, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(357, 126);
            this.dataGridView1.TabIndex = 0;
            // 
            // kutuphane148DataSet
            // 
            this.kutuphane148DataSet.DataSetName = "kutuphane148DataSet";
            this.kutuphane148DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kitaplarBindingSource
            // 
            this.kitaplarBindingSource.DataMember = "Kitaplar";
            this.kitaplarBindingSource.DataSource = this.kutuphane148DataSet;
            // 
            // kitaplarTableAdapter
            // 
            this.kitaplarTableAdapter.ClearBeforeFill = true;
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            this.ıdDataGridViewTextBoxColumn.ReadOnly = true;
            this.ıdDataGridViewTextBoxColumn.Visible = false;
            // 
            // kitapAdiDataGridViewTextBoxColumn
            // 
            this.kitapAdiDataGridViewTextBoxColumn.DataPropertyName = "KitapAdi";
            this.kitapAdiDataGridViewTextBoxColumn.HeaderText = "KitapAdi";
            this.kitapAdiDataGridViewTextBoxColumn.Name = "kitapAdiDataGridViewTextBoxColumn";
            // 
            // kitapTuruDataGridViewTextBoxColumn
            // 
            this.kitapTuruDataGridViewTextBoxColumn.DataPropertyName = "KitapTuru";
            this.kitapTuruDataGridViewTextBoxColumn.HeaderText = "KitapTuru";
            this.kitapTuruDataGridViewTextBoxColumn.Name = "kitapTuruDataGridViewTextBoxColumn";
            // 
            // kitapYazariDataGridViewTextBoxColumn
            // 
            this.kitapYazariDataGridViewTextBoxColumn.DataPropertyName = "KitapYazari";
            this.kitapYazariDataGridViewTextBoxColumn.HeaderText = "KitapYazari";
            this.kitapYazariDataGridViewTextBoxColumn.Name = "kitapYazariDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphane148DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitaplarBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private kutuphane148DataSet kutuphane148DataSet;
        private System.Windows.Forms.BindingSource kitaplarBindingSource;
        private kutuphane148DataSetTableAdapters.KitaplarTableAdapter kitaplarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapTuruDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapYazariDataGridViewTextBoxColumn;
    }
}

