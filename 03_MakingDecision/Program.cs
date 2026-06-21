using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region If Else

            //Console.Write("Password: ");
            //String password;
            //password = Console.ReadLine();

            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre Doğru");

            //} 
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}


            // -----------------------------------------


            //string capital, country;

            //Console.Write("Başkenti Giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi Giriniz: ");
            //country = Console.ReadLine();

            //if (capital == "ankara" & country == "türkiye")
            //{
            //    Console.WriteLine("Veriler Doğrulandı.");
            //}
            //else
            //{
            //    Console.WriteLine("Veriler Doğrulanamadı.");
            //}


            // ----------------------------------------------


            //int number;
            //Console.Write("Bir sayı giriniz: ");
            //number = int.Parse(Console.ReadLine());

            //if (number == 5)
            //{
            //    Console.WriteLine("Sayı DOĞRU");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı YANLIŞ");
            //}
            //


            // ----------------------------------------------


            //double mid1, mid2, final, average;
            //string result;

            //Console.Write("1. Vize Notunu Giriniz: ");
            //mid1 = double.Parse(Console.ReadLine());

            //Console.Write("2. Vize Notunu Giriniz: ");
            //mid2 = double.Parse(Console.ReadLine());

            //Console.Write("Final Notunu Giriniz: ");
            //final = double.Parse(Console.ReadLine());

            //average = (mid1 * 0.3) + (mid2 * 0.3) + (final * 0.4);

            //if (average >= 90)
            //{
            //    result = "AA";
            //}
            //else if (average >= 80)
            //{
            //    result = "BA";
            //}
            //else if (average >= 70)
            //{
            //    result = "BB";
            //}
            //else if (average >= 60)
            //{
            //    result = "CB";
            //}
            //else if (average >= 50)
            //{
            //    result = "CC";
            //}
            //else if (average >= 40)
            //{
            //    result = "DC";
            //}
            //else if (average >= 30)
            //{
            //    result = "DD";
            //} 
            //else
            //{
            //    result = "FF";
            //}

            //Console.WriteLine("Ortalamanız: " + average + ". Harf notunuz: " +result);


            // ----------------------------------------------


            //string city;
            //Console.Write("Bir şehir ismi giriniz: ");
            //city = Console.ReadLine();

            //if (city == "adana" || city == "adana" || city =="bursa" || city == "trabzon")
            //{
            //    Console.Write("şehir mevcut");
            //} else
            //{
            //    Console.Write("şehir mevcut değil");
            //}


            // ----------------------------------------------


            //Console.Write("Lütfen Kullanıcı Adınızı Giriniz: ");
            //string username;
            //username = Console.ReadLine();

            //if (username != "admin")
            //{
            //    Console.WriteLine("Bu Kullanıcı Adı ile Giriş Yapılamaz.");
            //}
            //else
            //{
            //    Console.WriteLine("Hoş geldiniz.");
            //}

            #endregion

            #region Mod İşlemleri

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);


            // ----------------------------------------------


            //Console.Write("Lütfen 1. sayıyı giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. sayıyı giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int reaminder = number1 % number2;

            //Console.WriteLine("1. sayının 2. sayıya bölümünden kalan: " + reaminder);


            // ----------------------------------------------


            //Console.Write("Lütfen bir sayı giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("Girdiğiniz sayı Çift");
            //}
            //else
            //{
            //    Console.WriteLine("Girdiğiniz sayı Tek");
            //}
            #endregion

            #region Char Değişkenler ile Karar Yapıları
            // ----------------------------------------------


            //char team;
            //Console.Write("Takımınızın baş harfini giriniz: ");
            //team = char.Parse(Console.ReadLine());

            //if (team == 'F' || team == 'f')
            //{
            //    Console.WriteLine("Fenerbahçe");
            //}
            //else if (team == 'B' || team == 'b')
            //{
            //    Console.WriteLine("Beşiktaş");
            //}
            //else if (team == 'G' || team == 'g')
            //{
            //    Console.WriteLine("Galatasaray");
            //}
            //else
            //{
            //    Console.WriteLine("Böyle bir takım yok.");
            //}
            #endregion

            #region Örnek Proje Uygulaması
            //Console.WriteLine("****** C# Eğitim Kampı Restoran ******");
            //Console.WriteLine();
            //Console.WriteLine("---------------------------------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("---------------------------------------");
            //Console.WriteLine();

            //string menuItem;
            //Console.Write("Detayını görmek istediğiniz menü seçimi: ");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Ana Yemekler------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Köri Soslu Tavuk");
            //    Console.WriteLine("2-Kızartma Tabağı");
            //    Console.WriteLine("3-Kuru Fasulye Pilav");
            //    Console.WriteLine("4-Fırında Somon");
            //    Console.WriteLine("5-Patlıcan Musakka");
            //    Console.WriteLine("------------Ana Yemekler------------");
            //    Console.WriteLine();
            //}

            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Çorbalar------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mercimek Çorbası");
            //    Console.WriteLine("2-Ezogelin Çorbası");
            //    Console.WriteLine("3-Tavuk Çorbası");
            //    Console.WriteLine("------------Çorbalar------------");
            //    Console.WriteLine();
            //}

            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Pizzalar------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Margarita Pizza");
            //    Console.WriteLine("2-Karışık Pizza");
            //    Console.WriteLine("3-Ton Balıklı Pizza");
            //    Console.WriteLine("------------Pizzalar------------");
            //    Console.WriteLine();
            //}

            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------İçecekler------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kola");
            //    Console.WriteLine("2-Gazoz");
            //    Console.WriteLine("3-Ayran");
            //    Console.WriteLine("------------İçeceklerr------------");
            //    Console.WriteLine();
            //}

            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Tatlılar------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Sütlaç");
            //    Console.WriteLine("2-Baklava");
            //    Console.WriteLine("3-Künefe");
            //    Console.WriteLine("------------Tatlılar------------");
            //    Console.WriteLine();
            //}

            #endregion

            #region Switch Case
            // 3. video 37:10

            #endregion
            Console.Read();
        }
    }
}
