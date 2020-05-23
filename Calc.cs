using System;
using System.Security.Cryptography.X509Certificates;

namespace Calculator
{
    public class Calc
    {
        public static void Main()
        {

         
                int choice;


                Console.WriteLine("Witaj w kalkulatorze!");
                Console.WriteLine();
                Console.WriteLine("Wybierz jaką operacje matematyczną chcesz wykonać");
                Console.WriteLine("1. Dodawanie");
                Console.WriteLine("2. Odejmowanie");
                Console.WriteLine("3. Mnożenie");
                Console.WriteLine("4. Dzielenie");
                Console.WriteLine("5. Porównanie");
                Console.WriteLine("6. Procentowanie");

                Console.WriteLine();
                Console.Write("Wybór: ");
                choice = Convert.ToInt16(Console.ReadLine());

                while (choice < 1 || choice > 6)
                {
                    Console.WriteLine("Zły wybór!");
                    Console.Write("Wpisz ponowanie numer przypisany do operacji: ");
                    choice = Convert.ToInt16(Console.ReadLine());
                }

                switch (choice)
                {
                    case 1:
                        var add = new add();
                        add.Initialize();
                        break;
                    case 2:
                        var subtract = new subtract();
                        subtract.Initialize();
                        break;
                    case 3:
                        var multiply = new multiply();
                        multiply.Initialize();
                        break;
                    case 4:
                        var divide = new divide();
                        divide.Initialize();
                        break;
                    case 5:
                        var compare = new compare();
                        compare.Initialize();
                        break;
                    case 6:
                        var percent = new percent();
                        percent.Initialize();
                        break;
                }
            }

        
    }
    }

