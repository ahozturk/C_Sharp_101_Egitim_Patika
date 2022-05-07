using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            while(true){
                int day = -1;
            Console.Write("Enter a number 1 to 7: ");
            try{
                day = int.Parse(Console.ReadLine());
            }catch(Exception ex){
                Console.WriteLine("Geçersiz Sayi Girildi!");
            }



            switch(day){
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("A week is 7 days!");
                    break;

            }                    
            }
        }
    }
}