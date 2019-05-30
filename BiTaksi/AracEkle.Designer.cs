namespace BiTaksi
{
    partial class AracEkle
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
            this.aracplakalabel = new System.Windows.Forms.Label();
            this.aracinmodelilabel = new System.Windows.Forms.Label();
            this.aracplaka = new System.Windows.Forms.TextBox();
            this.aracmodeli = new System.Windows.Forms.TextBox();
            this.Eklearac = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // aracplakalabel
            // 
            this.aracplakalabel.AutoSize = true;
            this.aracplakalabel.BackColor = System.Drawing.Color.Transparent;
            this.aracplakalabel.ForeColor = System.Drawing.Color.White;
            this.aracplakalabel.Location = new System.Drawing.Point(279, 201);
            this.aracplakalabel.Name = "aracplakalabel";
            this.aracplakalabel.Size = new System.Drawing.Size(99, 17);
            this.aracplakalabel.TabIndex = 0;
            this.aracplakalabel.Text = "Araç\'ın plakası";
            // 
            // aracinmodelilabel
            // 
            this.aracinmodelilabel.AutoSize = true;
            this.aracinmodelilabel.BackColor = System.Drawing.Color.Transparent;
            this.aracinmodelilabel.ForeColor = System.Drawing.Color.White;
            this.aracinmodelilabel.Location = new System.Drawing.Point(279, 269);
            this.aracinmodelilabel.Name = "aracinmodelilabel";
            this.aracinmodelilabel.Size = new System.Drawing.Size(96, 17);
            this.aracinmodelilabel.TabIndex = 1;
            this.aracinmodelilabel.Text = "Araç\'ın modeli";
            // 
            // aracplaka
            // 
            this.aracplaka.Location = new System.Drawing.Point(429, 195);
            this.aracplaka.Name = "aracplaka";
            this.aracplaka.Size = new System.Drawing.Size(153, 22);
            this.aracplaka.TabIndex = 2;
            // 
            // aracmodeli
            // 
            this.aracmodeli.Location = new System.Drawing.Point(429, 264);
            this.aracmodeli.Name = "aracmodeli";
            this.aracmodeli.Size = new System.Drawing.Size(153, 22);
            this.aracmodeli.TabIndex = 3;
            // 
            // Eklearac
            // 
            this.Eklearac.AutoSize = true;
            this.Eklearac.BackColor = System.Drawing.Color.Transparent;
            this.Eklearac.Location = new System.Drawing.Point(409, 385);
            this.Eklearac.Name = "Eklearac";
            this.Eklearac.Size = new System.Drawing.Size(35, 17);
            this.Eklearac.TabIndex = 4;
            this.Eklearac.Text = "Ekle";
            this.Eklearac.Click += new System.EventHandler(this.Eklearac_Click);
            // 
            // AracEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BiTaksi.Properties.Resources.taksi;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Eklearac);
            this.Controls.Add(this.aracmodeli);
            this.Controls.Add(this.aracplaka);
            this.Controls.Add(this.aracinmodelilabel);
            this.Controls.Add(this.aracplakalabel);
            this.Name = "AracEkle";
            this.Text = "AracEkle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label aracplakalabel;
        private System.Windows.Forms.Label aracinmodelilabel;
        private System.Windows.Forms.TextBox aracplaka;
        private System.Windows.Forms.TextBox aracmodeli;
        private System.Windows.Forms.Label Eklearac;
    }
}