using System;

namespace hadanicisel_
{
    class Program
    {
        static void Main(string[] args)
        {
            bool neuhodl = true;
            int tipcislo;
            int nahcislo;
            int cislood;
            int cislodo;

            Random random = new Random();
            nahcislo = random.Next(1, 100);

            Console.WriteLine("hadani cisel");
            Console.WriteLine($"budu hadat cislo od {cislood} do {cislodo}");

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
