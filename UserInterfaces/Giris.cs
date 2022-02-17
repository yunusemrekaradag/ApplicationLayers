using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterfaces
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            BLL.Models.Giris _giris = new BLL.Models.Giris();
            string _hataMesaji = "";

            _giris.kullaniciAdi = txtKullaniciAdi.Text;
            _giris.kullaniciSifresi = txtKullaniciSifre.Text;
            _giris.giris(ref _hataMesaji);

            if (_giris.id > 0)
            {
                Ogrenci _ogrenci = new Ogrenci();
                _ogrenci.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(_hataMesaji, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
