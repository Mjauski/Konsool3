using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int[] Numbers = new int[3]; // Loob array 3 elemendiga

                Numbers[0] = 101; // Määrab esimese väärtuseks 101
                Numbers[1] = 102;
                Numbers[2] = 103;
                Numbers[3] = 104; // Neljanda elemendina viib errorisse

                foreach (int k in Numbers) // Käib terve array läbi
                {
                    Console.WriteLine(k); // Trükib elemendi
                }

               // for (int j = 0; j < Numbers.Length; j++) // Määrab j väärtuseks 0, kordab kuniks numbripikkus on suurem kui j, ning liidab juurde 1(j++)
                //{
                  //  Console.WriteLine(Numbers[j]);
                //}

                //int i = 0;
                //while (i < Numbers.Length)
                //{
                  //  Console.WriteLine(Numbers[i]);
                    //i++;
                //}
            }
        }

    }
}

/ / / / /
using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 20; i++) // Kordab plokki 20 korda
            {
                Console.WriteLine(i); // Trükib elemendi
                if (i == 10)
                    break; // Lõpetab kordamise, kui i = 10
            }


        }

    }
}

/ / / //  /

using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 20; i++) // Kordab plokki 20 korda
            {
                if (i % 2 == 1) // Jätab paaritud arvud vahele
                    continue;

                Console.WriteLine(i); // Trükib paarisarvud
               
            }


        }

    }
}

