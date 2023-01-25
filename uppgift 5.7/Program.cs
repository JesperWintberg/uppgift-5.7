using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] länder = { "Kina", "indien", "USA", "Indonesien", "Pakistan" };

            for(int i = 0; i<länder.Length; i++)
            {
                Console.WriteLine(länder[i]);
            }
            Console.WriteLine();
            Console.Write("Hur många länder vill du skriva utt: ");
            string val = Console.ReadLine();

            int val2 = int.Parse(val);

            Console.WriteLine();
            for(int i = 0; i < val2; i++)
            {
                Console.WriteLine(länder[i]);
            }
        }
    }
}
