using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RectangleStruct rec = new RectangleStruct(2,4);
            // RectangleStruct rec;
            // rec.LongSide = 2;
            // rec.SortSide = 4;
            rec.CalculateArea();


            RectangleClass cl = new RectangleClass();
            cl.CalculateArea();

            RectangleClass cl1 = new RectangleClass(1,4);
            cl1.CalculateArea();
        }
    }

    class RectangleClass
    {
        public int LongSide;
        public int SortSide;

        public RectangleClass(int longSide, int sortSide)
        {
            LongSide = longSide;
            SortSide = sortSide;
        }

        public RectangleClass()
        {
            LongSide = 1;
            SortSide = 1;
        }

        public void CalculateArea()
        {
            Console.WriteLine("Area: " + (LongSide * SortSide));
        }
        
    }

    struct RectangleStruct
    {
        public int LongSide;
        public int SortSide;

        public RectangleStruct(int longSide, int sortSide)
        {
            this.LongSide = longSide;
            this.SortSide = sortSide;
        }

        public void CalculateArea()
        {
            Console.WriteLine("Area: " + (LongSide * SortSide));
        }
    }

}