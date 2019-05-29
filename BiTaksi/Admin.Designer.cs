namespace BiTaksi
{
    partial class Admin
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.aracEkle = new System.Windows.Forms.Label();
            this.soförleriGörüntüle = new System.Windows.Forms.Label();
            this.raporlariGörüntüle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(399, 322);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // aracEkle
            // 
            this.aracEkle.AutoSize = true;
            this.aracEkle.BackColor = System.Drawing.Color.Transparent;
            this.aracEkle.ForeColor = System.Drawing.Color.Transparent;
            this.aracEkle.Location = new System.Drawing.Point(340, 177);
            this.aracEkle.Name = "aracEkle";
            this.aracEkle.Size = new System.Drawing.Size(68, 17);
            this.aracEkle.TabIndex = 1;
            this.aracEkle.Text = "Araç Ekle";
            // 
            // soförleriGörüntüle
            // 
            this.soförleriGörüntüle.AutoSize = true;
            this.soförleriGörüntüle.BackColor = System.Drawing.Color.Transparent;
            this.soförleriGörüntüle.ForeColor = System.Drawing.Color.White;
            this.soförleriGörüntüle.Location = new System.Drawing.Point(451, 177);
            this.soförleriGörüntüle.Name = "soförleriGörüntüle";
            this.soförleriGörüntüle.Size = new System.Drawing.Size(128, 17);
            this.soförleriGörüntüle.TabIndex = 2;
            this.soförleriGörüntüle.Text = "Şoförleri Görüntüle";
            // 
            // raporlariGörüntüle
            // 
            this.raporlariGörüntüle.AutoSize = true;
            this.raporlariGörüntüle.BackColor = System.Drawing.Color.Transparent;
            this.raporlariGörüntüle.ForeColor = System.Drawing.Color.White;
            this.raporlariGörüntüle.Location = new System.Drawing.Point(615, 177);
            this.raporlariGörüntüle.Name = "raporlariGörüntüle";
            this.raporlariGörüntüle.Size = new System.Drawing.Size(133, 17);
            this.raporlariGörüntüle.TabIndex = 3;
            this.raporlariGörüntüle.Text = "Raporları Görüntüle";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BiTaksi.Properties.Resources.taksi;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1009, 591);
            this.Controls.Add(this.raporlariGörüntüle);
            this.Controls.Add(this.soförleriGörüntüle);
            this.Controls.Add(this.aracEkle);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Admin";
            this.Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label aracEkle;
        private System.Windows.Forms.Label soförleriGörüntüle;
        private System.Windows.Forms.Label raporlariGörüntüle;
    }
}