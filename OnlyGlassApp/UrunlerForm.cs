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
    public partial class UrunlerForm : Form
    {
        public UrunlerForm()
        {
            InitializeComponent();
        }

        public void VeriDoldur()
        {
            string sec = "SELECT UrunNo,UrunAdi,UrunRengi,UrunTipi,UrunModeli,UrunOzellik,UrunMM,UrunEbat FROM Urunler_Tablosu";
            DGVUrunler.DataSource = VtIslem.VeriGetir(sec);
        }
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            string urunAdi = TBoxUrunAdi.Text;
            string urunRengi = CBoxUrunRengi.Text;
            string urunTipi = TBoxUrunTipi.Text;
            string urunModeli = CBoxUrunModeli.Text;
            string urunOzellik = CBoxUrunOzellik.Text;
            decimal urunMM = Convert.ToDecimal(CBoxUrunMM.Text);
            string urunEbat = CBoxUrunEbat.Text;

            string komut = "INSERT INTO Urunler_Tablosu (UrunAdi,UrunRengi,UrunTipi,UrunModeli,UrunOzellik,UrunMM,UrunEbat) " +
                "VALUES (@UrunAdi,@UrunRengi,@UrunTipi,@UrunModeli,@UrunOzellik,@UrunMM,@UrunEbat)";
            VtIslem.command.Parameters.Clear();
            VtIslem.command.Parameters.AddWithValue("@UrunAdi", urunAdi);
            VtIslem.command.Parameters.AddWithValue("@UrunRengi", urunRengi);
            VtIslem.command.Parameters.AddWithValue("@UrunTipi", urunTipi);
            VtIslem.command.Parameters.AddWithValue("@UrunModeli", urunModeli);
            VtIslem.command.Parameters.AddWithValue("@UrunOzellik", urunOzellik);
            VtIslem.command.Parameters.AddWithValue("@UrunMM", urunMM);
            VtIslem.command.Parameters.AddWithValue("@UrunEbat", urunEbat);
            VtIslem.KomutCalistir(komut);

            if (VtIslem.affectedRows > 0)
            {
                MessageBox.Show("Ürün kaydedildi.");
                TBoxUrunAdi.Clear();
                TBoxUrunTipi.Clear();
                CBoxUrunEbat.Items.Clear();
                CBoxUrunMM.Items.Clear();
                CBoxUrunModeli.Items.Clear();
                CBoxUrunOzellik.Items.Clear();
                CBoxUrunRengi.Items.Clear();
                VeriDoldur();
            }
            else
            {
                MessageBox.Show("Ürün kaydedilemedi. Lütfen tekrar deneyin.");
            }
            VeriDoldur();
        }

        private void UrunlerForm_Load(object sender, EventArgs e)
        {
            VeriDoldur();
            BtnGuncelle.Enabled = false;
            TBoxToplamUrun.Text = DGVUrunler.RowCount.ToString();
        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BtnKaydet.Enabled = false;
            TBoxUrunAdi.Text = DGVUrunler.CurrentRow.Cells[1].Value.ToString();
            CBoxUrunRengi.Text = DGVUrunler.CurrentRow.Cells[2].Value.ToString();
            TBoxUrunTipi.Text = DGVUrunler.CurrentRow.Cells[3].Value.ToString();
            CBoxUrunModeli.Text = DGVUrunler.CurrentRow.Cells[4].Value.ToString();
            CBoxUrunOzellik.Text = DGVUrunler.CurrentRow.Cells[5].Value.ToString();
            CBoxUrunMM.Text = DGVUrunler.CurrentRow.Cells[6].Value.ToString();
            CBoxUrunEbat.Text = DGVUrunler.CurrentRow.Cells[7].Value.ToString();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            string komut = "UPDATE Urunler_Tablosu SET UrunAdi = '"+TBoxUrunAdi.Text+"', UrunRengi = '"+CBoxUrunRengi.Text+"'" +
                "UrunTipi = '"+TBoxUrunTipi.Text+"', UrunModeli= '"+CBoxUrunModeli.Text+"', UrunOzellik= '"+CBoxUrunOzellik.Text+"'" +
                "UrunMM= '"+CBoxUrunMM.Text+"', UrunEbat= '"+CBoxUrunEbat.Text+"' WHERE UrunNo = '"+ Convert.ToInt16(TBoxUrunNo.Text) + "'";
            VtIslem.KomutCalistir(komut);

            if (VtIslem.affectedRows > 0)
            {
                MessageBox.Show("Ürün güncellendi.");
                TBoxUrunAdi.Clear();
                TBoxUrunTipi.Clear();
                CBoxUrunEbat.Items.Clear();
                CBoxUrunMM.Items.Clear();
                CBoxUrunModeli.Items.Clear();
                CBoxUrunOzellik.Items.Clear();
                CBoxUrunRengi.Items.Clear();
                VeriDoldur();
            }
            else
            {
                MessageBox.Show("Ürün güncellenemedi. Lütfen tekrar deneyin.");
            }
            VeriDoldur();
            BtnGuncelle.Enabled = false;
            BtnKaydet.Enabled = true;
        }
    }
}
