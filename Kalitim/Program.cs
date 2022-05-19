using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Birds dove = new Birds();
            dove.Flap();//Bird Class
            dove.footCount = 2;//Animal Class

            Cats dog = new Cats();
            dog.footCount = 4;//Animal Class
            dog.Paw();//Cat Class
            dog.Move();//Animal Class
            dog.Reflect();//Animal Class but Overrided
        }
    }
}