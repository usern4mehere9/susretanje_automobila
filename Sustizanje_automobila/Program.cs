using System;

namespace Sustizanje_automobila
{
    class Program
    {
        static void Main(string[] args)
        {
            double v1, v2, t, Rez;
            v1 = double.Parse(Console.ReadLine());
            v2 = double.Parse(Console.ReadLine());
            t = double.Parse(Console.ReadLine());

            t = t * 60;
            Rez = (v1 * t) / (v2 - v1);
            Rez = Rez / 60;

            Console.WriteLine(Math.Round(Rez, 2));
        }
    }
}
