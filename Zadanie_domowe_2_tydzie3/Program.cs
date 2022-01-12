using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_domowe_2_tydzie3
{
    class Program
    {
        //private static int GetRandomNumber()
        //{
        //    bool test = true;
        //    int number;
        //    do
        //    {
        //        test = int.TryParse(Console.ReadLine(), out int retInt);
        //        if (test)
        //        {
        //            return retInt;
        //        }
        //        else
        //        {
        //            Console.WriteLine("Błędne wprowadzenie!");
        //        }
        //    } while (!test);
        //}

        private static int GetIntNumber()
        {
            for (;;)
            {
                if (!int.TryParse(Console.ReadLine(), out int numberToReturn))
                {
                    Console.WriteLine("Niepoprawne wprowadzenie, wprowadź liczbę całkowitą z zakresu 0 - 100!");
                }
                return numberToReturn;
            }
        }

        static void Main(string[] args)
        {
            Random rnd = new Random();
            var randomNumber = rnd.Next(0, 101);  //losowa liczba z zakresu 0 - 100
            var shouldStop = false;
            int numberOfTrials = 0;
            Console.WriteLine("Wylosowana została losowa liczba od 0 do 100, spróbuj odgadnąć!");
            while (!shouldStop)
            {
                numberOfTrials++;
                Console.WriteLine("Próba numer: " + numberOfTrials);
                Console.WriteLine("Wprowadź liczbę z zakresu od 0 do 100: ");
                var typedNumber = GetIntNumber();

                
                if (typedNumber == randomNumber)
                {
                    shouldStop = true;
                    Console.WriteLine("Odgadłeś liczbę!");
                }else if (randomNumber > typedNumber)
                {
                    Console.WriteLine("Wpisałeś liczbę o zbyt małej wartości");
                }
                else
                {
                    Console.WriteLine("Podałeś liczbę o zby wielkiej wartości");
                }
                
            }

            Console.WriteLine("Gratulacje! Liczba odgadnięta! Liczba prób: " + numberOfTrials);
            Console.ReadLine();
        }
    }
}
