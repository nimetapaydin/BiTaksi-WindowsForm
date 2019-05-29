namespace BiTaksi
{
    partial class TaksiciGiris
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
            this.sofortc = new System.Windows.Forms.Label();
            this.sifre = new System.Windows.Forms.Label();
            this.sofortctextbox = new System.Windows.Forms.TextBox();
            this.soforsifretextbox = new System.Windows.Forms.TextBox();
            this.taksicigirisbutton = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.adminBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(325, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Taksici Giriş";
            // 
            // sofortc
            // 
            this.sofortc.AutoSize = true;
            this.sofortc.BackColor = System.Drawing.Color.Transparent;
            this.sofortc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sofortc.ForeColor = System.Drawing.Color.White;
            this.sofortc.Location = new System.Drawing.Point(268, 225);
            this.sofortc.Name = "sofortc";
            this.sofortc.Size = new System.Drawing.Size(100, 25);
            this.sofortc.TabIndex = 1;
            this.sofortc.Text = "Şoför TC";
            // 
            // sifre
            // 
            this.sifre.AutoSize = true;
            this.sifre.BackColor = System.Drawing.Color.Transparent;
            this.sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifre.ForeColor = System.Drawing.Color.White;
            this.sifre.Location = new System.Drawing.Point(268, 291);
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(52, 25);
            this.sifre.TabIndex = 2;
            this.sifre.Text = "Şifre";
            // 
            // sofortctextbox
            // 
            this.sofortctextbox.Location = new System.Drawing.Point(427, 225);
            this.sofortctextbox.Name = "sofortctextbox";
            this.sofortctextbox.Size = new System.Drawing.Size(161, 22);
            this.sofortctextbox.TabIndex = 3;
            // 
            // soforsifretextbox
            // 
            this.soforsifretextbox.Location = new System.Drawing.Point(427, 295);
            this.soforsifretextbox.Name = "soforsifretextbox";
            this.soforsifretextbox.Size = new System.Drawing.Size(161, 22);
            this.soforsifretextbox.TabIndex = 4;
            // 
            // taksicigirisbutton
            // 
            this.taksicigirisbutton.AutoSize = true;
            this.taksicigirisbutton.BackColor = System.Drawing.Color.Transparent;
            this.taksicigirisbutton.Location = new System.Drawing.Point(408, 408);
            this.taksicigirisbutton.Name = "taksicigirisbutton";
            this.taksicigirisbutton.Size = new System.Drawing.Size(66, 17);
            this.taksicigirisbutton.TabIndex = 7;
            this.taksicigirisbutton.Text = "Giriş Yap";
            this.taksicigirisbutton.Click += new System.EventHandler(this.taksicigirisbutton_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(699, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Anasayfa";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // adminBindingSource
            // 
            this.adminBindingSource.DataMember = "admin";
            // 
            // TaksiciGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BiTaksi.Properties.Resources.taksi;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(824, 477);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.taksicigirisbutton);
            this.Controls.Add(this.soforsifretextbox);
            this.Controls.Add(this.sofortctextbox);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.sofortc);
            this.Controls.Add(this.label1);
            this.Name = "TaksiciGiris";
            this.Text = "TaksiciGiris";
            this.Load += new System.EventHandler(this.TaksiciGiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label sofortc;
        private System.Windows.Forms.Label sifre;
        private System.Windows.Forms.TextBox sofortctextbox;
        private System.Windows.Forms.TextBox soforsifretextbox;
        private System.Windows.Forms.Label taksicigirisbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource adminBindingSource;
    }
}