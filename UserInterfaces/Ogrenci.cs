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
    public partial class Ogrenci : Form
    {
        public Ogrenci()
        {
            InitializeComponent();
        }
        BLL.Models.Ogrenci ogrenci = new BLL.Models.Ogrenci();

       

        private void btnlistele_Click(object sender, EventArgs e)
        {
            ogrenci.listele();
            dataGridView1.DataSource = ogrenci.listele();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            ogrenci.id = int.Parse(textBox1.Text);
            ogrenci.sil();   

        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            
            ogrenci.OgrenciAdi = txtOgrenciAdi.Text;
           ogrenci.OgrenciSoyadi= txtOgrenciSoyadi.Text;

            ogrenci.OgrenciSinif= txtogrencisinif.Text;

            bool sonuc = ogrenci.ekle();

        }

        private void btnduzenle_Click(object sender, EventArgs e)
        {
            ogrenci.id = int.Parse(textBox1.Text);


            ogrenci.OgrenciAdi = txtOgrenciAdi.Text;
            ogrenci.OgrenciSoyadi = txtOgrenciSoyadi.Text;

            ogrenci.OgrenciSinif = txtogrencisinif.Text;

            bool sonuc = ogrenci.guncelle();
        }
    }
}
