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
            var c = new IceCubes();

            Console.Write(b.Blend() + "\n\n");
            Console.Write(m.Blend() + "\n\n");
            Console.Write(s.Blend() + "\n\n");

            List<Iblendable> snax = new List<Iblendable>() { b, m, s, c };

            foreach(Iblendable f in snax)
            {
                Console.Write(f.Blend() + "\n\n");
            }
            
        }
    }
}
