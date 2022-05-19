using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    class Cats : Animals
    {
        public void Paw()
        {
            Console.WriteLine("Cats can paw.");
        }

        public void Move()
        {
            base.Move();
        }
    }
}