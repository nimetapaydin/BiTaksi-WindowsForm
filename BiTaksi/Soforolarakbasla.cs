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
    public partial class Soforolarakbasla : Form
    {
        public BiTaksi biTaksi = new BiTaksi();
        BiTaksiTableAdapters.soforTableAdapter soforTableAdapter = new BiTaksiTableAdapters.soforTableAdapter();

        public Soforolarakbasla()
        {
            InitializeComponent();
        }

        private void sKayıtEkleButton_Click(object sender, EventArgs e)
        {
            string adisoyadi = skayitadtextbox.Text;
            string tc = skayitctextbox.Text;
            string sifre = skayitsifretextbox.Text;

            BiTaksi.soforRow sofor = biTaksi.sofor.NewsoforRow();
            sofor.adisoyadi = adisoyadi;
            sofor.tc= tc;
            sofor.sifre = Common.md5HASH(sifre);
            sofor.aktif = "0";
            sofor.onayli = "1";

            try
            {
                biTaksi.sofor.AddsoforRow(sofor);
                soforTableAdapter.Update(sofor);
                MessageBox.Show("kaydınız eklenmiştir");
            }
            catch (Exception)
            {
                MessageBox.Show("kayıt eklenirken sorun oluştu");
            }
            
        }
    }
}
