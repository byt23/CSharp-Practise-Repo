using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler
            //double number;
            //number = 4.85;
            //Console.WriteLine(number);

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("---- Elma Birim Fiyatı: " + applePrice + " TL");
            //Console.WriteLine("---- Portakal Birim Fiyatı: " + orangePrice + " TL");
            //Console.WriteLine("---- Çilek Birim Fiyatı: " + strawberryPrice + " TL");
            //Console.WriteLine("---- Patates Birim Fiyatı: " + potatoPrice + " TL");
            //Console.WriteLine("---- Domates Birim Fiyatı: " + tomatoPrice + " TL");
            //Console.WriteLine(); 

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //Console.WriteLine("---- Alınan Elma Gramajı: " + appleGram + " kg");
            //Console.WriteLine("---- Alınan Portakal Gramajı: " + orangeGram + " kg");
            //Console.WriteLine("---- Alınan Çilek Gramajı: " + strawberryGram + " kg");
            //Console.WriteLine("---- Alınan Patates Gramajı: " + potatoGram + " kg");
            //Console.WriteLine("---- Alınan Domates Gramajı: " + tomatoGram + " kg");
            //Console.WriteLine();


            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;

            //double totalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;

            //Console.WriteLine("---- Toplam Elma Fiyatı: " +appleTotalPrice + " TL");
            //Console.WriteLine("---- Toplam Portakal Fiyatı: " + orangeTotalPrice + " TL");
            //Console.WriteLine("---- Toplam Çilek Fiyatı: " + strawberryTotalPrice + " TL");
            //Console.WriteLine("---- Toplam Patates Fiyatı: " + potatoTotalPrice + " TL");
            //Console.WriteLine("---- Toplam Domates Fiyatı: " + tomatoTotalPrice + " TL");
            //Console.WriteLine();
            //Console.WriteLine("---- Toplam Fiyat: " + totalPrice + " TL");
            #endregion

            #region Char Değişkenler

            //char symbol;
            //symbol = 'a';

            //Console.WriteLine(symbol);
            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler

            //Console.WriteLine("***** CSharp Hava Yolları Yolcu Bilgisi *****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerAge, passengerIdentityNumber, passengerDistrict, passengerCity;

            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("Yolcu Yaşı: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu TC Kimlik Numarası: ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.Write("Yolcu İlçesi: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Yolcu Şehri: ");
            //passengerCity = Console.ReadLine();


            //Console.WriteLine();

            //Console.WriteLine("----------------------------------------------");

            //Console.WriteLine("Yolcu: " +passengerName + " " + passengerSurname);
            //Console.WriteLine("Yaş: " + passengerAge);
            //Console.WriteLine("TC Kimlik Numarası: " + passengerIdentityNumber);
            //Console.WriteLine("İkametgah Adresi: " + passengerDistrict + " / " + passengerCity);


            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //int shoesPrice, computerPrice, chairPrice, tvPrice, totalPrice;

            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 15000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Ayakkabı Adedi: ");
            //shoesCount = int.Parse(Console.ReadLine());
            //// Kullanıcının girdiği değeri al, sayıya çevir ve 'shoesCount' değişkenine kaydet.

            //Console.Write("Bilgisayar Adedi: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Sandalye Adedi: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Televizyon Adedi: ");
            //tvCount = int.Parse(Console.ReadLine());

            //totalPrice = (shoesPrice * shoesCount) + (computerPrice * computerCount) + (chairPrice * chairCount) + (tvPrice * tvCount);

            //Console.WriteLine();
            //Console.WriteLine("Toplam Tutar: " + totalPrice + " TL");

            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("1. Sınav Notu: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("2. Sınav Notu: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("3. Sınav Notu: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız: " + result);

            #endregion

            #region Klavyeden Karakter Girişleri

            //char gender;
            //Console.Write("Cinsiyetiniz (E/K): ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz Cinsiyet: " +gender);
            #endregion

            Console.Read();
        }
    }
}
