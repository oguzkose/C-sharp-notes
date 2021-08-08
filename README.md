## Hata Yönetimi
- Try-Catch

```csharp
            // Hata alabileceğimi düşündüğüm kod bloğunu try içine yazdım
            try 
            {
                Console.WriteLine("Lütfen bir sayı giriniz");
                int number = Convert.ToInt32(Console.ReadLine());
                System.Console.WriteLine("Girdiğiniz sayı" + " " + number);
            }
            // Alabileceğim Hatayı ex ile yakaladım
            catch (System.Exception ex)
            {
                System.Console.WriteLine("Hata Mesajı" + " " + Convert.ToString(ex));
            }
            // Finaly ile hata alsamda almasamda ne yapılacağını belirttim
            finally
            {
                System.Console.WriteLine("işlem tamamlandı");
            }
```

- ArgumentNullExeption
```csharp
            try
            {
                int number = int.Parse(null);
                System.Console.WriteLine(number);
            }
            catch (ArgumentNullException ex)
            {
                
                System.Console.WriteLine(ex);
                System.Console.WriteLine("Boş değer verilemez");
            }

```
- Format Exeption
```csharp
            try
            {
                int number = int.Parse("test");
            }
            catch (FormatException ex)
            {
                System.Console.WriteLine("Yanlış Format " + " " + ex);
            }
```
- Overflow Exeption
```csharp
            try
            {
                int number = int.Parse("1234567890000");
            }
            catch (OverflowException ex)
            {
                System.Console.WriteLine("Değer, int tipinin değer aralığında değil" + " " + ex);
            }
```

## Ternary If

```csharp
            int time = DateTime.Now.Hour;

            var result = time >= 6 && time <= 11 ? "Günaydın"
                : time > 11 && time <= 18 ? "İyi Günler"
                : time > 18 && time <= 23 ? "İyi Akşamlar"
                : "İyi geceler";

            System.Console.WriteLine(result);
```

## Switch-Case

```csharp
            Random random = new Random();
            int number = random.Next(1,5);

            //Expression
            switch (number)
            {
                case 1:
                    System.Console.WriteLine("Rastgele sayı: 1");
                    break;
                case 2:
                    System.Console.WriteLine("Rastgele sayı: 2");
                    break;
                case 3:
                    System.Console.WriteLine("Rastgele sayı: 3");
                    break;
                default:
                    System.Console.WriteLine("Rastgele sayı: 4");
                    break;
            }
```

```csharp
            int month = DateTime.Now.Month;

            switch (month)
            {
                case 3:
                case 4:
                case 5:
                    System.Console.WriteLine("İlkbahar mevsimindeyiz");
                    break;
                    
                case 6:
                case 7:
                case 8:
                    System.Console.WriteLine("Yaz mevsimindeyiz");
                    break;

                case 9:
                case 10:
                case 11:
                    System.Console.WriteLine("Sonbahar mevsimindeyiz");
                    break;

                default:
                    System.Console.WriteLine("Kış mevsimindeyiz");
                    break;
            }
```
## For Loop
```csharp
            // 0 dan başlayıp kullanıcının vermiş olduğu sayıya kadar olan
            //tek ve çift sayıların toplamını bulunuz 
            int unEvenNumbers = 0;
            int evenNumbers = 0;

            Console.WriteLine("Lütfen bir sayı giriniz:");
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i <= number; i++)
            {
                var added = i % 2 == 1 ? unEvenNumbers += i : evenNumbers += i;
            }

            System.Console.WriteLine("0'dan"+" "+ number + "'a kadar olan tek sayıların toplamı"+ " " + unEvenNumbers);
            System.Console.WriteLine("0'dan"+" "+ number + "'a kadar olan çift sayıların toplamı"+ " " + evenNumbers);

```
## Foreach Loop 
- Bir Collection yapısının elemanları içinde dönmeye yarar

```csharp
            string[] cars = {"BMW","Audi","Nissan","Mercedes"};
            
            foreach (var item in cars)
            {
                System.Console.WriteLine(item);
            }

```
## Arrays

