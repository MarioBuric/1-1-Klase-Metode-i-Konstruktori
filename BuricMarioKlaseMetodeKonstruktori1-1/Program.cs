using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuricMarioKlaseMetodeKonstruktori1_1
{ 
     class Program
    {
        static void Main(string[] args)
        {
            Proceduralni x = new Proceduralni();
            Objektni y = new Objektni();
            Funkcionalni z = new Funkcionalni();

            Console.WriteLine("Upisite postotak za x: ");
            x.Postotak = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Upisite postotak za z: ");
            z.Postotak = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Upisite postotak za y: ");
            y.Postotak = Convert.ToInt32(Console.ReadLine());

            if (x.Postotak + z.Postotak + y.Postotak != 100)
            {
                Console.WriteLine("Neispravan unos !!");
            }
            else
            {
                if (x.Postotak > y.Postotak && x.Postotak > z.Postotak)
                {
                    Console.WriteLine("Proceduralni je najkorišteniji!");
                }
                else if (y.Postotak > x.Postotak && y.Postotak > z.Postotak)
                {
                    Console.WriteLine("Objektni je najkorišteniji!");
                }
                else if (z.Postotak > x.Postotak && z.Postotak > y.Postotak)
                {
                    Console.WriteLine("Funkcionalni je najkorišteniji!");
                }
            }


            Console.ReadKey();
        }
    }
}
