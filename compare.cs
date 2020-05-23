using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class compare
    {
        public void Initialize()
        {
            double a;
            double b;
            string result;
            char decison;

            Console.Write("Podaj 1 liczbę: ");
            a = Double.Parse(Console.ReadLine());
            Console.Write("Podaj 2 liczbę: ");
            b = Double.Parse(Console.ReadLine());
            if (a > b)
            {
                result = "W tym przypadku A jest większe od B";
                Console.WriteLine(result);
            }
            else if (a < b)
            {
                result = "W tym przypadku A jest mniejsze od B";
                Console.WriteLine(result);
            }
            else if (a == b)
            {
                result = "W tym przypadku A jest równe B";
                Console.WriteLine(result);
            }
            
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
