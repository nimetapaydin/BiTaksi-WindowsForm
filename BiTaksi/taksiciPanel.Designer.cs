namespace BiTaksi
{
    partial class taksiciPanel
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tpad = new System.Windows.Forms.TextBox();
            this.tpmad = new System.Windows.Forms.TextBox();
            this.tpmtel = new System.Windows.Forms.TextBox();
            this.tpmadres = new System.Windows.Forms.TextBox();
            this.tpdurum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(300, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adınız:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(300, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şuanki Durumunuz:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(300, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Müşterinizin adı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(300, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Müşterinizin telefonu\t:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(300, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Müşterinizin adresi:";
            // 
            // tpad
            // 
            this.tpad.Location = new System.Drawing.Point(460, 142);
            this.tpad.Name = "tpad";
            this.tpad.Size = new System.Drawing.Size(247, 22);
            this.tpad.TabIndex = 5;
            // 
            // tpmad
            // 
            this.tpmad.Location = new System.Drawing.Point(460, 235);
            this.tpmad.Name = "tpmad";
            this.tpmad.Size = new System.Drawing.Size(247, 22);
            this.tpmad.TabIndex = 6;
            // 
            // tpmtel
            // 
            this.tpmtel.Location = new System.Drawing.Point(460, 277);
            this.tpmtel.Name = "tpmtel";
            this.tpmtel.Size = new System.Drawing.Size(247, 22);
            this.tpmtel.TabIndex = 7;
            // 
            // tpmadres
            // 
            this.tpmadres.Location = new System.Drawing.Point(460, 317);
            this.tpmadres.Name = "tpmadres";
            this.tpmadres.Size = new System.Drawing.Size(247, 22);
            this.tpmadres.TabIndex = 8;
            // 
            // tpdurum
            // 
            this.tpdurum.Location = new System.Drawing.Point(460, 189);
            this.tpdurum.Name = "tpdurum";
            this.tpdurum.Size = new System.Drawing.Size(247, 22);
            this.tpdurum.TabIndex = 9;
            // 
            // taksiciPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BiTaksi.Properties.Resources.taksi;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(947, 450);
            this.Controls.Add(this.tpdurum);
            this.Controls.Add(this.tpmadres);
            this.Controls.Add(this.tpmtel);
            this.Controls.Add(this.tpmad);
            this.Controls.Add(this.tpad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "taksiciPanel";
            this.Text = "taksiciPanel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tpad;
        private System.Windows.Forms.TextBox tpmad;
        private System.Windows.Forms.TextBox tpmtel;
        private System.Windows.Forms.TextBox tpmadres;
        private System.Windows.Forms.TextBox tpdurum;
    }
}