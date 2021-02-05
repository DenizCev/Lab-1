using System;
using System.Collections.Generic;
using System.Numerics;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "873123218232844923a'+31224566as23";

            List<string> FirstString = new List<string>();

            List<string> Match = new List<string>();

            List<string> EndString = new List<string>();


            for (int i = 0; i < input.Length - 1; i++)
            {
                if (Char.IsDigit(input[i]))
                {


                    for (int j = i + 1; j < input.Length; j++)
                    {
                        if (Char.IsDigit(input[j]))
                        {


                            if (input[i] == input[j])
                            {
                                Match.Add(input[i..(j + 1)]);
                                FirstString.Add(input[i..(j + 1)]);
                                EndString.Add(input[i..(j + 1)]);



                                

                                break;

                            }


                       
                        }
                        else
                        {
                            break;
                        }


                    }
                  
                                   
                }
                else
                {
                    continue;
                }
            }
            for (int i = 0; i < Match.Count; i++)
            {
                Console.Write(FirstString[i]);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(Match[i]);
                Console.ResetColor();
                Console.WriteLine(EndString[i]);





            }



            

            Console.ReadKey();
        }
    }
}
//Uppgiften går ut på att tolka och 
//analysera en textsträng som tal. 

//Textsträngen ska sökas igenom efter alla delsträngar som är tal som
//börjar och slutar på samma siffra, utan att start/slutsiffran, eller något annat tecken än siffror förekommer där emellan.