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
            this.aracEkle = new System.Windows.Forms.Label();
            this.soförleriGörüntüle = new System.Windows.Forms.Label();
            this.raporlariGörüntüle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // aracEkle
            // 
            this.aracEkle.AutoSize = true;
            this.aracEkle.BackColor = System.Drawing.Color.RosyBrown;
            this.aracEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aracEkle.ForeColor = System.Drawing.Color.Transparent;
            this.aracEkle.Location = new System.Drawing.Point(264, 96);
            this.aracEkle.Name = "aracEkle";
            this.aracEkle.Size = new System.Drawing.Size(96, 25);
            this.aracEkle.TabIndex = 1;
            this.aracEkle.Text = "Araç Ekle";
            this.aracEkle.Click += new System.EventHandler(this.aracEkle_Click);
            // 
            // soförleriGörüntüle
            // 
            this.soförleriGörüntüle.AutoSize = true;
            this.soförleriGörüntüle.BackColor = System.Drawing.Color.RosyBrown;
            this.soförleriGörüntüle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.soförleriGörüntüle.ForeColor = System.Drawing.Color.White;
            this.soförleriGörüntüle.Location = new System.Drawing.Point(418, 96);
            this.soförleriGörüntüle.Name = "soförleriGörüntüle";
            this.soförleriGörüntüle.Size = new System.Drawing.Size(174, 25);
            this.soförleriGörüntüle.TabIndex = 2;
            this.soförleriGörüntüle.Text = "Şoförleri Görüntüle";
            this.soförleriGörüntüle.Click += new System.EventHandler(this.soförleriGörüntüle_Click);
            // 
            // raporlariGörüntüle
            // 
            this.raporlariGörüntüle.AutoSize = true;
            this.raporlariGörüntüle.BackColor = System.Drawing.Color.RosyBrown;
            this.raporlariGörüntüle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.raporlariGörüntüle.ForeColor = System.Drawing.Color.White;
            this.raporlariGörüntüle.Location = new System.Drawing.Point(628, 96);
            this.raporlariGörüntüle.Name = "raporlariGörüntüle";
            this.raporlariGörüntüle.Size = new System.Drawing.Size(179, 25);
            this.raporlariGörüntüle.TabIndex = 3;
            this.raporlariGörüntüle.Text = "Raporları Görüntüle";
            this.raporlariGörüntüle.Click += new System.EventHandler(this.raporlariGörüntüle_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BiTaksi.Properties.Resources.traffic;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1009, 591);
            this.Controls.Add(this.raporlariGörüntüle);
            this.Controls.Add(this.soförleriGörüntüle);
            this.Controls.Add(this.aracEkle);
            this.Name = "Admin";
            this.Text = "Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label aracEkle;
        private System.Windows.Forms.Label soförleriGörüntüle;
        private System.Windows.Forms.Label raporlariGörüntüle;
    }
}