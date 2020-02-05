using System;
using System.Collections.Generic;

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

            Console.Write(b.Blend() + "\n\n");
            Console.Write(m.Blend() + "\n\n");
            Console.Write(s.Blend() + "\n\n");

            List<Fruit> fruits = new List<Fruit>() { b, m, s };

            foreach(Fruit f in fruits)
            {
                Console.Write(f.Blend() + "\n\n");
            }
            
        }
    }
}
