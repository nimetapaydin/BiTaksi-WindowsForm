namespace BiTaksi
{
    partial class SoförleriGörüntüle
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
            this.biTaksiDataSet = new BiTaksi.BiTaksiDataSet();
            this.soforBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.soforTableAdapter = new BiTaksi.BiTaksiDataSetTableAdapters.soforTableAdapter();
            this.tableAdapterManager = new BiTaksi.BiTaksiDataSetTableAdapters.TableAdapterManager();
            this.soforDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.biTaksiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soforBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soforDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // biTaksiDataSet
            // 
            this.biTaksiDataSet.DataSetName = "BiTaksiDataSet";
            this.biTaksiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // soforBindingSource
            // 
            this.soforBindingSource.DataMember = "sofor";
            this.soforBindingSource.DataSource = this.biTaksiDataSet;
            // 
            // soforTableAdapter
            // 
            this.soforTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.adminTableAdapter = null;
            this.tableAdapterManager.aracTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.cagriTableAdapter = null;
            this.tableAdapterManager.raporTableAdapter = null;
            this.tableAdapterManager.soforTableAdapter = this.soforTableAdapter;
            this.tableAdapterManager.UpdateOrder = BiTaksi.BiTaksiDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // soforDataGridView
            // 
            this.soforDataGridView.AutoGenerateColumns = false;
            this.soforDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.soforDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.soforDataGridView.DataSource = this.soforBindingSource;
            this.soforDataGridView.Location = new System.Drawing.Point(89, 141);
            this.soforDataGridView.Name = "soforDataGridView";
            this.soforDataGridView.RowTemplate.Height = 24;
            this.soforDataGridView.Size = new System.Drawing.Size(634, 81);
            this.soforDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "tc";
            this.dataGridViewTextBoxColumn2.HeaderText = "tc";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "adisoyadi";
            this.dataGridViewTextBoxColumn3.HeaderText = "adisoyadi";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "sifre";
            this.dataGridViewTextBoxColumn4.HeaderText = "sifre";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "aktif";
            this.dataGridViewTextBoxColumn5.HeaderText = "aktif";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "onayli";
            this.dataGridViewTextBoxColumn6.HeaderText = "onayli";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // SoförleriGörüntüle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BiTaksi.Properties.Resources.traffic;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.soforDataGridView);
            this.Name = "SoförleriGörüntüle";
            this.Text = "SoförleriGörüntüle";
            this.Load += new System.EventHandler(this.SoförleriGörüntüle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.biTaksiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soforBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soforDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BiTaksiDataSet biTaksiDataSet;
        private System.Windows.Forms.BindingSource soforBindingSource;
        private BiTaksiDataSetTableAdapters.soforTableAdapter soforTableAdapter;
        private BiTaksiDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView soforDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}