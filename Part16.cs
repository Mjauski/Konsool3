using System;


class Program
{
    static void Main(string[] args)
    {
        Program.EvenNumbers(30); // Nimetab meetodi EvenNumber

        Program P = new Program(); // L‰htestab uue objekti class Programile
        int Sum = P.Add(10, 20); // Nimetab muutuja Sum ja annab sellele P.Add meetodi tulemuse v‰‰rtuse

        Console.WriteLine("Sum = {0}", Sum); // Prindib Sum muutuja
    }

    public int Add(int FN, int SN) // Add meetod
    {
        return FN + SN; // Annab vastu ka mainitud muutuja summa
    }
    public static void EvenNumbers(int Target) // EvenNumbers meetod
    {
        int Start = 0; // M‰‰rab 0 Stardile

        while (start <= 20) // Kordab kuni start on v‰iksem vıi vırdne 20ga
        {
            Console.WriteLine(Start); // Tr¸kib start
            Start = Start + 2; // Suurendab starti 2 vırra
        }
    }
}


