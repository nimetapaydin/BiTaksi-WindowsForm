namespace BiTaksi
{
    partial class AdminGiris
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.adminEmail = new System.Windows.Forms.TextBox();
            this.AdminSifre = new System.Windows.Forms.TextBox();
            this.giris = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(357, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(357, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre";
            // 
            // adminEmail
            // 
            this.adminEmail.Location = new System.Drawing.Point(486, 246);
            this.adminEmail.Name = "adminEmail";
            this.adminEmail.Size = new System.Drawing.Size(214, 22);
            this.adminEmail.TabIndex = 2;
            // 
            // AdminSifre
            // 
            this.AdminSifre.Location = new System.Drawing.Point(486, 299);
            this.AdminSifre.Name = "AdminSifre";
            this.AdminSifre.Size = new System.Drawing.Size(214, 22);
            this.AdminSifre.TabIndex = 3;
            // 
            // giris
            // 
            this.giris.AutoSize = true;
            this.giris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(3)))));
            this.giris.Location = new System.Drawing.Point(494, 511);
            this.giris.Name = "giris";
            this.giris.Size = new System.Drawing.Size(37, 17);
            this.giris.TabIndex = 4;
            this.giris.Text = "Giris";
            this.giris.Click += new System.EventHandler(this.giris_Click);
            // 
            // AdminGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BiTaksi.Properties.Resources.taksi;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(962, 594);
            this.Controls.Add(this.giris);
            this.Controls.Add(this.AdminSifre);
            this.Controls.Add(this.adminEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdminGiris";
            this.Text = "AdminGiris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox adminEmail;
        private System.Windows.Forms.TextBox AdminSifre;
        private System.Windows.Forms.Label giris;
    }
}