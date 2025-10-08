using System;

namespace LABB1
{

    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Mata in en text med siffror och nummer.");
            string input = Console.ReadLine();
            Console.Clear();

            long subsAdd = 0;

            for (int i = 0; i < input.Length; i++) 
            {
                if (!char.IsNumber(input[i])) 
                {
                    continue;
                }

                for (int j = i + 1; j < input.Length; j++) 
                {
                    if (!char.IsNumber(input[j])) 
                    {
                        break;
                    }

                    if (input[i] != input[j]) 
                    {
                        continue;
                    }

                    string rangeSub = input[i..(j + 1)]; 
                    
                    for (int k = 0; k < input.Length; k++)
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

                    break;
                }
                
            }
            Console.WriteLine("\nSumman av substrings: " + subsAdd);
            Console.ReadLine();
        } 
    }
}




