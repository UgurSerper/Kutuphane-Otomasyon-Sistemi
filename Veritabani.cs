using System;
using System.Collections.Generic;
using System.Text;

using System.Data;
using Microsoft.Data.SqlClient;

namespace Kutuphane_Otomasyonu
{
    internal class Veritabani
    {
        public static string baglantiCumlesi = @"Server=.\SQLEXPRESS; Database=KutuphaneDB; Trusted_Connection=True; TrustServerCertificate=True;";

        public static void KitapEkle(string adi, string yazarAdi, string yazarSoyadi, int sayfaSayisi)
        {

            using (SqlConnection baglanti = new SqlConnection(baglantiCumlesi))
            {
                baglanti.Open();

                string sorgu = "INSERT INTO Kitaplar (Adi, YazarAdi, YazarSoyadi, SayfaSayisi, KutuphaneDeMi) " +
                               "VALUES (@adi, @yazarAdi, @yazarSoyadi, @sayfaSayisi, 1)";

                using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                {
                    komut.Parameters.AddWithValue("@adi", adi);
                    komut.Parameters.AddWithValue("@yazarAdi", yazarAdi);
                    komut.Parameters.AddWithValue("@yazarSoyadi", yazarSoyadi);
                    komut.Parameters.AddWithValue("@sayfaSayisi", sayfaSayisi);

                    komut.ExecuteNonQuery();
                }
            }
        }

        public static DataTable TumKitaplariGetir()
        {
            DataTable dt = new DataTable();

            using (SqlConnection baglanti = new SqlConnection(baglantiCumlesi))
            {
                baglanti.Open();
                using (SqlCommand komut = new SqlCommand("SELECT * FROM Kitaplar", baglanti))
                {
                    using (SqlDataReader dr = komut.ExecuteReader())
                    {
                        dt.Load(dr);
                    }
                }
            }
            return dt;
        }

        public static DataTable TumUyeleriGetir()
        {
            DataTable dt = new DataTable();

            using (SqlConnection baglanti = new SqlConnection(baglantiCumlesi))
            {
                baglanti.Open();
                using (SqlCommand komut = new SqlCommand("SELECT UyeID, UyeAdi + ' ' + UyeSoyadi AS AdSoyad FROM Uyeler", baglanti))
                {
                    using (SqlDataReader dr = komut.ExecuteReader())
                    {
                        dt.Load(dr);
                    }
                }
            }
            return dt;
        }

        public static DataTable OduncListesiGetir()
        {
            DataTable dt = new DataTable();

            using (SqlConnection baglanti = new SqlConnection(baglantiCumlesi))
            {
                baglanti.Open();

                // Üye adını, kitap adını ve tarihleri tek bir tabloda birleştiriyoruz
                string sorgu = @"SELECT 
                            o.IslemID,
                            u.UyeAdi + ' ' + u.UyeSoyadi AS [Üye Ad Soyad],
                            k.Adi AS [Kitap Adı],
                            o.VerilisTarihi AS [Veriliş Tarihi],
                            o.SonTeslimTarihi AS [Son Teslim Tarihi],
                            o.IadeEdildiMi AS [İade Durumu]
                         FROM OduncVerilenler o
                         INNER JOIN Uyeler u ON o.UyeID = u.UyeID
                         INNER JOIN Kitaplar k ON o.KitapID = k.KitapID
                         WHERE o.IadeEdildiMi = 0"; // Sadece iade edilmeyenleri (aktif ödünçleri) getiriyoruz

                using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                {
                    using (SqlDataReader dr = komut.ExecuteReader())
                    {
                        dt.Load(dr);
                    }
                }
            }
            return dt;
        }

        public static void OduncVer(int kitapId, int uyeId, DateTime verilisTarihi, DateTime sonTeslimTarihi)
        {
            using (SqlConnection baglanti = new SqlConnection(baglantiCumlesi))
            {
                baglanti.Open();
                string sorgu = "INSERT INTO OduncVerilenler (KitapID, UyeID, VerilisTarihi, SonTeslimTarihi, IadeEdildiMi) VALUES (@kitapId, @uyeId, @verilis, @sonTeslim, 0)";

                using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                {
                    komut.Parameters.AddWithValue("@kitapId", kitapId);
                    komut.Parameters.AddWithValue("@uyeId", uyeId);
                    komut.Parameters.AddWithValue("@verilis", verilisTarihi);
                    komut.Parameters.AddWithValue("@sonTeslim", sonTeslimTarihi);

                    komut.ExecuteNonQuery();
                }
            }
        }

        public static void IadeAl(int islemId)
        {
            using (SqlConnection baglanti = new SqlConnection(baglantiCumlesi))
            {
                baglanti.Open();

                string sorgu = "UPDATE OduncVerilenler SET IadeEdildiMi = 1 WHERE IslemID = @islemId";

                using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                {
                    komut.Parameters.AddWithValue("@islemId", islemId);
                    komut.ExecuteNonQuery();
                }
            }
        }

    }
}
