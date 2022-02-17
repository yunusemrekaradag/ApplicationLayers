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
    public partial class Bina : Form
    {
        public Bina()
        {
            InitializeComponent();
        }
        BLL.Models.Bina _bina = new BLL.Models.Bina();
        private void gridTazele()
        {
            
            dataGridView1.DataSource = _bina.listele();
        }
        private void Bina_Load(object sender, EventArgs e)
        {
            gridTazele();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            _bina.BinaAdi =textBox1.Text;
            _bina.tipid =int.Parse(textBox2.Text);
            _bina.ekle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gridTazele();
        }
       

        private void button3_Click(object sender, EventArgs e)
        {
            _bina.BinaAdi =textBox1.Text;
            _bina.tipid =int.Parse(textBox2.Text);
            _bina.id =int.Parse(textBox3.Text);
            _bina.güncelle();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            _bina.id =int.Parse(textBox3.Text);
            _bina.Sil();
        }
    }
}
