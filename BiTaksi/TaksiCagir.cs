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
    public partial class TaksiCagir : Form
    {
        public TaksiCagir()
        {
            InitializeComponent();
        }

        private void taksicagireklebutton_Click(object sender, EventArgs e)
        {
            string mAd = misim.Text;
            string mTel = mtel.Text;
            string mAdres = madres.Text;


        }
    }
}
