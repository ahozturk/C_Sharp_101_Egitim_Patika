using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Animals
    {
        protected void Move()
        {
            Console.WriteLine("Animals can move");
        }

        public virtual void Reflect()
        {
            Console.WriteLine("Animals can reflect");
        }

        public int footCount;
    }
}