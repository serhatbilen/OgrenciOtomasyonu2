using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230908_1_GenelAlistirma
{
    public static class Metodlar
    {
        public static string GetString(string metin, int min = 1, int max = 500) // "Öğrenci Adı: ", 2, 15
        {
            string txt = string.Empty;
            bool hata = false;
            do
            {
                Console.Write(metin); 
                txt = Console.ReadLine();
                if (string.IsNullOrEmpty(txt))
                {
                    Console.WriteLine("Boş Bir Değer Giremezsiniz");
                    hata = true;
                }
                else
                {
                    if (txt.Length < min || txt.Length > max)
                    {
                        Console.WriteLine("Lütfen min. {0}, max. {1} uzunlukta metin giriniz", min,max);
                        hata = true;
                    }
                    else if (!IsOnlyLetters(txt))
                    {
                        Console.WriteLine("Lütfen sadece harf kullanının");
                        hata = true;
                    }
                    else
                    {
                        hata = false;
                    }
                }
            } while (hata);
            return txt;
        }

        private static bool IsOnlyLetters(string txt)
        {
            foreach (var item in txt)
            {
                if (!char.IsLetter(item))
                {
                    return false;
                }
            }
            return true;
        }

        public static int GetInt(string metin, int min = int.MinValue, int max = int.MaxValue)
        {
            int sayi = 0;
            bool hata = false;
            do
            {
                Console.Write(metin);
                try
                {
                    sayi = int.Parse(Console.ReadLine());
                    if (sayi >= min && sayi <= max)
                    {
                        hata = false;
                    }
                    else
                    {
                        Console.WriteLine("Lütfen {0} ile {1} arasında bir değer giriniz", min, max);
                        hata = true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    hata = true;
                }
            } while (hata);
            return sayi;
        }

        public static double GetDouble(string metin, double min = double.MinValue, double max = double.MaxValue)
        {
            double sayi = 0;
            bool hata = false;
            do
            {
                Console.Write(metin);
                try
                {
                    sayi = double.Parse(Console.ReadLine());
                    if (sayi >= min && sayi <= max)
                    {
                        hata = false;
                    }
                    else
                    {
                        Console.WriteLine("Lütfen min. {0}, max {1} aralığında değer giriniz");
                        hata = true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    hata = true;
                }
            } while (hata);
            return sayi;
        }

        public static DateTime GetDateTime(string metin, int minYear, int maxYear)
        {
            DateTime date = DateTime.Now;
            bool hata = false;
            do
            {
                Console.Write(metin);
                try
                {
                    date = DateTime.Parse(Console.ReadLine());
                    if (date.Year >= minYear && date.Year <= maxYear)
                    {
                        hata = false;
                    }
                    else
                    {
                        Console.WriteLine("Lütfen min. {0}, max. {1} yılları arasında bir tarih giriniz");
                        hata = true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    hata = true;
                }
            } while (hata);
            return date;
        }
    }
}
