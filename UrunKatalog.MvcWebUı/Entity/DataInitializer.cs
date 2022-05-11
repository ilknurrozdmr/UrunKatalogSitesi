using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace UrunKatalog.MvcWebUı.Entity
{
    public class DataInitializer:DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var kategoriler = new List<Category>()
            {
                new Category(){Name="Kamera",Description="Kamera Ürünleri"},
                new Category(){Name="Bilgisayar",Description="Bilgisayar Ürünleri"},
                new Category(){Name="Elektronik",Description="Elektronik Ürünleri"},
                new Category(){Name="Telefon",Description="Telefon Ürünleri"},
                new Category(){Name="Beyaz Eşya",Description="Beyaz Eşya Ürünleri"}
            };
            foreach (var kategori in kategoriler)
            {
                context.Categories.Add(kategori);
            }
            context.SaveChanges();

            var urunler = new List<Product>()
            {
                new Product(){Name="Canon Eos 2000D 18-55 mm Dc III Fotoğraf Makinesi", Description="24.1 MP, Wi-Fi Özellikli", Price=5800, Stock=10, IsApproved=true, CategoryId=1, Image="2.jpg" },
                new Product(){Name="Panasonic Lumix DMC-FZ82 Fotoğraf Makinesi", Description="18.9 MP, Çözzünürlük= 4896x3672", Price=6335, Stock=5, IsApproved=true, CategoryId= 1, Image="3.jpg"},
                new Product(){Name="DEİLMİ Hd Kamera Çocuklar Için Dijital Fotoğraf Makinesi", Description="Ekran 2.0 inç, 1080p HD Kamera", Price=225, Stock=10, IsApproved=true, CategoryId= 1, IsHome=true, Image="4.jpg"},
                new Product(){Name="Dijital SLR Fotoğraf Makinesi", Description="16 MP, Ekran 2.4 inç", Price=524, Stock=12, IsApproved=true, CategoryId= 1, Image="5.jpg"},

                new Product(){Name="ASUS Laptop X515ja-br1968t I3-1005g", Description="1 4gb Ram 256gb Ssd 15.6 inç W10", Price=5360, Stock=30, IsApproved=true, CategoryId=2, IsHome=true, Image="1.jpg"},
                new Product(){Name="Casper Nirvana X400.1065-8V00X-S-F", Description="Intel i7 1065G7 8 GB RAM 500 GB NVME SSD 14.1 inç", Price=9800, Stock=10, IsApproved=true, CategoryId=2, Image="2.jpg"},
                new Product(){Name="Casper Excalibur G780.1030-8VJ0X-B i5 10300H", Description="8GB 500GB Nvme SSD GTX1650Ti FreeDos 16.6 inç", Price=8520, Stock=2, IsApproved=true, CategoryId= 2, Image="3.jpg"},
                new Product(){Name="Macbook Air ", Description="12 inç, Intel Core M, 256 GB, Ultra ince", Price=11800, Stock=50, IsApproved=true, CategoryId= 2, Image="4.jpg"},
                new Product(){Name="Huawei Matebook D15", Description="Intel Core İ5 10210u 8gb 256gb Ssd Windows 10 Home", Price=12000, Stock=40, IsApproved=true, CategoryId= 2, IsHome=true, Image="5.jpg"},

                new Product(){Name="Powermaster PM-2857 Tv Monitör Üstü Stand", Description=" Boyut : 33.8x16 2x2 5cm. Ağırlık : 162G Maksimum Taşıma Kapasitesi: 2000g - 3000g Renk : Siyah", Price=90, Stock=4, IsApproved=true, CategoryId=3,IsHome=true, Image="1.jpg"},
                new Product(){Name="Karaca Hatır Plus Mod 5 In 1 Kahve Ve Çay Makinesi", Description="Hatır Plus Mod 1385 Watt güce sahiptir. 5 fincan kapasitelidir.", Price=1900, Stock=60, IsApproved=true, CategoryId= 3, IsHome=true, Image="2.jpg"},
                new Product(){Name="Dijital Terazi", Description="5 kg tartım aralığı", Price=125, Stock=300, IsApproved=true, CategoryId= 3, IsHome=true, Image="3.jpg"},
                new Product(){Name="Sem Aircook Sc300 Yağsız Fritöz", Description="Daha Az Yağlı Kızartma, 5 litrelik geniş iç hacmiyle tek seferde kalabalık gruplara yetecek kadar patates kızartması servis eder.", Price=2400, Stock=120, IsApproved=true, CategoryId= 3, IsHome=true, Image="4.jpg"},
                new Product(){Name="Haylou LS02 Akıllı Saat", Description="Yükseltilmiş Şarj Süresi Smart Watch 2, 20 günlük uzun ömürlü Yüksek performanslı 260mAh pil kapasiteli tasarlandı.Optimize edilmiş güç tüketimi yönetimi ve sistem enerji tasarrufu. Aynı zamanda kısa devre önleyici çip ile bütün gün endişelenmeden kullanabilirsiniz.", Price=430, Stock=4, IsApproved=true, CategoryId= 3, Image="5.jpg"},

                new Product(){Name="iPhone 13 Pro Max", Description="6.7 inç, Face ID, 5G Özellikli", Price=30000, Stock=500, IsApproved=true, CategoryId= 4, IsHome=true, Image="1.jpg"},
                new Product(){Name="Huawei P20 Lite", Description="5.5 inç, 4G, 1920x1080", Price=3000, Stock=200, IsApproved=true, CategoryId= 4, Image="2.jpg"},
                new Product(){Name="Xiaomi Mi 11 Lite 6", Description="128 gb, 4G, OLED Ekranlı, Çift SIM'li", Price=7850, Stock=90, IsApproved=true, CategoryId= 4, IsHome=true, Image="3.jpg"},
                new Product(){Name="Galaxy S22 Ultra", Description="Dinamik AMOLED 2x ekran, 1750 nit'e kadar yüksek parlaklık ile açık hava görünürlüğünü artırır. Super Steady, kamera sarsıntısını geniş bir açı yakalayarak düzeltir.", Price=25999, Stock=900, IsApproved=true, CategoryId= 4, Image="4.jpg"},
                new Product(){Name="Casper Via E-4", Description="32 GB, Ram 3 GB", Price=3300, Stock=250, IsApproved=true, CategoryId= 4, Image="5.jpg"},
                
            };

            foreach (var urun in urunler)
            {
                context.Products.Add(urun);
            }
            context.SaveChanges();

            base.Seed(context);
        }
    }
}