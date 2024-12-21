using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlyGlassApp
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void BtnStok_Click(object sender, EventArgs e)
        {
            StokForm stokForm = new StokForm();
            stokForm.Show();
        }

        private void BtnUrunler_Click(object sender, EventArgs e)
        {
            UrunlerForm urunlerForm = new UrunlerForm();
            urunlerForm.Show();
        }

        private void BtnUretimler_Click(object sender, EventArgs e)
        {
            UretimlerForm uretimlerForm = new UretimlerForm();
            uretimlerForm.Show();
        }

        private void BtnSiparis_Click(object sender, EventArgs e)
        {
            SiparislerForm siparislerForm = new SiparislerForm();
            siparislerForm.Show();
        }

        private void BtnKesim_Click(object sender, EventArgs e)
        {
            KesimForm kesimForm = new KesimForm();
            kesimForm.Show();
        }

        private void BtnDelik_Click(object sender, EventArgs e)
        {
            DelimForm delimForm = new DelimForm();
            delimForm.Show();
        }

        private void BtnTemizlik_Click(object sender, EventArgs e)
        {
            TemizlemeForm temizlemeForm = new TemizlemeForm();
            temizlemeForm.Show();
        }

        private void BtnFirin_Click(object sender, EventArgs e)
        {
            FirinForm firinForm = new FirinForm();
            firinForm.Show();
        }

        private void BtnLamine_Click(object sender, EventArgs e)
        {
            LamineForm lamineForm = new LamineForm();
            lamineForm.Show();
        }

        private void BtnRodaj_Click(object sender, EventArgs e)
        {
            RodajForm rodajForm = new RodajForm();
            rodajForm.Show();
        }

        private void BtnPaket_Click(object sender, EventArgs e)
        {
            PaketlemeForm paketlemeForm = new PaketlemeForm();
            paketlemeForm.Show();
        }

    }
}
