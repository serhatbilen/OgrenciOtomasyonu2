using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230908_1_GenelAlistirma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ÖĞRENCİ TAKİP OTOMASYONU
            // -----------------------
            // 1- Öğrenci Ekle
            // 2- Öğrenci Listele
            // 3- Öğrenci Sil
            // 4- Öğrencilerin Genel Not Ortalaması
            // 5- Öğrencilerin Yaş Ortalaması
            // 6- Toplam Öğrenci Sayısı
            // 0- Çıkış
            // Bir Seçim Yapınız: 


            ConsoleKey cevap;
            do
            {
                Console.Clear();
                Console.WriteLine("ÖĞRENCİ KAYIT OTOMASYONU");
                Console.WriteLine("------------------------");
                Console.WriteLine("1- Öğrenci Ekle");
                Console.WriteLine("2- Öğrencileri Listele");
                Console.WriteLine("3- Öğrenci Sil");
                Console.WriteLine("4- Öğrencileri Genel Not Ortalaması");
                Console.WriteLine("5- Öğrencilerin Yaş Ortalaması");
                Console.WriteLine("6- Toplam Öğrenci Sayısı");
                Console.WriteLine("0- Çıkış");
                Console.WriteLine();

                Console.Write("Hangi İşlemi Yapmak İstersiniz? ");
                cevap = Console.ReadKey().Key;
                Menu.Islemler(cevap);
            } while (cevap != ConsoleKey.NumPad0 && cevap != ConsoleKey.D0);


            Console.Clear();
            Console.WriteLine("Programı Kullandığınız İçin Teşekkür Ederiz");
            Console.WriteLine("Kapatmak İçin Bir Tuşa Basınız");


            Console.ReadKey();
        }
    }
}
