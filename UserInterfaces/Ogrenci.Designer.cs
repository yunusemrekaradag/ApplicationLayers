namespace UserInterfaces
{
    partial class Ogrenci
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtOgrenciAdi = new System.Windows.Forms.TextBox();
            this.lbl_ogrenciadi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOgrenciSoyadi = new System.Windows.Forms.TextBox();
            this.lblogrencisinif = new System.Windows.Forms.Label();
            this.txtogrencisinif = new System.Windows.Forms.TextBox();
            this.btnekle = new System.Windows.Forms.Button();
            this.btnduzenle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnlistele = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(293, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(299, 343);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtOgrenciAdi
            // 
            this.txtOgrenciAdi.Location = new System.Drawing.Point(97, 45);
            this.txtOgrenciAdi.Name = "txtOgrenciAdi";
            this.txtOgrenciAdi.Size = new System.Drawing.Size(124, 20);
            this.txtOgrenciAdi.TabIndex = 1;
            // 
            // lbl_ogrenciadi
            // 
            this.lbl_ogrenciadi.AutoSize = true;
            this.lbl_ogrenciadi.Location = new System.Drawing.Point(12, 48);
            this.lbl_ogrenciadi.Name = "lbl_ogrenciadi";
            this.lbl_ogrenciadi.Size = new System.Drawing.Size(62, 13);
            this.lbl_ogrenciadi.TabIndex = 2;
            this.lbl_ogrenciadi.Text = "Öğrenci Adi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Öğrenci Soyadi";
            // 
            // txtOgrenciSoyadi
            // 
            this.txtOgrenciSoyadi.Location = new System.Drawing.Point(97, 76);
            this.txtOgrenciSoyadi.Name = "txtOgrenciSoyadi";
            this.txtOgrenciSoyadi.Size = new System.Drawing.Size(124, 20);
            this.txtOgrenciSoyadi.TabIndex = 3;
            // 
            // lblogrencisinif
            // 
            this.lblogrencisinif.AutoSize = true;
            this.lblogrencisinif.Location = new System.Drawing.Point(12, 119);
            this.lblogrencisinif.Name = "lblogrencisinif";
            this.lblogrencisinif.Size = new System.Drawing.Size(67, 13);
            this.lblogrencisinif.TabIndex = 6;
            this.lblogrencisinif.Text = "Öğrenci Sınıf";
            // 
            // txtogrencisinif
            // 
            this.txtogrencisinif.Location = new System.Drawing.Point(97, 112);
            this.txtogrencisinif.Name = "txtogrencisinif";
            this.txtogrencisinif.Size = new System.Drawing.Size(124, 20);
            this.txtogrencisinif.TabIndex = 5;
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(12, 185);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(73, 56);
            this.btnekle.TabIndex = 7;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            // 
            // btnduzenle
            // 
            this.btnduzenle.Location = new System.Drawing.Point(107, 185);
            this.btnduzenle.Name = "btnduzenle";
            this.btnduzenle.Size = new System.Drawing.Size(73, 56);
            this.btnduzenle.TabIndex = 8;
            this.btnduzenle.Text = "Düzenle";
            this.btnduzenle.UseVisualStyleBackColor = true;
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(12, 271);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(73, 56);
            this.btnsil.TabIndex = 9;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            // 
            // btnlistele
            // 
            this.btnlistele.Location = new System.Drawing.Point(107, 271);
            this.btnlistele.Name = "btnlistele";
            this.btnlistele.Size = new System.Drawing.Size(73, 56);
            this.btnlistele.TabIndex = 10;
            this.btnlistele.Text = "Listele";
            this.btnlistele.UseVisualStyleBackColor = true;
            // 
            // Ogrenci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 456);
            this.Controls.Add(this.btnlistele);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnduzenle);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.lblogrencisinif);
            this.Controls.Add(this.txtogrencisinif);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOgrenciSoyadi);
            this.Controls.Add(this.lbl_ogrenciadi);
            this.Controls.Add(this.txtOgrenciAdi);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Ogrenci";
            this.Text = "Ogrenci";
            this.Load += new System.EventHandler(this.Ogrenci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtOgrenciAdi;
        private System.Windows.Forms.Label lbl_ogrenciadi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOgrenciSoyadi;
        private System.Windows.Forms.Label lblogrencisinif;
        private System.Windows.Forms.TextBox txtogrencisinif;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btnduzenle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnlistele;
    }
}