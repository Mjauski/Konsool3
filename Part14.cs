using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args) // P�himeetod ja selle parameetrid

        {
            string UserChoice = string.Empty; // Nimetab muutuja string'ina
            do {  // kordab, kuniks

                Console.WriteLine("Please enter your target?");//Tr�kib ekraanile vastava teksti
                int UserTarget = int.Parse(Console.ReadLine());// Nimetab muutuja jaannab sellele kasutaja tr�kitud v��rtuse

                int Start = 0;// M��rab stardi muutujale v��rtuseks 0

                while (Start <= UserTarget) // Kordab j�rgnevat 2 rida kuni start on v�iksem v�i v�rdne usertargetiga
                {
                    Console.WriteLine(Start + " "); // Tr�kib sulgudes oleva v��rtuse
                    Start = Start + 2; // Kasvatab stardi v��rtust 2 v�rra
                }
        
                do{ // Teeb j�rgnevat
                    Console.WriteLine("Do you want to continue - Yes or No?"); // Tr�kib jutum�rkides oleva teksti

                    UserChoice = Console.ReadLine().ToUpper(); // Loeb tr�kitut ja muudab k�ik t�hem�rgid suureks
                    if (UserChoice != "YES" && UserChoice != "NO"){ // Kontrollib, kumb on kasutaja vastus
                        Console.WriteLine("Invalid Choice, please say Yes or No"); // Tr�kib jutum�rkides oleva teksti
                    }
                } while (UserChoice != "YES" && UserChoice != "NO"); // Kontrollib, kumb on kasutaja vastus
            } while (UserChoice == "YES"); // Kordab kogu asja kui vastus on jah
        }
        }
}
