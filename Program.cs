using System;
using System.Collections;
using System.Collections.Generic;

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

            //değer döndüren , parametre alan metot 
            // static int Sum(int number1, int number2)
            // {
            //     return number1 + number2;
            // }

            // int result = Sum(3, 5);
            // System.Console.WriteLine(result);

            // //değer döndüren , parametre almayan metot

            // static int Division(){
            //     int a = 8;
            //     int b = 4;
            //     return a/b;
            // }

            // System.Console.WriteLine(Division());

            // //değer döndürmeyen , parametre almayan
            // static void Print(){
            //     System.Console.WriteLine("Hello World");
            // }
            // Print();

            // //değer döndürmeyen , parametre alan
            // static void SayHi(string message){
            //     System.Console.WriteLine(message);
            // }
            // SayHi("Hiiiii");

            /*--------RECURSİVE METHODS-----------*/
            //2^5 2 üzeri 5 in sonucunu recursive metot ile yapınız

            //2*2*2*2*2
            // static int Expo(int baseValue, int topValue)
            // {
            //     return topValue < 2 ? baseValue 
            //     : Expo(baseValue, topValue - 1) * baseValue;
            // }

            // int result = Expo(2, 7);
            // System.Console.WriteLine(result);

            //3!

            // static int Factorial(int number)
            // {
            //     // return number == 1 ? number
            //     // : number * Factorial(number - 1);

            //     if (number == 1)
            //     {
            //         return number;
            //     }
            //     return number * Factorial(number - 1);
            // }
            // int result = Factorial(7);
            // System.Console.WriteLine(result); 

            /*------------EXTENSİON METHODS-----------------*/

            //Cümle içinde boşluk var mı?

            // string sentence = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.";

            // bool result = sentence.AnySpace();
            // System.Console.WriteLine(result);

            // System.Console.WriteLine(sentence.RemoveWhiteSpaces());

            // System.Console.WriteLine(sentence.MakeUpperCase());

            // System.Console.WriteLine(sentence.MakeLowerCase());

            // List<User> userList = new List<User>();

            //userList e user eklemek için 1.YOL
            // User user1 = new();
            // user1.Age=15;
            // user1.Name="Ali";

            // User user2 = new();
            // user2.Age=15;
            // user2.Name="Veli";

            // userList.Add(user1);
            // userList.Add(user2);
            // foreach (var user in userList)
            // {
            //     System.Console.WriteLine(user.Name + " " + user.Age);
            // };


            //userList e user eklemek için 1.YOL

            //  userList.Add(new User
            //  {
            //      Name = "Oğuz",
            //      Age = 15
            //  });
            //  userList.Add(new User
            //  {
            //      Name = "Veli",
            //      Age = 25
            //  });

            //    //Farklı Foreach kullanımı:
            //     userList.ForEach(user => System.Console.WriteLine(user.Name + " " + user.Age));
            //String tip List
            // List<string> animals = new List<string> { "cat", "dog" };
            // animals.ForEach(animal => System.Console.WriteLine(animal));

            // //Int tip List
            // List<int> numbers = new() { 1, 2, 3, 4, 5 };
            // numbers.ForEach(number => System.Console.WriteLine(number));

            // List<int> numbers = new List<int>();
            // // Add() eleman ekler
            // numbers.Add(1);
            // numbers.Add(2);
            // numbers.Add(3);
            // numbers.ForEach(item => System.Console.WriteLine(item));//Output: 1,2,3

            // numbers.Remove(2); // 2 elemanını siler
            // numbers.ForEach(item => System.Console.WriteLine(item)); //Output: 1,3

            // numbers.RemoveAt(0); // index numarasına göre siler
            // numbers.ForEach(item => System.Console.WriteLine(item));//Output: 3

            // numbers.Clear(); // Listeyi temizler

            // List<string> animals = new() { "dog", "cat", "rabbit", "tiger" };

            // bool result = animals.Contains("tiger"); // Contains ile aranılan eleman var mı bakılır. Bool döner.
            // System.Console.WriteLine(result);//Output: True

            // int inWhichIndex = animals.BinarySearch("rabbit");// BinarySearch() ile elemanın hangi indexte olduğu bulunabilir.
            // System.Console.WriteLine(inWhichIndex);// Output:2

            //Array i List' e çevirme

            // string[] car = { "Volvo", "BMW", "Audi" };
            // System.Console.WriteLine(car[0]);

            // List<string> carList = new List<string>(car);

            // carList.ForEach(item => System.Console.WriteLine(item));

            /*-----------ARRAYLİST---------------*/

            // ArrayList differentObjects = new ArrayList();

            // differentObjects.Add("Oğuz");
            // differentObjects.Add(15);
            // differentObjects.Add(true);
            // differentObjects.Add(23.9);

            // foreach (var item in differentObjects)
            // {
            //     System.Console.WriteLine(item);
            // }

            // ArrayList differentObjects = new ArrayList();

            // List<int> numbers = new() { 1, 2, 3, 4, 5 };
            // differentObjects.AddRange(numbers);
            
            // string[] colors = { "yellow", "red", "blue" };
            // differentObjects.AddRange(colors);

            // foreach (var item in differentObjects)
            // {
            //     System.Console.WriteLine(item);
            // }
            /*-----------------DICTIONARY--------------------*/

            // Dictionary<int,string> users = new Dictionary<int, string>();
            // users.Add(1,"Oğuz Köse");
            // users.Add(2,"Lars Ulrich");
            // users.Add(3,"David Gilmour");

            // var result = users[1];
            // System.Console.WriteLine(result); //Output : Oğuz Köse

            // foreach (var item in users)
            // {
            //     System.Console.WriteLine(item.Value);
            // }



        }
    }
    // public class User
    // {
    //     public string Name { get; set; }
    //     public int Age { get; set; }
    // }
    // Instance alınmadan erişebilmek için extension metotların kendisi ve ait olduğu class static olmalı. ve parametrede this anahtar kelimesi yazılmalı
    // static class Extension
    // {
    //     //string metin boşluk içeriyor mu?
    //     public static bool AnySpace(this string sentence)
    //     {
    //         return sentence.Contains(" ");
    //     }

    //     // metinde ki tüm boşlukları kaldır
    //     public static string RemoveWhiteSpaces(this string sentence)
    //     {
    //         string[] joining = sentence.Split(" ");// arasında boşluk olan tüm ifadeleri dizi içine al.
    //         return string.Join("", joining);// dizideki tüm elemanların arasında boşluk olmayacak şekilde birleştir
    //     }
    //     public static string MakeUpperCase(this string sentence)
    //     {
    //         return sentence.ToUpper();
    //     }
    //     public static string MakeLowerCase(this string sentence)
    //     {
    //         return sentence.ToLower();
    //     }

    // }


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
