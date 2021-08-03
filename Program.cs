﻿using System;

namespace C__simple
{
    class Program
    {
        static void Main(string[] args)
        {
            /*---------------Try-Catch------------------*/
            // try
            // {
            //     Console.WriteLine("Lütfen bir sayı giriniz");
            //     int number = Convert.ToInt32(Console.ReadLine());
            //     System.Console.WriteLine("Girdiğiniz sayı" + " " + number);
            // }
            // catch (System.Exception ex)
            // {
            //     System.Console.WriteLine("Hata Mesajı" + " " + Convert.ToString(ex));
            // }
            // finally
            // {
            //     System.Console.WriteLine("işlem tamamlandı");
            // }

            /*---------------ArgumentNullException------------------*/

            // try
            // {
            //     int number = int.Parse(null);
            //     System.Console.WriteLine(number);
            // }
            // catch (ArgumentNullException ex)
            // {

            //     System.Console.WriteLine(ex);
            //     System.Console.WriteLine("Boş değer verilemez");
            // }

            /*---------------FormatException------------------*/

            // try
            // {
            //     int number = int.Parse("test");
            // }
            // catch (FormatException ex)
            // {
            //     System.Console.WriteLine("Yanlış Format " + " " + ex);
            // }
            /*---------------OverflowException------------------*/

            // try
            // {
            //     int number = int.Parse("1234567890000");
            // }
            // catch (OverflowException ex)
            // {
            //     System.Console.WriteLine("Değer, int tipinin değer aralığında değil" + " " + ex);
            // }
            /*---------------TERNARY IF-------------------*/

            // int time = DateTime.Now.Hour;

            // var result = time >= 6 && time <= 11 ? "Günaydın"
            //     : time > 11 && time <= 18 ? "İyi Günler"
            //     : time > 18 && time <= 23 ? "İyi Akşamlar"
            //     : "İyi geceler";

            // System.Console.WriteLine(result);
            /*------------------SWİTCH-CASE---------------*/
            // Random random = new Random();
            // int number = random.Next(1,5);

            // //Expression
            // switch (number)
            // {
            //     case 1:
            //         System.Console.WriteLine("Rastgele sayı: 1");
            //         break;
            //     case 2:
            //         System.Console.WriteLine("Rastgele sayı: 2");
            //         break;
            //     case 3:
            //         System.Console.WriteLine("Rastgele sayı: 3");
            //         break;
            //     default:
            //         System.Console.WriteLine("Rastgele sayı: 4");
            //         break;
            // }

            // int month = DateTime.Now.Month;

            // switch (month)
            // {
            //     case 3:
            //     case 4:
            //     case 5:
            //         System.Console.WriteLine("İlkbahar mevsimindeyiz");
            //         break;

            //     case 6:
            //     case 7:
            //     case 8:
            //         System.Console.WriteLine("Yaz mevsimindeyiz");
            //         break;

            //     case 9:
            //     case 10:
            //     case 11:
            //         System.Console.WriteLine("Sonbahar mevsimindeyiz");
            //         break;

            //     default:
            //         System.Console.WriteLine("Kış mevsimindeyiz");
            //         break;
            // }

            /*-------------FOR LOOP--------------*/
            // 0 dan başlayıp kullanıcının vermiş olduğu sayıya kadar olan
            //tek ve çift sayıların toplamını bulunuz 
            // int unEvenNumbers = 0;
            // int evenNumbers = 0;

            // Console.WriteLine("Lütfen bir sayı giriniz:");
            // int number = int.Parse(Console.ReadLine());

            // for (int i = 0; i <= number; i++)
            // {
            //     var added = i % 2 == 1 ? unEvenNumbers += i : evenNumbers += i;
            // }

            // System.Console.WriteLine("0'dan"+" "+ number + "'a kadar olan tek sayıların toplamı"+ " " + unEvenNumbers);
            // System.Console.WriteLine("0'dan"+" "+ number + "'a kadar olan çift sayıların toplamı"+ " " + evenNumbers);
        }
    }
}
