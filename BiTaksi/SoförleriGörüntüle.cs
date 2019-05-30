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
    public partial class SoförleriGörüntüle : Form
    {
        public SoförleriGörüntüle()
        {
            InitializeComponent();
        }

        private void soforBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.soforBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.biTaksiDataSet);

        }

        private void SoförleriGörüntüle_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'biTaksiDataSet.sofor' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.soforTableAdapter.Fill(this.biTaksiDataSet.sofor);

        }
    }
}
