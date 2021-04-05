using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args) // Põhimeetod ja selle parameetrid

        {
            string UserChoice = string.Empty; // Nimetab muutuja string'ina
            do {  // kordab, kuniks

                Console.WriteLine("Please enter your target?");//Trükib ekraanile vastava teksti
                int UserTarget = int.Parse(Console.ReadLine());// Nimetab muutuja jaannab sellele kasutaja trükitud väärtuse

                int Start = 0;// Määrab stardi muutujale väärtuseks 0

                while (Start <= UserTarget) // Kordab järgnevat 2 rida kuni start on väiksem või võrdne usertargetiga
                {
                    Console.WriteLine(Start + " "); // Trükib sulgudes oleva väärtuse
                    Start = Start + 2; // Kasvatab stardi väärtust 2 võrra
                }
        
                do{ // Teeb järgnevat
                    Console.WriteLine("Do you want to continue - Yes or No?"); // Trükib jutumärkides oleva teksti

                    UserChoice = Console.ReadLine().ToUpper(); // Loeb trükitut ja muudab kõik tähemärgid suureks
                    if (UserChoice != "YES" && UserChoice != "NO"){ // Kontrollib, kumb on kasutaja vastus
                        Console.WriteLine("Invalid Choice, please say Yes or No"); // Trükib jutumärkides oleva teksti
                    }
                } while (UserChoice != "YES" && UserChoice != "NO"); // Kontrollib, kumb on kasutaja vastus
            } while (UserChoice == "YES"); // Kordab kogu asja kui vastus on jah
        }
        }
}
