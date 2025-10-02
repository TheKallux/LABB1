using System;

namespace LABB1
{

    class Program
    {
        static void Main(string[] args) //----------------------------------------------------------------------------- MAIN
        {
            Console.WriteLine("Mata in en text med siffror och nummer.");
            string input = Console.ReadLine();

            long subsAdd = 0;

            for (int i = 0; i < input.Length; i++) // Börja loopa igenom strängen från index 0 kör till slutet av strängen.
            {
                if (!char.IsNumber(input[i])) // Kollar om tecknet på index 0 är en siffra. Om != siffra, hoppa över.
                {
                    continue;
                }

                for (int j = i + 1; j < input.Length; j++) // j söker efter siffra som matchar i, börjar på index 1 (alltid en siffra framåt) och slutar på sista index (om inget annat sägs).
                {
                    if (!char.IsNumber(input[j])) // Samma check som i-loopen, men om j hittar tecken som ej är siffra, hoppa ur loop (eftersom strängar med bokstäver ska ignoreras).
                    {
                        break;
                    }

                    if (input[i] != input[j]) // Fortsätt loopen så länge vi inte hittar en matchning till i.
                    {
                        continue;
                    }

                    string rangeSub = input[i..(j + 1)]; // Vid match, skär ut sub-sträng från i till j + 1 (+ 1 eftersom [i] är tecknet och j är index, alltså -1) som börjar på index i (0 för första substringen). 
                    
                    for (int k = 0; k < input.Length; k++) // Loopa igenom input.Legnth. Om k befinner sig mellan i och j, inkluderade, skriv ut substräng i blått. Om inte, skriv ut i vitt.
                    {
                        
                        if (k >= i && k <= j) 
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write(input[k]);
                        }

                        else
                        {
                            Console.ResetColor();
                            Console.Write(input[k]);
                        }

                    }

                    Console.WriteLine();

                    if (long.TryParse(rangeSub, out long result))
                    {
                        subsAdd += result;
                    }
                }
                
            }
            Console.WriteLine("\nSumman av substrings: " + subsAdd);
            Console.ReadLine();
        } // ---------------------------------------------------------------------------------------------------------MAIN
    }
}




