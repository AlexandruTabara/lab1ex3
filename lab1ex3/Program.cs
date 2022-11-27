using System;

namespace lab1ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Scrieti un program care va afisa ultima cifra a unui numar intreg citit de la tastaura

            Console.WriteLine("Intoduceti un numar:");
            int n = int.Parse(Console.ReadLine());

            int ultimaCifra = n % 10;
            Console.WriteLine("Ultima cifra a numarului introdus {0} este {1}", n, ultimaCifra);
        }
    }
}
