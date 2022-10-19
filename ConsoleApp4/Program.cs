using System;

namespace ____
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Avslut = false;

            do
            {
                Console.WriteLine("\nVälj ett av följande alternativ.");
                Console.WriteLine("1 - Subtrahera ett tal med ett annat");
                Console.WriteLine("2 - Dividera ett tal med ett annat");
                Console.WriteLine("3 - Avluta programmet");

                Console.Write("\nVälj här: "); int Val = int.Parse(Console.ReadLine());

                int Tal1;
                int Tal2;
                string Avslutsval = "";

                switch (Val)
                {
                    case 1:
                        Console.WriteLine("\nDu har valt alternativ 1.");

                        Console.Write("\nSkriv in ditt första tal: "); Tal1 = int.Parse(Console.ReadLine());

                        Console.Write("\nSkriv in ditt andra tal: "); Tal2 = int.Parse(Console.ReadLine());

                        Console.WriteLine($"\nSvaret blir då {Tal1 - Tal2}.");

                        break;

                    case 2:
                        Console.WriteLine("\nDu har valt alternativ 2.");

                        Console.Write("\nSkriv in ditt första tal: "); Tal1 = int.Parse(Console.ReadLine());

                        Console.Write("\nSkriv in ditt andra tal: "); Tal2 = int.Parse(Console.ReadLine());

                        Console.WriteLine($"\nSvaret blir då {Tal1 / Tal2}.");
                        break;

                    case 3:
                        Console.WriteLine("\nDu har valt alternativ 3.");

                        Console.WriteLine("\nProgrammet kommer nu att avslutas.");

                        Avslut = true;
                        break;

                    default:
                        Console.WriteLine("\nDu valde ej ett alternativ som existerade.");

                        Console.WriteLine("\nProgrammet kommer nu att köras igen.");
                        break;
                }
                
                if (Val == 1 || Val == 2)
                {
                    Console.Write("\nVill du köra igen? (j/n): "); Avslutsval = Console.ReadLine().ToLower();

                }

                if (Avslutsval == "n")
                {
                    Avslut = true;
                }
            }
            while (Avslut == false);
        }
    }
}
