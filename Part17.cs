using System;


class Program
{
    static void Main(string[] args)
    {
        int i = 0; // Annab nimetajale i v‰‰rtuse 0

        SimpleMethod(ref i); // Nimetab SimpleMethod meetodi
    }

    public static void SimpleMethod(ref int j) // Nimetab meetodi SimpleMethod viitega j
    {
        j = 101; // j-le v‰‰rtus 101

    }
}

// Teine

class Program
{
    static void Main(string[] args)
    {
        int Total = 0; // Muutuja Total v‰‰rtuseks 0
        int Product = 0; // Muutuja Product v‰‰rtuseks 0
        Calculate(10, 20, out Total, out Product); // Nimetab Calculate meetodi j‰rgnevate parameetritega

        Console.WriteLine("Sum = {0} && Product = {1}", Total, Product); // Prindib mılema muutujad
    }

    public static void Calculate(int FN, int SN, out int Sum, out int Product) // Nimetab meetodi, viiteks 2 viimast parameetrit
    {
        Sum = FN + SN; // M‰‰rab sum'iks kahe numbri summa
        Product = FN * SN; // M‰‰rab productile kahe numbri korrutise

    }
}
// Kolmas

class Program
{
    static void Main(string[] args)
    {
        int[] Numbers = new int[3]; // Loob array 3 elemendiga

        Numbers[0] = 101; // Nimetab array esimese elemendi
        Numbers[1] = 102; 
        Numbers[2] = 103; 

        //ParamsMethod();
        //ParamsMethod(Numbers);
        ParamsMethod(1, 2, 3, 4, 5); // Nimetab ParamsMethod antud numbritega
    }

    public static void ParamsMethod(params int[] Numbers) // Nimetab meetodi, parameetriks array
    {
        Console.WriteLine("There are {0} elements", Numbers.Length); // Tr¸kib array pikkuse
        foreach (int i in Numbers) // kordab arrayd
        {
            Console.WriteLine(i); // Tr¸kib antud elemendi
        }
    }
}
