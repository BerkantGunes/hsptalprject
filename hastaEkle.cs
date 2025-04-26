using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hospital
{
    public partial class hastaEkle : Form
    {
        public hastaEkle()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        hastane_yonetimEntities ef = new hastane_yonetimEntities();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            Hasta yenihasta = new Hasta();

            yenihasta.TCKN = Convert.ToInt64(txthastaTC.Text);
            yenihasta.Ad = txthastaAd.Text;
            yenihasta.Soyad = txthastaSoyad.Text;
            yenihasta.KanGrubu = txtKan.Text;
            yenihasta.Cinsiyet = txtCinsiyet.Text;
            yenihasta.DogumTarihi = dateTimePicker1.Value;
            yenihasta.KroniKHastalıklar = txtHastalik.Text;

            ef.Hasta.Add(yenihasta);
            ef.SaveChanges();

        }

        private void hastaEkle_Load(object sender, EventArgs e)
        {
            DGVHasta.DataSource = ef.Hasta.ToList();
            foreach(var item in ef.Hasta.ToList())
            {
                cbHasta.Items.Add(item.TCKN);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            long tcNo;
            tcNo = (long)cbHasta.SelectedItem;

            var guncelle = ef.Hasta.Where(x => x.TCKN == tcNo).FirstOrDefault();

            guncelle.Ad = txthastaAd.Text;
            guncelle.Soyad = txthastaSoyad.Text;
            guncelle.KanGrubu = txtKan.Text;
            guncelle.Cinsiyet = txtCinsiyet.Text;
            guncelle.DogumTarihi = dateTimePicker1.Value;
            guncelle.KroniKHastalıklar = txtHastalik.Text;

            ef.SaveChanges();
            DGVHasta.DataSource = ef.Hasta.ToList();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            long tckn;
            tckn = (long)cbHasta.SelectedItem;
            var sil = ef.Hasta.Where(x => x.TCKN == tckn).FirstOrDefault();
        }

        private void cbHasta_SelectedIndexChanged(object sender, EventArgs e)
        {
            long tckn;
            tckn = (long)cbHasta.SelectedItem;
            var secilen = ef.Hasta.Where(x => x.TCKN == tckn).FirstOrDefault();

            txthastaAd.Text = secilen.Ad;
            txthastaSoyad.Text = secilen.Soyad;
            txtKan.Text = secilen.KanGrubu;
            txtCinsiyet.Text = secilen.Cinsiyet;
            dateTimePicker1.Value = secilen.DogumTarihi;
            txtHastalik.Text = secilen.KroniKHastalıklar;
        }
    }
}
