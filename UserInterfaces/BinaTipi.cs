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
    public partial class BinaTipi : Form
    {
        public BinaTipi()
        {
            InitializeComponent();
        }
        //global
        BLL.Models.BinaTipi _binaTipi = new BLL.Models.BinaTipi();
        private void btn_listele_Click(object sender, EventArgs e)
        {
           dataGridView1.DataSource = _binaTipi.Listele();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            _binaTipi.bina_tipi = txt_binaTipi.Text;
            bool result = _binaTipi.Ekle();
            dataGridView1.DataSource = _binaTipi.Listele();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            _binaTipi.id = int.Parse(txt_id.Text);
            _binaTipi.bina_tipi = txt_binaTipi.Text;
            bool result = _binaTipi.Guncelle();
            dataGridView1.DataSource = _binaTipi.Listele();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            _binaTipi.id = int.Parse(txt_id.Text);
            bool result = _binaTipi.Sil();
            dataGridView1.DataSource = _binaTipi.Listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = dataGridView1.SelectedRows[0].Cells["id"].Value.ToString();
            txt_binaTipi.Text = dataGridView1.SelectedRows[0].Cells["bina_tipi"].Value.ToString();
        }
    }
}
