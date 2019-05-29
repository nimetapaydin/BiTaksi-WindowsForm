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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void aracEkle_Click(object sender, EventArgs e)
        {
            AracEkle frm = new AracEkle();
            frm.ShowDialog();
        }

        private void soförleriGörüntüle_Click(object sender, EventArgs e)
        {
            SoförleriGörüntüle frm = new SoförleriGörüntüle();
            frm.ShowDialog();
        }

        private void raporlariGörüntüle_Click(object sender, EventArgs e)
        {
            RaporlarıGörüntüle frm = new RaporlarıGörüntüle();
            frm.ShowDialog();
        }
    }
}
