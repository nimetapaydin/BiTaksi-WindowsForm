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
    public partial class RaporlarıGörüntüle : Form
    {
        public RaporlarıGörüntüle()
        {
            InitializeComponent();
        }

        private void raporBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.raporBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.biTaksiDataSet);

        }

        private void RaporlarıGörüntüle_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'biTaksiDataSet.rapor' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.raporTableAdapter.Fill(this.biTaksiDataSet.rapor);

        }
    }
}
