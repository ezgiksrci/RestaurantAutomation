using RestaurantAutomation.Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantAutomation.UI.Forms
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void OrderScreen_Load(object sender, EventArgs e)
        {
            //GetAllIcicekler
            //GetAllYemekler

            //yiyecek yada içecek

            //var result = productRepo.GetProductCategory(categoryId);
            //lits->ekmek(count payment),kebap(count payment)
            ////yiyecekler / içecekler

            //for (int i = 0; i < result.count; i++)
            //{
            //    //lokasyon büyüklük name text
            //    Button button = new Button();
            //    button.Name = Button + result[i].Name;
            //}

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowProductsInCategory("Startes");
        }

        private void ShowProductsInCategory(string category)
        {
            List<Urun> urunler = VeriKaynagindanUrunleriGetir(category);


            // Yeni form oluştur
            Form urunlerForm = new Form();
            urunlerForm.Text = category + " Ürünleri";
            urunlerForm.Size = new Size(500, 400);
            urunlerForm.StartPosition = FormStartPosition.CenterScreen;


            // FlowLayoutPanel oluştur
            FlowLayoutPanel flowPanel = new FlowLayoutPanel();
            flowPanel.Dock = DockStyle.Fill;
            flowPanel.AutoScroll = true;
            urunlerForm.Controls.Add(flowPanel);

            foreach (var urun in urunler)
            {
                Button btnUrun = new Button();
                btnUrun.Size = new Size(150, 80);
                btnUrun.Text = urun.UrunAdi + "\n" + urun.Fiyat.ToString("C2");
                btnUrun.Tag = urun;

                // Buton tıklama olayı
                btnUrun.Click += (sender, e) =>
                {
                    // Ürünü sepete ekle
                    dataGridView1.Rows.Add(" ", urun.UrunAdi, "1", urun.Fiyat, urun.Fiyat, DateTime.Now);

                    // İsterseniz bir bildirim göster
                    MessageBox.Show(urun.UrunAdi + " siparişe eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // İstenirse formu kapat (veya açık bırak)
                    urunlerForm.Close();
                };

                // Butonu panele ekle
                flowPanel.Controls.Add(btnUrun);
            }
            urunlerForm.Show();
        }

        private List<Urun> VeriKaynagindanUrunleriGetir(string category)
        {
            // Bu kısım veritabanı bağlantısı ile değiştirilecek
            List<Urun> urunler = new List<Urun>();

            // Örnek veriler
            if (category == "Startes")
            {
                urunler.Add(new Urun { UrunID = 1, UrunAdi = "Mercimek Çorbası", Fiyat = 25.00m });
                urunler.Add(new Urun { UrunID = 2, UrunAdi = "Ezogelin Çorbası", Fiyat = 25.00m });
                urunler.Add(new Urun { UrunID = 3, UrunAdi = "Akdeniz Salata", Fiyat = 30.00m });
                urunler.Add(new Urun { UrunID = 4, UrunAdi = "Karışık Meze Tabağı", Fiyat = 45.00m });
            }
            else if (category == "Main Courses")
            {
                urunler.Add(new Urun { UrunID = 5, UrunAdi = "Adana Kebap", Fiyat = 85.00m });
                urunler.Add(new Urun { UrunID = 6, UrunAdi = "Karışık Izgara", Fiyat = 95.00m });
                urunler.Add(new Urun { UrunID = 7, UrunAdi = "Tavuk Şiş", Fiyat = 75.00m });
                urunler.Add(new Urun { UrunID = 8, UrunAdi = "Patlıcan Kebabı", Fiyat = 80.00m });
            }
            else if (category == "Desserts")
            {
                urunler.Add(new Urun { UrunID = 9, UrunAdi = "Baklava", Fiyat = 35.00m });
                urunler.Add(new Urun { UrunID = 10, UrunAdi = "Sütlaç", Fiyat = 25.00m });
                urunler.Add(new Urun { UrunID = 11, UrunAdi = "Kazandibi", Fiyat = 25.00m });
            }
            else if (category == "Beverages")
            {
                urunler.Add(new Urun { UrunID = 12, UrunAdi = "Ayran", Fiyat = 10.00m });
                urunler.Add(new Urun { UrunID = 13, UrunAdi = "Kola", Fiyat = 15.00m });
                urunler.Add(new Urun { UrunID = 14, UrunAdi = "Türk Kahvesi", Fiyat = 20.00m });
                urunler.Add(new Urun { UrunID = 15, UrunAdi = "Çay", Fiyat = 8.00m });
            }

            return urunler;
        }

        // Ürün sınıfı tanımı
        public class Urun
        {
            public int UrunID { get; set; }
            public string UrunAdi { get; set; }
            public decimal Fiyat { get; set; }

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex>=0)
            { 
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this item?", "Delete Item", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Red;                  
                    dgwCancel.FlatStyle = FlatStyle.Flat;
                    dataGridView1.CurrentCell.Style.BackColor= Color.Red;
                    dataGridView1.Rows[e.RowIndex].Cells["dgwProductName"].Value = "Silindi";
                    dataGridView1.Rows[e.RowIndex].Cells["Column1"].Value = "0";
                }                  
            }
        }
    }
}

