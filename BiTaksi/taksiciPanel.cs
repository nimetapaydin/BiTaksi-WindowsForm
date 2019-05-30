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
    public partial class taksiciPanel : Form
    {
        private bool complated = false;
        public BiTaksiDataSet biTaksi = new BiTaksiDataSet();
        public BiTaksiDataSet.soforRow model;
        public BiTaksiDataSet.cagriRow cagri;
        public BiTaksiDataSetTableAdapters.cagriTableAdapter cagriTableAdapter = new BiTaksiDataSetTableAdapters.cagriTableAdapter();
        public BiTaksiDataSetTableAdapters.soforTableAdapter soforTableAdapter = new BiTaksiDataSetTableAdapters.soforTableAdapter();
        public BiTaksiDataSetTableAdapters.aracTableAdapter aracTableAdapter = new BiTaksiDataSetTableAdapters.aracTableAdapter();
        public BiTaksiDataSetTableAdapters.raporTableAdapter raporTableAdapter = new BiTaksiDataSetTableAdapters.raporTableAdapter();

        public taksiciPanel()
        {
            InitializeComponent();
        }

        public void loadSofor()
        {
            int soforId = model.id;
            tpad.Text = model.adisoyadi;
            tpdurum.Text = model.aktif.Equals("1") ? "Şu an çalışmaktasınız" : "Boştasınız";

            cagri = cagriTableAdapter.GetData().FindBysofor_id(soforId);

            if (cagri != null && cagri.aktif.Equals("1"))
            {
                tpmad.Text = cagri.musteri_adisoyadi;
                tpmadres.Text = cagri.musteri_adres;
                tpmtel.Text = cagri.musteri_telefon;
            }
        }

        private void isiTamamla_Click(object sender, EventArgs e)
        {
            if (complated)
                return;
            
            string kazanc = kazancInput.Text;
            if (kazanc.Equals(""))
            {
                MessageBox.Show("Kazanç girmelisiniz");
                return;
            }
            int soforId = model.id;
            model.aktif = "0";
            soforTableAdapter.Update(model);

            BiTaksiDataSet.aracRow araba = aracTableAdapter.GetData().FirstOrDefault(x => !x.Issofor_idNull() && x.sofor_id == soforId);
            string plaka = araba.plaka;

            cagri.aktif = "0";
            cagriTableAdapter.Update(cagri);

            BiTaksiDataSet.raporRow rapor = biTaksi.rapor.NewraporRow();
            rapor.sofor_id = soforId;
            rapor.arac_plaka = plaka;
            rapor.kazanc = double.Parse(kazanc);
            rapor.tarih = DateTime.Now;
            biTaksi.rapor.AddraporRow(rapor);
            raporTableAdapter.Update(rapor);
            MessageBox.Show("İşiniz Tamamlandı");

            tpmad.Text = "";
            tpmadres.Text = "";
            tpmtel.Text = "";
            complated = true;
        }
    }
}
