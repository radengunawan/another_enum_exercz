using System;
using System.Collections.Generic;

namespace another_enum_exercz
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            List<Bebek> donald = new List<Bebek>
            {
                new Bebek (JenisBebek.Mallard, 17),
                new Bebek (JenisBebek.Muscovy, 18),
                new Bebek (JenisBebek.Loon, 14),
                new Bebek (JenisBebek.Muscovy, 11),
                new Bebek (JenisBebek.Mallard, 14),
                new Bebek (JenisBebek.Loon, 13),

            };
            PrintBebek(donald);

        } //END Main

        public static void PrintBebek (List<Bebek> apaAjaBoleh)
        {
            foreach (var item in apaAjaBoleh)
            {
                Console.WriteLine($"{item.Size} inch {item.Jenis}");
            }
        }
    }
}
