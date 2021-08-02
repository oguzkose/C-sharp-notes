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

        }
    }
}
