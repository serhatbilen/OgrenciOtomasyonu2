using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230908_1_GenelAlistirma
{
    public static class Menu
    {
        static List<Ogrenci> ogrenciler = new List<Ogrenci>();
        public static void Islemler(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.NumPad1:
                case ConsoleKey.D1:
                    Ekle("ÖĞRENCİ EKLE");
                    break;
                case ConsoleKey.NumPad2:
                case ConsoleKey.D2:
                    Listele("ÖĞRENCİLERİ LİSTELE");
                    break;
                case ConsoleKey.NumPad3:
                case ConsoleKey.D3:
                    Sil("ÖĞRENCİ SİL");
                    break;
                case ConsoleKey.NumPad4:
                case ConsoleKey.D4:
                    Ortalama("GENEL NOT ORTALAMASI");
                    break;
                case ConsoleKey.NumPad5:
                case ConsoleKey.D5:
                    YasOrtalamasi("ÖĞRENCİLERİN YAŞ ORTALAMASI");
                    break;
                case ConsoleKey.NumPad6:
                case ConsoleKey.D6:
                    BaslikYazdir("TOPLAM ÖĞRENCİ SAYISI");
                    AnaMenuyeDon(string.Format("Toplam {0} öğrenci kayıtlıdır", ogrenciler.Count));
                    break;
            }
        }

        private static void YasOrtalamasi(string v)
        {
            if (ogrenciler.Any())
            {
                BaslikYazdir(v);
                int toplamYas = 0;
                foreach (var item in ogrenciler)
                {
                    toplamYas += item.Yas;
                }
                double yasOrtalamasi = (double)toplamYas/ogrenciler.Count;
                AnaMenuyeDon(string.Format("Toplam {0} öğrencinin yaş ortalaması {1}", ogrenciler.Count, Math.Round(yasOrtalamasi, 2)));
            }
            else
            {
                AnaMenuyeDon("Listede Öğrenci Bulunamadı");
            }
        }

        private static void Ortalama(string v)
        {
            BaslikYazdir(v);
            if (ogrenciler.Any())
            {
                double genelToplam = 0;
                foreach (var item in ogrenciler)
                {
                    genelToplam += item.Ortalama;
                }
                double genelOrtalama = genelToplam / ogrenciler.Count;
                AnaMenuyeDon(string.Format("Toplam {0} öğrencinin not ortalaması {1}", ogrenciler.Count, Math.Round(genelOrtalama, 2)));
            }
            else
            {
                AnaMenuyeDon("Listede öğrenci bulunamadı");
            }
        }

        private static void Sil(string v)
        {
            BaslikYazdir(v);
            if (ogrenciler.Any())
            {
                for (int i = 0; i < ogrenciler.Count; i++)
                {
                    ogrenciler[i].Yazdir(i + 1);
                }
                Console.WriteLine();
                int siraNo = Metodlar.GetInt("Silmek istediğiniz öğrencinin sıra numarasını giriniz\nAna menüye dönmek için 0'a basınız",0, ogrenciler.Count);
                if (siraNo == 0)
                {
                    AnaMenuyeDon("Silme işlemi iptal edildi");
                }
                else
                {
                    int indexNo = siraNo- 1;
                    Console.Write(ogrenciler[indexNo].TamAd + " öğrencisini silmek istediğinize emin misiniz?(e) ");
                    if (Console.ReadKey().Key == ConsoleKey.E)
                    {
                        string silinen = ogrenciler[indexNo].TamAd;
                        ogrenciler.RemoveAt(indexNo);
                        AnaMenuyeDon(string.Format("{0} öğrencisi başarı ile silinmiştir", silinen));
                    }
                    else
                    {
                        AnaMenuyeDon("Silme işlemi iptal edildi");
                    }
                }
            }
            else
            {
                AnaMenuyeDon("Listede öğrenci bulunamadı");
            }
        }

        private static void Listele(string v)
        {
            #region Any() Metodu
            // Any() metodu koleksiyonlarda değer var mı? yok mu? kontrolünü yapar geriye bool tipinde bir değer döndürür. Değer varsa "true" yoksa"false" döndürür. 
            #endregion
            if (ogrenciler.Any()) // ogrenciler.Count > 0
            {
                BaslikYazdir(v);
                for (int i = 0; i < ogrenciler.Count; i++)
                {
                    ogrenciler[i].Yazdir(i + 1);
                }
                AnaMenuyeDon(string.Format("Toplam {0} adet öğrenci listelenmiştir", ogrenciler.Count));
            }
            else
            {
                AnaMenuyeDon("Listede öğrenci bulunamadı");
            }
        }

        private static void Ekle(string v)
        {
            BaslikYazdir(v);
            Ogrenci o = new Ogrenci();
            o.Ad = Metodlar.GetString("Öğrenci Adı: ", 2, 15);
            o.Soyad = Metodlar.GetString("Öğrenci Soyadı: ", 2, 15);
            o.N1 = Metodlar.GetDouble("1. Not: ", 0, 100);
            o.N2 = Metodlar.GetDouble("2. Not: ", 0, 100);
            o.DogumTarihi = Metodlar.GetDateTime("Doğum Tarihi(GG.AA.YYYY): ", 1998, 2006);
            ogrenciler.Add(o);
            AnaMenuyeDon(string.Format("{0} öğrencisi listeye başarı ile eklendi", o.TamAd));
        }

        private static void AnaMenuyeDon(string v)
        {
            Console.WriteLine();
            Console.WriteLine(v);
            Console.WriteLine("Ana Menüye Dönmek İçin Bir Tuşa Basınız");
            Console.ReadKey();
        }

        private static void BaslikYazdir(string v)
        {
            Console.Clear();
            Console.WriteLine(v);
            Console.WriteLine("----------------------");
            Console.WriteLine();
        }
    }
}
