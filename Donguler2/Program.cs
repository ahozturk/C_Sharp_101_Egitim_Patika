using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.Write("Enter a number: ");
            int input = Convert.ToInt32(Console.ReadLine());
            int count = 1;
            int sum = 0;
            while(count <= input){
                sum += count;
                count++;
            }
            int average = sum / (count - 1);
            Console.WriteLine("Ortalama: " + average);


            char c = 'A';

            while(c <= 'z'){
                Console.Write(c);
                c++;
            }
            Console.ReadLine();
*/

            string[] kitaplar = {"Gün Olur Asra Bedel", "Dişi Kurdun Rüyaları", "Beyaz Gemi"};
            foreach(var kitap in kitaplar){
                Console.WriteLine("Cengiz Aytmatov - " + kitap);
            }

            Console.Read();
        }
    }
}