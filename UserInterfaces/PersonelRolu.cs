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
    public partial class PersonelRolu : Form
    {
        public PersonelRolu()
        {
            InitializeComponent();
        }

        BLL.Models.PersonelRolu _personelRolu = new BLL.Models.PersonelRolu();
        private void btn_Listele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _personelRolu.listele();
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            _personelRolu.personelRolu = txt_Rol.Text;
            _personelRolu.ekle();
            dataGridView1.DataSource = _personelRolu.listele();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            _personelRolu.id = int.Parse(txt_id.Text);
            _personelRolu.personelRolu =txt_Rol.Text;
            bool result =_personelRolu.guncelle();
            dataGridView1.DataSource = _personelRolu.listele();
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            _personelRolu.id = int.Parse(txt_id.Text);
            bool result = _personelRolu.sil();
            dataGridView1.DataSource = _personelRolu.listele();
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString();
            txt_Rol.Text = dataGridView1.SelectedRows[0].Cells["Personel_Rolu"].Value.ToString();
        }
    }
}
