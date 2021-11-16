using System;

namespace hadanicisel_
{
    class Program
    {
        static void Main(string[] args)
        {
            bool neuhodl = true;
            int tipcislo;

            Random random = new Random();
            int nahcislo = random.Next(1, 100);

            Console.WriteLine("hadani cisel");
            Console.WriteLine("myslim si cislo od 1 do 100");

            while (neuhodl)
            {
                Console.Write("napis svuj tip:");
                tipcislo = int.Parse(Console.ReadLine());
                if (tipcislo < nahcislo)
                {
                    Console.WriteLine("to je malo");
                }
                else if (tipcislo > nahcislo)
                {
                    Console.WriteLine("To je moc");
                }
                else
                {
                    Console.WriteLine("trefa!!!!!!!!");
                    neuhodl = false;
                }
            }
        }
    }
}
