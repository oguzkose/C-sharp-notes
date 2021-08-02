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