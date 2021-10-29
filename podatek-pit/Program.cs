using System;

namespace podatek_pit
{
    class Program
    {
        static public void przedsiebiorca()
        {

        }

        static public void czlowiek()
        {
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Witaj w programie do obliczania skladki PIT. \n\nZadeklaruj swój status: \n   1. Osoba fizyczna. \n   2. Firma rozliczająca się na zasadach PIT");
            Wybor: //punkt podjecia przez użytkownika decyzji kim jest, POCZĄTEK PROGRAMU
            int wybor = int.Parse(Console.ReadLine());
            switch (wybor)
            {
                case 1:
                    przedsiebiorca();
                    break;
                case 2:
                    czlowiek();
                    break;
                case 3:
                    czlowiek();
                    break;
                default:
                    Console.Write("Niepoprawny wybór, spróbuj jeszcze raz: ");
                    goto Wybor;

            }

        }
    }
}
