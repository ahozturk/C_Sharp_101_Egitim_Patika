using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen 0 ile 10 arasında bir sayı giriniz: ");
            int[] kartlar = new int[10];
            int input = 0;
            try{
                input = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Kart: " + kartlar[input]);
            }
            catch(IndexOutOfRangeException ex){
                Console.Write("Girdiğiniz sayı diziden daha büyük!");
            }catch(FormatException ex){
                Console.Write("Lütfen yalnızca sayı giriniz!");
            }
            
        }
    }
}