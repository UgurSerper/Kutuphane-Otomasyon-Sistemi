using System.Data;

namespace Kutuphane_Otomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridViewKitaplar.DataSource = Veritabani.TumKitaplariGetir();
            dataGridViewKitaplar.ForeColor = Color.Black;
            dataGridViewOduncAlanlar.DataSource = Veritabani.OduncListesiGetir();
            dataGridViewOduncAlanlar.ForeColor = Color.Black;
            dgvTakip.ForeColor = Color.Black;

            DataTable uyelerTablosu = Veritabani.TumUyeleriGetir();
            DataTable kitaplarTablosu = Veritabani.TumKitaplariGetir();

            listBoxUyeler.DataSource = uyelerTablosu;
            listBoxKitaplar.DataSource = kitaplarTablosu;

            listBoxUyeler.DisplayMember = "AdSoyad";
            listBoxUyeler.ValueMember = "UyeID";

            listBoxKitaplar.DisplayMember = "Adi";
            listBoxKitaplar.ValueMember = "KitapID";

            TakipListesiniYenile();
        }

        private void buttonKitapEkle_Click(object sender, EventArgs e)
        {
            Veritabani.KitapEkle(textBoxKitapAdi.Text, textBoxYazarAdi.Text, textBoxYazarSoyadi.Text, Convert.ToInt32(numericUpDownSayfaSayisi.Value));
        }

        private void buttonOduncVer_Click(object sender, EventArgs e)
        {
            if (listBoxKitaplar.SelectedValue == null || listBoxUyeler.SelectedValue == null)
            {
                MessageBox.Show("Lütfen listeden hem bir üye hem de bir kitap seçtiğinizden emin olun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int secilenUye = Convert.ToInt32(listBoxUyeler.SelectedValue);
            int secilenKitap = Convert.ToInt32(listBoxKitaplar.SelectedValue);

            DateTime bugun = DateTime.Now;

            DateTime teslimTarihi = DateTime.Now.AddDays(14);

            Veritabani.OduncVer(secilenKitap, secilenUye, bugun, teslimTarihi);

        }

        private void TakipListesiniYenile()
        {
            dgvTakip.DataSource = Veritabani.OduncListesiGetir();

            foreach (DataGridViewRow row in dgvTakip.Rows)
            {
                if (row.Cells["Son Teslim Tarihi"].Value == null) continue;

                DateTime sonTeslim = Convert.ToDateTime(row.Cells["Son Teslim Tarihi"].Value);
                DateTime bugun = DateTime.Now;
                TimeSpan kalanSure = sonTeslim - bugun;
                double kalanGun = kalanSure.TotalDays;
                if (kalanGun < 0)
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                    row.DefaultCellStyle.ForeColor = Color.White;
                }
                else if (kalanGun <= 3)
                {
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }
            }
        }

        private void buttonIadeAl_Click(object sender, EventArgs e)
        {
            if (dgvTakip.CurrentRow == null)
            {
                MessageBox.Show("Lütfen iade etmek istediğiniz işlemi tablodan seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int secilenIslemId = Convert.ToInt32(dgvTakip.CurrentRow.Cells["IslemID"].Value);

            Veritabani.IadeAl(secilenIslemId);

            MessageBox.Show("Kitap başarıyla iade alındı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            TakipListesiniYenile();
        }
    }
}
