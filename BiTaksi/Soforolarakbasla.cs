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
        public BiTaksiDataSet biTaksi = new BiTaksiDataSet();
        BiTaksiDataSetTableAdapters.soforTableAdapter soforTableAdapter = new BiTaksiDataSetTableAdapters.soforTableAdapter();

        public Soforolarakbasla()
        {
            InitializeComponent();
        }

        private void sKayıtEkleButton_Click(object sender, EventArgs e)
        {
            string adisoyadi = skayitadtextbox.Text;
            string tc = skayitctextbox.Text;
            string sifre = skayitsifretextbox.Text;

            BiTaksiDataSet.soforRow sofor = soforTableAdapter.GetData().FirstOrDefault(x => x.tc.Equals(tc));
            if (sofor != null)
            {
                MessageBox.Show("Bu TC'ye ait şoför bulunmakta");
                return;
            }

            sofor = biTaksi.sofor.NewsoforRow();
            sofor.id = Common.uniqueID();
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
