using System;

namespace lab1ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Se citesc trei numere de la tastatura, x,y,z. Scrieti un program care va afisa cele trei valori in ordine
            descrescatoare.
            • Exemplu: citim 3,9,0 Afisam : 9 3 0*/

            Console.WriteLine("Introduceti primul numar");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti al doilea numar");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti al treilea numar");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("Vom afisa numerele in ordine crescatoare");

            if ((a > b) && (a > c))
            {
                if (b > c)
                {
                    Console.WriteLine(a + " " + b +" " + c);
                }
                else
                {
                    Console.WriteLine(a + " " + c + " " + b);
                }
            }
            else if ((b > a) && (b > c))
            {
                if (a > c)
                {
                    Console.WriteLine(b + " " + a +" " + c);
                }
                else
                {
                    Console.WriteLine(b + " " + c + " " + a);
                }
            }
            else if ((c > a) && (c > b))
            {
                if (a > b)
                {
                    Console.WriteLine(c + " " + a + " " + b);
                }
                else
                {
                    Console.WriteLine(c + " " + b + " " + a);
                }

            }
      
        }
    }
}
