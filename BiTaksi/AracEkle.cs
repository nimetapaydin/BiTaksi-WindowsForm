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
    public partial class AracEkle : Form
    {
        public BiTaksiDataSet biTaksi = new BiTaksiDataSet();
        public BiTaksiDataSetTableAdapters.aracTableAdapter aracTableAdapter = new BiTaksiDataSetTableAdapters.aracTableAdapter();

        public AracEkle()
        {
            InitializeComponent();
        }

        private void Eklearac_Click(object sender, EventArgs e)
        {
            string plaka = aracplaka.Text;
            string model = aracmodeli.Text;

            if (plaka.Equals("") || model.Equals(""))
            {
                MessageBox.Show("Plaka ve model gereklidir");
                return;
            }

            try
            {
                BiTaksiDataSet.aracRow arac = biTaksi.arac.NewaracRow();
                arac.plaka = plaka;
                arac.model = model;
                biTaksi.arac.AddaracRow(arac);
                aracTableAdapter.Update(arac);
                MessageBox.Show("Araç Eklendi");
            }
            catch (Exception)
            {
                MessageBox.Show("Eklenirken bir sorun oluştu");
            }
        }
    }
}
