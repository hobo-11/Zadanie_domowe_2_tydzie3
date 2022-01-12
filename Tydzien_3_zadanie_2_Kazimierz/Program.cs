using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tydzien_3_zadanie_2_Kazimierz
{
    class Program
    {
        private static int GetNumber()
        {
            while (true)
            {  
                if (!int.TryParse(Console.ReadLine(), out int number))
                {
                    Console.WriteLine("Podałeś nieprawidłową liczbę, Spróbuj ponownie.");
                    continue;
                }
                return number;
            }
        }

        static void Main(string[] args)
        {
            var random = new Random();
            var randomNumber = random.Next(0, 101);
            Console.WriteLine("Właśnie wylosowałem 1 liczbę z zakresu 0 - 100.Spróbuj ją odgadnąć.");
            var numberOfTries = 0;
            while(true){
                numberOfTries++;
                Console.WriteLine("\nPodaj Twoją liczbę:");
                var userNumber = GetNumber();
                if(userNumber < randomNumber){
                    Console.WriteLine("Twoja liczba jest mniejsza niż wylosowana.Spróbuj ponownie.");
                    continue;
                }
                if(userNumber > randomNumber){
                    Console.WriteLine("Twoja liczba jest większa niż wylosowana.Spróbuj ponownie.");
                    continue;
                }
                Console.WriteLine($"Super! Odgadłeś wylosowaną liczbę w { numberOfTries} próbach");
                break;
            }


            Console.ReadLine();

        }
    }
}
