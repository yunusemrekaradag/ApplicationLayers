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
    public partial class Personel : Form
    {
        public Personel()
        {
            InitializeComponent();
        }
        BLL.Models.Personel _personel = new BLL.Models.Personel();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            bool result = true;
            string _hataMesaji = "";
            _personel.personelAdi = txtAdi.Text;
            _personel.personelSoyadi = txtSoyadi.Text;
            _personel.tcNo=int.Parse(txttcNo.Text);
            result = _personel.ekle(ref _hataMesaji);

            dataGridView1.DataSource = _personel.ekle(ref _hataMesaji);

            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            bool result = true;
            string _hataMesaji = "";
            _personel.tcNo = int.Parse(txttcNo.Text);
            result = _personel.sil(ref _hataMesaji);

            dataGridView1.DataSource = _personel.sil(ref _hataMesaji);
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string _hataMesaji = "";
            dt = _personel.listele(ref _hataMesaji);

            dataGridView1.DataSource = _personel.listele(ref _hataMesaji);  
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            bool result = true;
            string _hataMesaji = "";
            _personel.personelAdi=txtAdi.Text;
            _personel.personelSoyadi=txtSoyadi.Text;
            _personel.tcNo = int.Parse(txttcNo.Text);
            result = _personel.guncelle(ref _hataMesaji);

            dataGridView1.DataSource = _personel.guncelle(ref _hataMesaji);
        }
    }
}
