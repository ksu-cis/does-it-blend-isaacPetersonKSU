using System;

namespace DoesItBlend
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var b = new Banana();
            var m = new Mango();
            var s = new Strawberry();

            Console.Write(b.Blend());
            Console.Write(m.Blend());
            Console.Write(s.Blend());
        }
    }
}
