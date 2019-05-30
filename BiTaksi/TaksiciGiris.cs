using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiTaksi
{
    public partial class TaksiciGiris : Form
    {
        public BiTaksiDataSet biTaksi = new BiTaksiDataSet();
        public BiTaksiDataSetTableAdapters.soforTableAdapter soforTableAdapter = new BiTaksiDataSetTableAdapters.soforTableAdapter();

        public TaksiciGiris()
        {
            InitializeComponent();
        }
        
        private void TaksiciGiris_Load(object sender, EventArgs e)
        {
        }

        private void taksicigirisbutton_Click_1(object sender, EventArgs e)
        {
            string tc = sofortctextbox.Text;
            string sifre = Common.md5HASH(soforsifretextbox.Text);

            BiTaksiDataSet.soforRow sofor = soforTableAdapter.GetData().FirstOrDefault(x => x.tc.Equals(tc) && x.sifre.Equals(sifre));

            if (sofor != null)
            {
                taksiciPanel panel = new taksiciPanel();
                panel.model = sofor;
                panel.loadSofor();
                panel.ShowDialog();
            }
            else
            {
                MessageBox.Show("Giriş Başarısız");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Anasayfa frm = new Anasayfa();
            frm.ShowDialog();
        }
    }
}
