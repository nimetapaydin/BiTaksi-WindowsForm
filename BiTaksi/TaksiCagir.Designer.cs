namespace BiTaksi
{
    partial class TaksiCagir
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
            this.taksicagirisim = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.taksicagireklebutton = new System.Windows.Forms.Label();
            this.misim = new System.Windows.Forms.TextBox();
            this.mtel = new System.Windows.Forms.TextBox();
            this.madres = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // taksicagirisim
            // 
            this.taksicagirisim.AutoSize = true;
            this.taksicagirisim.BackColor = System.Drawing.Color.Transparent;
            this.taksicagirisim.Enabled = false;
            this.taksicagirisim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.taksicagirisim.ForeColor = System.Drawing.Color.White;
            this.taksicagirisim.Location = new System.Drawing.Point(257, 200);
            this.taksicagirisim.Name = "taksicagirisim";
            this.taksicagirisim.Size = new System.Drawing.Size(72, 25);
            this.taksicagirisim.TabIndex = 0;
            this.taksicagirisim.Text = "İsminiz";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(257, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Telefonunuz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(257, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adresiniz";
            // 
            // taksicagireklebutton
            // 
            this.taksicagireklebutton.AutoSize = true;
            this.taksicagireklebutton.BackColor = System.Drawing.Color.Transparent;
            this.taksicagireklebutton.Location = new System.Drawing.Point(431, 440);
            this.taksicagireklebutton.Name = "taksicagireklebutton";
            this.taksicagireklebutton.Size = new System.Drawing.Size(35, 17);
            this.taksicagireklebutton.TabIndex = 3;
            this.taksicagireklebutton.Text = "Ekle";
            this.taksicagireklebutton.Click += new System.EventHandler(this.taksicagireklebutton_Click);
            // 
            // misim
            // 
            this.misim.Location = new System.Drawing.Point(411, 200);
            this.misim.Name = "misim";
            this.misim.Size = new System.Drawing.Size(202, 22);
            this.misim.TabIndex = 4;
            // 
            // mtel
            // 
            this.mtel.Location = new System.Drawing.Point(411, 264);
            this.mtel.Name = "mtel";
            this.mtel.Size = new System.Drawing.Size(202, 22);
            this.mtel.TabIndex = 5;
            // 
            // madres
            // 
            this.madres.Location = new System.Drawing.Point(411, 323);
            this.madres.Multiline = true;
            this.madres.Name = "madres";
            this.madres.Size = new System.Drawing.Size(202, 87);
            this.madres.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(352, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 36);
            this.label3.TabIndex = 7;
            this.label3.Text = "Taksi Çağır";
            // 
            // TaksiCagir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BiTaksi.Properties.Resources.taksi;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(842, 514);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.madres);
            this.Controls.Add(this.mtel);
            this.Controls.Add(this.misim);
            this.Controls.Add(this.taksicagireklebutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.taksicagirisim);
            this.Name = "TaksiCagir";
            this.Text = "TaksiCagir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label taksicagirisim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label taksicagireklebutton;
        private System.Windows.Forms.TextBox misim;
        private System.Windows.Forms.TextBox mtel;
        private System.Windows.Forms.TextBox madres;
        private System.Windows.Forms.Label label3;
    }
}