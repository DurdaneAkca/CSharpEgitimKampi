using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            //Foreach döngüsü dört parametre (1;2;3;4) alan bir döngüdür.
            //1:Değişken türü
            //2:Değişken adı
            //3:In (içinden)
            //4:Liste, koleksiyon veya dizi adı

            //string[] cities = { "milano", "roma", "budapeşte", "ankara", "istanbul", "varşova" };

            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);
            //    //city adındaki değişken cities içine gidip sırasıyla bütün değerleri üzerine alacak.
            //    //For döngüsündeki gibi başlangıç, bitiş, kurallar ile uğraşmamız gerekmez.
            //}

            //Foreach döngüsünü aritmetik ifadeler için de kullanabiliriz.

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //Dizideki çift sayıları listelemek istersek;

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };

            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            //Foreach döngüsü içerisinde toplama işlemleri yapılabilir.

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };

            //int total = 0;

            //foreach (int i in numbers)
            //{
            //    total += i;
            //}
            //Console.WriteLine(total);

            //Listeler bir koleksiyon öğesidir. Dizilere benzerler ama farkı vardır.
            // List<int> numbers = new List<int>(); yapısındadır.

            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,8
            //};

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //string yapıda bir kelime girdiğimizde foreach yardıyla bunu karakterlerine ayırabiliriz.

            //string word = "Merhaba";

            //foreach (char c in word)
            //{
            //    Console.WriteLine(c);
            //}

            #endregion

            #region Örnek Sınav Sistemi Uygulaması

            Console.Write("***** C# Eğitim Kampı Sınav Uygulaması *****");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //Sınıftaki öğrenci sayısını kullanıcıdan alma
            Console.WriteLine("------------------------------");
            Console.Write("Sınıfınızda kaç öğrenci var: ");
            int studentCount=int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------");

            //Öğrenci isimlerini ve not ortalamalarını saklayacak diziler
            string[] studentNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];

            for(int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. öğrencinin ismini giriniz: ");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;

                //Her öğrenci için 3 sınav notu girişi

                for(int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} isimli öğrencinin {j + 1}. sınav notunu giriniz: ");
                    double value=double.Parse(Console.ReadLine());
                    totalExamResult += value; //sınav notlarını topluyoruz.
                }
                Console.WriteLine();
                studentExamAvg[i] = totalExamResult / 3;
            }

            //Sınav ortalamaları
            for(int i = 0;i < studentCount; i++)
            {
                Console.WriteLine("------------------------------");

                Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması: {studentExamAvg[i]}");

                //Öğrencilerin ortalaması ve geçme/kalma durumları
                if(studentExamAvg[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti.");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı.");
                }

                Console.WriteLine("------------------------------");                

            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("***** C# Eğitim Kampı Sınav Uygulaması *****");

            #endregion

            Console.Read();
        }
    }
}
