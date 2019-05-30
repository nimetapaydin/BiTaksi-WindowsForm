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
    public partial class AdminGiris : Form
    {
        public BiTaksiDataSet biTaksi = new BiTaksiDataSet();
        public BiTaksiDataSetTableAdapters.adminTableAdapter adminTableAdapter = new BiTaksiDataSetTableAdapters.adminTableAdapter();

        public AdminGiris()
        {
            InitializeComponent();
        }

        private void giris_Click(object sender, EventArgs e)
        {
            string mail = adminEmail.Text;
            string sifre = Common.md5HASH(AdminSifre.Text);

            BiTaksiDataSet.adminRow admin = adminTableAdapter.GetData().FirstOrDefault(x => x.email.Equals(mail) && x.sifre.Equals(sifre));

            if (admin == null)
            {
                MessageBox.Show("Giriş Başarısız");
            }
            else
            {
                Admin adminForm = new Admin();
                adminForm.ShowDialog();
            }
        }
    }
}
