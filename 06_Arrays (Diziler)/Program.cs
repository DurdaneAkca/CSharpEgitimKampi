using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays__Diziler_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri
            //Aynı veri tipindeki çok sayıda veriyi bir arada tutmak için kullanılan yapılardır.
            //2.4.6.8
            //sarı,kırmızı,mavi,yeşil
            //adana,bursa,ankara,mersin
            //Diziler oluşturulurken;
            //DeğişkenTürü [] DiziAdı = new DeğişkenTürü[ElemanSayısı]

            //Örnek-1:
            //string[] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "Sarı";
            //colors[2] = "Beyaz";
            //colors[3] = "Mavi";

            //Console.WriteLine(colors[2]);

            //Örnek-2:
            //string[] cities = new string[5];

            //cities[0] = "İstanbul";
            //cities[1] = "Ankara";
            //cities[2] = "Mersin";
            //cities[3] = "Samsun";
            //cities[4] = "İzmir";

            //Console.WriteLine(cities[3]);

            //Örnek-3:
            //int[] numbers = new int[10];
            //numbers[0] = 50;
            //numbers[1] = 48;
            //numbers[2] = 698;
            //numbers[3] = 24;
            //numbers[7] = 748;

            //Console.WriteLine(numbers[7]);
            //Console.WriteLine(numbers[5]);  //Bir indekse değer ataması yapmazsak o indeksin defult değeri sıfır olur.

            //Örnek-4: Boyutunu belirtmeden direkt olarak da yazabiliriz.
            //string[] cities = { "Prag", "Roma", "Atina", "Ankara", "Bursa" };

            //Console.WriteLine(cities[3]);

            #endregion

            #region Dizideki Tüm Elemanları Listeleme
            //Örnek-1:
            //string[] colors = { "Sarı", "Kırmızı", "Beyaz", "Mavi", "Yeşil", "Turuncu", "Pembe" };

            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //Örnek-2:(Değişken tanımlama, karar yapısı, döngü, dizi içeren örnek)
            //int[] numbers = { 4, 85, 96, 75, 125, 635, 488, 522, 7456, 2365, 1120 };

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //Örnek-3:(char türünde bir örnek)
            //char[] symbols = { 'a', 'b', 'c', '*', '/', '-' };
            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            //Örnek-4:(Dizideki en büyük elemanı bulan program)
            //int[] myArray = { 47, 85, 95, 41, 25, 635, 789, 86, 100 };

            //int maxNumber=myArray[0];   //Başlangıçta ilk değer en büyük kabul edilir.

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}
            //Console.WriteLine(maxNumber);

            //Length metodu --> Dizinin boyutunu verir
            //string[] persons = { "ali", "ahmet", "ayşe", "buse", "cem", "deniz" };
            //Console.WriteLine(persons.Length);

            //Sort metodu --> Sıralama yapar
            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //Reverse metodu diziyi tersten sıralar (boyut olarak değil!!)
            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            #endregion

            #region Dizi Metotları

            //IndexOf metodu dizi içinde herhangi bir aranan değerin indeks sırasını döndürür.

            //string[] customers = { "ali", "buse", "ayşegül", "merve", "çınar", "kaya" };
            //int index = Array.IndexOf(customers, "merve");

            //Console.WriteLine(index);

            //max ve min metotları ile istediğimiz en büyük ve en küçük sonucu bulabiliriz.

            //int[] numbers = { 45, 85, 96, 63, 74, 10, 25, 22, 36 };

            //Console.WriteLine("Dizinin En Büyük Elemanı: " + numbers.Max());
            //Console.WriteLine("Dizinin En Küçük Elemanı: " + numbers.Min());

            #endregion

            #region Kullanıcıdan Değer Alma

            //string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    //$ sembolu parametresel ({i} ifadesi gibi) ifadeleri kullanmamıza olanak sağlar.
            //    Console.Write($"Lütfen {i + 1}. Şehri Giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("--------------------");

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //Dizideki tüm elemanların toplamını döndürelim.

            //int[] numbers = { 10, 20, 30, 40, 50 };
            //int sum = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);

            //Dizideki tek ve çift sayıları gruplayalım.

            //int[] numbers = { 21, 42, 33, 54, 55, 66, 897, 748, 39, 220 };

            //Console.WriteLine("Çift Sayılar");
            //Console.WriteLine();

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            //Console.WriteLine("---------------");
            //Console.WriteLine("Tek Sayılar");
            //Console.WriteLine();

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 1)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            #endregion

            Console.Read();
        }
    }
}
