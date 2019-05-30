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
        public BiTaksiDataSet biTaksi = new BiTaksiDataSet();

        public BiTaksiDataSetTableAdapters.aracTableAdapter aracTableAdapter = new BiTaksiDataSetTableAdapters.aracTableAdapter();
        public BiTaksiDataSetTableAdapters.soforTableAdapter soforTableAdapter = new BiTaksiDataSetTableAdapters.soforTableAdapter();
        public BiTaksiDataSetTableAdapters.cagriTableAdapter cagriTableAdapter = new BiTaksiDataSetTableAdapters.cagriTableAdapter();

        public TaksiCagir()
        {
            InitializeComponent();
        }

        private void taksicagireklebutton_Click(object sender, EventArgs e)
        {
            BiTaksiDataSet.aracRow yeniAraba = biTaksi.arac.NewaracRow();
            yeniAraba.plaka = Common.uniqueID().ToString().Substring(0, 10);
            yeniAraba.model = Common.uniqueID().ToString().Substring(0, 2) + " BMW";
            biTaksi.arac.AddaracRow(yeniAraba);
            aracTableAdapter.Update(yeniAraba);


            string mAd = misim.Text;
            string mTel = mtel.Text;
            string mAdres = madres.Text;

            BiTaksiDataSet.aracRow bostaArac = aracTableAdapter.GetData().FirstOrDefault(x => x.Issofor_idNull());
            BiTaksiDataSet.soforRow rastgeleSofor = soforTableAdapter.GetData().FirstOrDefault(x => x.aktif.Equals("0") && x.onayli.Equals("1"));
            if (bostaArac == null)
            {
                List<BiTaksiDataSet.aracRow> aracRows = aracTableAdapter.GetData().Where(x => !x.Issofor_idNull()).ToList();
                rastgeleSofor = soforTableAdapter.GetData().FirstOrDefault(x => x.aktif.Equals("0") && x.onayli.Equals("1") && aracRows.FindIndex(y => !y.Issofor_idNull() && y.sofor_id == x.id) != -1);
            }

            if (rastgeleSofor != null)
            {
                BiTaksiDataSet.aracRow araba = aracTableAdapter.GetData().FirstOrDefault(x => !x.Issofor_idNull() && x.sofor_id == rastgeleSofor.id);

                if (araba != null)
                {
                    rastgeleSofor.aktif = "1";
                    soforTableAdapter.Update(rastgeleSofor);

                    BiTaksiDataSet.cagriRow musteri = cagriTableAdapter.GetData().FindBysofor_id(rastgeleSofor.id);

                    try
                    {
                        if (musteri != null)
                        {
                            musteri.musteri_adisoyadi = mAd;
                            musteri.musteri_adres = mAdres;
                            musteri.musteri_telefon = mTel;
                            musteri.aktif = "1";

                            cagriTableAdapter.Update(musteri);
                        }
                        else
                        {
                            musteri = biTaksi.cagri.NewcagriRow();
                            musteri.sofor_id = rastgeleSofor.id;
                            musteri.musteri_adisoyadi = mAd;
                            musteri.musteri_adres = mAdres;
                            musteri.musteri_telefon = mTel;
                            musteri.aktif = "1";
                        }

                        MessageBox.Show("Araç Yola Çıkmıştır");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Taksi çağrılırken bir sorun oluştu");
                    }
                }
                else
                {
                    araba = aracTableAdapter.GetData().FirstOrDefault(x => x.Issofor_idNull());

                    if (araba == null)
                    {
                        MessageBox.Show("Boşta aracımız yoktur");
                        return;
                    }

                    araba.sofor_id = rastgeleSofor.id;
                    aracTableAdapter.Update(araba);

                    rastgeleSofor.aktif = "1";
                    soforTableAdapter.Update(rastgeleSofor);

                    BiTaksiDataSet.cagriRow musteri = cagriTableAdapter.GetData().FindBysofor_id(rastgeleSofor.id);

                    try
                    {
                        if (musteri != null)
                        {
                            musteri.musteri_adisoyadi = mAd;
                            musteri.musteri_adres = mAdres;
                            musteri.musteri_telefon = mTel;
                            musteri.aktif = "1";

                            cagriTableAdapter.Update(musteri);
                        }
                        else
                        {
                            musteri = biTaksi.cagri.NewcagriRow();
                            musteri.sofor_id = rastgeleSofor.id;
                            musteri.musteri_adisoyadi = mAd;
                            musteri.musteri_adres = mAdres;
                            musteri.musteri_telefon = mTel;
                            musteri.aktif = "1";

                            biTaksi.cagri.AddcagriRow(musteri);
                            cagriTableAdapter.Update(musteri);
                        }

                        MessageBox.Show("Araç Yola Çıkmıştır");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Taksi çağrılırken bir sorun oluştu");
                    }
                }
            }
            else
            {
                MessageBox.Show("Boşta aracımız yoktur");
            }
        }
    }
}
