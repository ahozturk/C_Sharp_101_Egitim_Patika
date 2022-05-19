using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    class Birds : Animals
    {
        public bool canFly;
        public int FootCount { get => base.footCount; set => base.footCount = value; }

        public void Flap()
        {
            Console.WriteLine("Birds can fly");
        }

        
        public override void Reflect()
        {
            base.Reflect();
            Console.WriteLine("If you touch birds they will run.");
        }

        public Birds()
        {
            base.footCount = 2;
        }

    }
}