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
        public TaksiciGiris()
        {
            InitializeComponent();
        }
        
        private void TaksiciGiris_Load(object sender, EventArgs e)
        {

        }

        private string md5HASH(string txt)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();

            byte[] btr = Encoding.UTF8.GetBytes(txt); // 
            btr = md5.ComputeHash(btr); // metini hashliyor

            StringBuilder sb = new StringBuilder();
            
            // hash içeren byte dizi string'e çeviriyoruz
            foreach (byte ba in btr)
            {
                sb.Append(ba.ToString("x2").ToLower());
            }

            return sb.ToString();
        }

        private void taksicigirisbutton_Click(object sender, EventArgs e)
        {
            string tc = sofortctextbox.Text;
            string sifre = md5HASH(soforsifretextbox.Text);

            this.sofortc
        }
    }
}
