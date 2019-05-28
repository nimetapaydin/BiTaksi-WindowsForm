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
        public BiTaksi biTaksi = new BiTaksi();

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
            
            // BiTaksi.soforRow sofor = this.biTaksi.sofor.FirstOrDefault(x => x.tc.Equals(tc) && x.sifre.Equals(sifre));
            //var all = biTaksi.sofor.Where(x => x.tc.Equals(tc) && x.sifre.Equals(sifre)).ToList();

            //if (sofor != null)
            //{
            //    MessageBox.Show("Giriş başarılı", sofor.adisoyadi);
            //}
            //else
            //{
            //    MessageBox.Show("Hooooooğ nabyon");

            //}
        }
    }
}
