using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class percent
    {
        public void Initialize()
        {
            double a;
            double b;
            double result;
            char decison;

            Console.Write("Podaj 1 liczbę: ");
            a = Double.Parse(Console.ReadLine());
            Console.Write("Podaj jaki procent chcesz obliczyć (np. 50): ");
            b = Double.Parse(Console.ReadLine());
            result = a/100 * b ;
            Console.WriteLine("Wynik: " + result);
            Console.WriteLine();
            Console.Write("Czy chcesz kontynuować (Y/N): ");
            decison = Console.ReadKey().KeyChar;
            while (decison == 'N')
            {
                Console.WriteLine();
                Console.WriteLine("Konćzenie pracy kalkulatora...");
                return;
            }
            switch (decison)
            {
                case 'Y':
                    Console.WriteLine();
                    var Calc = new Calc();
                    Calc.Main();
                    break;
            }


        }
    }
}
