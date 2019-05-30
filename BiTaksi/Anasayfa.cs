using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiTaksi
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            TaksiCagir frm = new TaksiCagir();
            frm.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Soforolarakbasla frm = new Soforolarakbasla();
            frm.ShowDialog();
        }

        private void soforüyegirisi_Click(object sender, EventArgs e)
        {
            TaksiciGiris frm = new TaksiciGiris();
            frm.ShowDialog();
        }


        private void adminButton_Click(object sender, EventArgs e)
        {
            AdminGiris frm = new AdminGiris();
            frm.ShowDialog();
        }
    }
}
