using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects      //Projenin adı (01_MainSubjects)
{
    internal class Program
    {
        static void Main(string[] args)     //Komutları main metodu içine yazarız.
        {
            //Console.Write("Merhaba Dünya"); //Write bir yazı yazdığı zaman imleci yazının en sağına atar.
            //Console.WriteLine("Selam");     //Writeline ifadesi bir değer yazar, sonra imleci alt satıra indirir.

            #region YazdırmaKomutları

            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();        // Bir satır daha boşluk bıraksın.
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri *****");

            #endregion

            #region String Değişkenler
            // Değişkenler, veriler üzerinde işlemler yapabilmemizi sağlayan ve geçici olarak RAM'de tutulan programlama değerleridir.

            //string (alfabetik değişkenler)
            //Değişken_türü değişken_adı;

            //string name;
            //name = "Durdane";
            //Console.Write(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;       //Bir satırda aynı türde birden fazla değişken tanımlanabilir.

            //customerName = "Ali";
            //customerSurname = "Çınar";
            //customerPhone = "+90 400 500 20 30";
            //customerEmail = "deneme@gmail.com";
            //district = "Kadıköy";
            //city = "İstanbul";

            //Console.WriteLine("**** Rezervasyon Kartı ****");
            //Console.WriteLine();
            //Console.WriteLine("-------------------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("-------------------------------------------------");

            //Console.WriteLine();

            //customerName = "Ayşegül";
            //customerSurname = "Kaya";
            //customerPhone = "+90 400 300 70 80";
            //customerEmail = "test@gmail.com";
            //district = "Erdemli";
            //city = "Mersin";

            //Console.WriteLine("-------------------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("-------------------------------------------------");

            #endregion

            #region Int Değişkenler

            //int (Tam sayı türündeki değişkenler)
            //int number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("**** Restoran Menü Fiyatı ****");
            Console.WriteLine();
            Console.WriteLine("-----Hamburger: " + hamburgerPrice + " TL ");
            Console.WriteLine("-----Pizza: " + pizzaPrice + " TL ");
            Console.WriteLine("-----Kızartma: " + friesPrice + " TL ");
            Console.WriteLine("-----Kola: " + cokePrice + " TL ");
            Console.WriteLine("-----Limonata: " + lemonadePrice + " TL ");
            Console.WriteLine("-----Su: " + waterPrice + " TL ");
            Console.WriteLine();
            Console.WriteLine("**** Restoran Menü Fiyatı ****");


            Console.WriteLine();
            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice;
            int totalCokePrice;
            int totalWaterPrice;
            int totalFriesPrice;
            int totalPizzaPrice;
            int totalLemonadePrice;

            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;
            totalFriesPrice = friesCount * friesPrice;
            totalPizzaPrice= pizzaCount * pizzaPrice;
            totalLemonadePrice= lemonadeCount * lemonadePrice;


            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Hamburger Tutarı: " + totalHamburgerPrice + " TL ");
            Console.WriteLine("Pizza Tutarı: " + totalPizzaPrice + " TL ");
            Console.WriteLine("Kızartma Tutarı: " + totalFriesPrice + " TL ");
            Console.WriteLine("Kola Tutarı: " + totalCokePrice + " TL ");
            Console.WriteLine("Limonata Tutarı: " + totalLemonadePrice + " TL ");
            Console.WriteLine("Su Tutarı: " + totalWaterPrice + " TL ");

            Console.WriteLine();
            int totalPrice = totalHamburgerPrice + totalPizzaPrice + totalFriesPrice + totalCokePrice + totalLemonadePrice + totalWaterPrice;

            Console.WriteLine("Toplam Ödenecek Tutar: " + totalPrice + " TL ");
            Console.WriteLine("--------------------------------------");

            #endregion

            Console.Read(); // Enter tuşuna basana kadar ekranı bekletecek olan koddur.
        }
    }
}
