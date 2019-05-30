namespace BiTaksi
{
    partial class RaporlarıGörüntüle
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
            this.label1 = new System.Windows.Forms.Label();
            this.biTaksiDataSet = new BiTaksi.BiTaksiDataSet();
            this.raporBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.raporTableAdapter = new BiTaksi.BiTaksiDataSetTableAdapters.raporTableAdapter();
            this.tableAdapterManager = new BiTaksi.BiTaksiDataSetTableAdapters.TableAdapterManager();
            this.raporDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.biTaksiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raporBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raporDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(46, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Raporlar";
            // 
            // biTaksiDataSet
            // 
            this.biTaksiDataSet.DataSetName = "BiTaksiDataSet";
            this.biTaksiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // raporBindingSource
            // 
            this.raporBindingSource.DataMember = "rapor";
            this.raporBindingSource.DataSource = this.biTaksiDataSet;
            // 
            // raporTableAdapter
            // 
            this.raporTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.adminTableAdapter = null;
            this.tableAdapterManager.aracTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.cagriTableAdapter = null;
            this.tableAdapterManager.raporTableAdapter = this.raporTableAdapter;
            this.tableAdapterManager.soforTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BiTaksi.BiTaksiDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // raporDataGridView
            // 
            this.raporDataGridView.AutoGenerateColumns = false;
            this.raporDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.raporDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.raporDataGridView.DataSource = this.raporBindingSource;
            this.raporDataGridView.Location = new System.Drawing.Point(44, 120);
            this.raporDataGridView.Name = "raporDataGridView";
            this.raporDataGridView.RowTemplate.Height = 24;
            this.raporDataGridView.Size = new System.Drawing.Size(751, 299);
            this.raporDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "sofor_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "sofor_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "arac_plaka";
            this.dataGridViewTextBoxColumn2.HeaderText = "arac_plaka";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "tarih";
            this.dataGridViewTextBoxColumn3.HeaderText = "tarih";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "kazanc";
            this.dataGridViewTextBoxColumn4.HeaderText = "kazanc";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // RaporlarıGörüntüle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BiTaksi.Properties.Resources.traffic;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(815, 450);
            this.Controls.Add(this.raporDataGridView);
            this.Controls.Add(this.label1);
            this.Name = "RaporlarıGörüntüle";
            this.Text = "RaporlarıGörüntüle";
            this.Load += new System.EventHandler(this.RaporlarıGörüntüle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.biTaksiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raporBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raporDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private BiTaksiDataSet biTaksiDataSet;
        private System.Windows.Forms.BindingSource raporBindingSource;
        private BiTaksiDataSetTableAdapters.raporTableAdapter raporTableAdapter;
        private BiTaksiDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView raporDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}