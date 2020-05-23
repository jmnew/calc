using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class subtract
    {
        public void Initialize()
        {
            double a;
            double b;
            double result;
            char decison;

            Console.Write("Podaj 1 liczbę: ");
            a = Double.Parse(Console.ReadLine());
            Console.Write("Podaj 2 liczbę: ");
            b = Double.Parse(Console.ReadLine());
            result = a - b;
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
