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
        public BiTaksiDataSet.soforRow model;
        public BiTaksiDataSet.cagriRow cagri;
        public BiTaksiDataSetTableAdapters.cagriTableAdapter cagriTableAdapter = new BiTaksiDataSetTableAdapters.cagriTableAdapter();

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

            if (cagri != null)
            {
                tpmad.Text = cagri.musteri_adisoyadi;
                tpmadres.Text = cagri.musteri_adres;
                tpmtel.Text = cagri.musteri_telefon;
            }
        }
    }
}