```csharp
            string[] colors = new string[2];
            
            colors[0]="red";
            colors[1]="black";

            foreach (var item in colors)
            {
            System.Console.WriteLine(item);    
            }

```
```csharp
            int [] numbers ={1,2,3,4,5};
            foreach (var item in numbers)
            {
                System.Console.WriteLine(item);
            }
```
- Sort() Clear() Reverse() IndexOf() Resize<>() Metotları
```csharp
            //Sort() metotu ile arrayin elemanları küçükten büyüğe sıralanır.
            int [] numbers ={5,7,9,3,1,456};
             Array.Sort(numbers); sırala
             foreach (var item in numbers)
             {
                 System.Console.WriteLine(item);
             }
             //Clear() 
             Array.Clear(numbers,2,3); //numbers arrayinin [2] indexinden başlayp 3 elemanını sıfırla
             foreach (var item in numbers)
             {
                 System.Console.WriteLine(item);
             }
             //Reverse() metotu ile dizinin elemanları sondan başa doğru sıranır.
             Array.Reverse(numbers); 
             foreach (var item in numbers)
             {
                 System.Console.WriteLine(item);
             }
        
             //IndexOf() metotu ile diziye ait elemanın hangi index'te olduğu bulunur.
             System.Console.WriteLine(Array.IndexOf(numbers,456));
        
             //Resize() metotu ile dizinin kapasitesi yeniden belirtilebilir.
             Array.Resize<int>(ref numbers,7);
             numbers[6]=100;
            
            foreach (var item in numbers)
            {
                System.Console.WriteLine(item);
            }
```
# Methods
- Metotlar iki yapıdadır. Değer döndüren ve değer döndürmeyen metotlar. Aynı şekilde parametre alan ve parametre almayan olarak kendi içinde ikiye ayrılır.
```csharp
            class Program
            {
                static void Main(string[] args)
                {
                    //değer döndüren , parametre alan metot 
                    static int Sum(int number1, int number2)
                    {
                        return number1 + number2;
                    }

                    int result = Sum(3, 5);
                    System.Console.WriteLine(result);


                    //değer döndüren , parametre almayan metot
                    static int Division()
                    {
                        int a = 8;
                        int b = 4;
                        return a/b;
                    }

                    System.Console.WriteLine(Division());


                    //değer döndürmeyen , parametre almayan
                    static void Print()
                    {
                        System.Console.WriteLine("Hello World");
                    }
                    Print();

                    //değer döndürmeyen , parametre alan
                    static void SayHi(string message)
                    {
                        System.Console.WriteLine(message);
                    }
                    SayHi("Hiiiii");
                }
            }
        
``` 
## Method Overloading
- Bir metotun ismini çok defa kullanarak, parametrelerinde değişiklik yapıp metotlar olusşturulabilir, metotlara Aşırı yüklemeler yapılabilir.  

```csharp
        class Methods
        {
            public void PrintToScreen(string name)
            {
                System.Console.WriteLine(name);
            }

            public void PrintToScreen(int number)
            {
                System.Console.WriteLine(number);
            }

            public void PrintToScreen(int number, int number2)
            {
                System.Console.WriteLine(number + number2);
            }
        }
```
Program.cs
```csharp
        class Program
        {
            static void Main(string[] args)
            {
                Methods methods = new();

                methods.PrintToScreen("oğuz");
                methods.PrintToScreen(29);
                methods.PrintToScreen(10, 20);
            }
        }
```
## Recursive (öz-yinelemeli) Methods
 ```csharp
        class Program
        {
            static void Main(string[] args)
            {
                // 2^7 ifadesinin değerini bulunuz
                int Expo(int baseValue, int topValue)
                {
                    return topValue < 2 ? baseValue 
                    : Expo(baseValue, topValue - 1) * baseValue;
                }

                int result = Expo(2, 7);
                System.Console.WriteLine(result);

                // Faktöriyel hesaplama
                static int Factorial(int number)
                {
                    return number == 1 ? number
                    : number * Factorial(number - 1);
                }
                int result = Factorial(6);
                System.Console.WriteLine(result); // Output : 720
            }
        }
```
## Extension Methods
- Instance alınmadan erişebilmek için extension metotların kendisi ve ait olduğu class static olmalı. ve parametrede this anahtar kelimesi yazılmalıdır.
Program.cs
```csharp
        class Program
        {
            static void Main(string[] args)
            {
                string sentence = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.";

                bool result = sentence.AnySpace();
                System.Console.WriteLine(result);

                System.Console.WriteLine(sentence.RemoveWhiteSpaces());

                System.Console.WriteLine(sentence.MakeUpperCase());

                System.Console.WriteLine(sentence.MakeLowerCase()); 
            }
        }
```
Extension.cs
```csharp
            static class Extension
            {
                //string metin boşluk içeriyor mu?
                public static bool AnySpace(this string sentence)
                {
                    return sentence.Contains(" ");
                }

                // metinde ki tüm boşlukları kaldır
                public static string RemoveWhiteSpaces(this string sentence)
                {
                    string[] joining = sentence.Split(" ");// arasında boşluk olan tüm ifadeleri dizi içine al.
                    return string.Join("", joining);// dizideki tüm elemanların arasında boşluk olmayacak şekilde birleştir
                }

                public static string MakeUpperCase(this string sentence)
                {
                    return sentence.ToUpper();
                }

                public static string MakeLowerCase(this string sentence)
                {
                    return sentence.ToLower();
                }

            }

```