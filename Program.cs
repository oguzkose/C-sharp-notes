using System;

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

            /*----------foreach ----------------*/
            // string[] cars = {"BMW","Audi","Nissan","Mercedes"};

            // foreach (var item in cars)
            // {
            //     System.Console.WriteLine(item);
            // }
            /*-----------ARRAYS------------*/
            // string[] colors = new string[2];

            // colors[0]="red";
            // colors[1]="black";

            // foreach (var item in colors)
            // {
            // System.Console.WriteLine(item);    
            // }

            // int [] numbers ={1,2,3,4,5};
            // foreach (var item in numbers)
            // {
            //     System.Console.WriteLine(item);
            // }

            //Sort()
            // int [] numbers ={5,7,9,3,1,456};
            //  Array.Sort(numbers); // arrayin elemanlarını kçükten büyüğe sırala
            //  foreach (var item in numbers)
            //  {
            //      System.Console.WriteLine(item);
            //  }
            //  //Clear() 
            //  Array.Clear(numbers,2,3); //numbers arrayinin [2] indexinden başlayp 3 elemanını sıfırla
            //  foreach (var item in numbers)
            //  {
            //      System.Console.WriteLine(item);
            //  }
            //  //Reverse()
            //  Array.Reverse(numbers); //dizinin elemanlarını sondan başa doğru sırala
            //  foreach (var item in numbers)
            //  {
            //      System.Console.WriteLine(item);
            //  }

            //  //IndexOf()
            //  System.Console.WriteLine(Array.IndexOf(numbers,456));

            //  //Resize()
            //  Array.Resize<int>(ref numbers,7);
            //  numbers[6]=100;

            // foreach (var item in numbers)
            // {
            //     System.Console.WriteLine(item);
            // }

            /*-----------Metotlar-------------*/
            // int a = 2;
            // int b = 3;

            // Metotlar metotlar = new Metotlar();

            // System.Console.WriteLine(metotlar.Topla(ref a, ref b));


        }
    }
 
    // class Metotlar
    // {
    //     public int Topla(ref int numb1, ref int numb2)
    //     {
    //         numb1 += 1;
    //         numb2 += 1;
    //         return numb1 + numb2;
    //     }
    // }
}
