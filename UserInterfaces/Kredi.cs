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
    public partial class Kredi : Form
    {
        public Kredi()
        {
            InitializeComponent();
        }
        BLL.Models.Kredi _kredi=new BLL.Models.Kredi();

        string _hataMesaji = "";
        public void gridListele()
        {
            dataGridView1.DataSource = _kredi.listele(ref _hataMesaji);
        }
        private void btnListele_Click(object sender, EventArgs e)
        {
            gridListele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            _kredi.KrediDegeri = int.Parse(txtKredi.Text);
            _kredi.DersId = int.Parse(txtDers.Text);
            _kredi.SinifDuzeyId=int.Parse(txtSinif.Text);
            _kredi.ekle(ref _hataMesaji);
            gridListele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            _kredi.Id = int.Parse(lblId.Text);
            _kredi.KrediDegeri = int.Parse(txtKredi.Text);
            _kredi.DersId = int.Parse(txtDers.Text);
            _kredi.SinifDuzeyId = int.Parse(txtSinif.Text);
            _kredi.guncelle(ref _hataMesaji);
            gridListele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            _kredi.Id = int.Parse(lblId.Text);
            _kredi.sil(ref _hataMesaji);
            gridListele();
        }

        public void gridYenile(int seciliSatir)
        {
            lblId.Text = dataGridView1.Rows[seciliSatir].Cells["Id"].Value.ToString();
            txtKredi.Text = dataGridView1.Rows[seciliSatir].Cells["KrediDegeri"].Value.ToString();
            txtDers.Text = dataGridView1.Rows[seciliSatir].Cells["DersId"].Value.ToString();
            txtSinif.Text = dataGridView1.Rows[seciliSatir].Cells["SinifDuzeyId"].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            gridYenile(e.RowIndex);
        }
    }
}
