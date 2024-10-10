﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü
            //Döngüler
            //For(x;y;z) => Üç parametre vardır:
            //x:Başlangç Değeri (start value)
            //y:Bitiş Değeri (end value)
            //z:Artış-Azalış (increase-decrease)

            //int i;

            //for (i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("C# Eğitim Kampı");
            //    //Break point koyarak test edebiliriz.
            //}

            //for (int i = 1; i <= 20; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 3; i <= 50; i+= 3)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.Write("Lütfen ekrana istediğiniz adedi giriniz: ");
            //int finishValue = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= finishValue; i++)
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet");
            //}

            #endregion

            #region For Döngüsü ile Karar Yapıları

            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int totalvalue = 0;

            //for (int i = 1; i <= 10; i++)
            //{
            //    totalvalue += i;
            //}
            //Console.WriteLine(totalvalue);

            ////Örnek:1 ile 20 arasındaki çift sayıların toplamı

            //int totalValue = 0;

            //for (int i = 1; i < 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalValue += i;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("--------");
            //Console.WriteLine(totalValue);

            //Örnek:1 ile 50 arasında 7'ye tam bölünen kaç tane sayı olduğunu bulalım

            //int count = 0;

            //for (int i = 1; i <= 50; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);


            ////Örnek:Bir bakteri türü her saatin sonunda kendini ikiye bölerek çoğaltmaktadır.
            ////24 saatin sonunda bu ortamda kaç bakteri olur?

            //int bacterium = 1;

            //for (int i = 1; i <= 24; i++)
            //{
            //    bacterium *= 2;
            //    Console.WriteLine(i + ". Saat Sonunda: " + bacterium);
            //}

            #endregion

            #region While Döngüsü

            //While(Şart)   => Şart sağlandığı müddetçe
            //{
            //işlemler
            //}

            //int i = 1;

            //while (i <= 10)
            //{
            //    Console.WriteLine("Merhaba Döngüler");
            //    i++;
            //}

            //int i = 1;
            //while (i <= 10)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            //Örnek:1 ile 10 arasındaki sayıların toplamı?

            //int i = 1;
            //int sum = 0;    //toplam=0

            //while (i <= 10)
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine(sum);

            #endregion

            #region Örnek Sınav Sorusu

            //Klavyeden girilen 3 basamaklı sayının basamakları toplamını hesaplayan kodu yazınız.

            //456

            //Console.Write("Sayıyı Giriniz: ");
            //int number=int.Parse(Console.ReadLine());
            //int ones, tens, hundreds;    //birler, onlar, yüzler;
            //int sum;

            //ones = number % 10;         //456 % 10 = 6
            //tens = (number % 100) / 10; //456 % 100 = 56 --> 56/10 = 5.6 --> 5
            //hundreds = number / 100;    //4.56 --> 4

            //Console.WriteLine(ones + "-" + tens + "-" + hundreds);

            //sum = ones + tens + hundreds;

            //Console.WriteLine(sum);

            #endregion
            
            Console.Read();
        }
    }
}