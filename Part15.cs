using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int[] Numbers = new int[3]; // Loob array 3 elemendiga

                Numbers[0] = 101; // M��rab esimese v��rtuseks 101
                Numbers[1] = 102;
                Numbers[2] = 103;
                Numbers[3] = 104; // Neljanda elemendina viib errorisse

                foreach (int k in Numbers) // K�ib terve array l�bi
                {
                    Console.WriteLine(k); // Tr�kib elemendi
                }

               // for (int j = 0; j < Numbers.Length; j++) // M��rab j v��rtuseks 0, kordab kuniks numbripikkus on suurem kui j, ning liidab juurde 1(j++)
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
                Console.WriteLine(i); // Tr�kib elemendi
                if (i == 10)
                    break; // L�petab kordamise, kui i = 10
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
                if (i % 2 == 1) // J�tab paaritud arvud vahele
                    continue;

                Console.WriteLine(i); // Tr�kib paarisarvud
               
            }


        }

    }
}

