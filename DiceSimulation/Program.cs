using System;

namespace DiceSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            int nyttUtfall;
            int[] utfall = new int[6];
            Console.WriteLine("Antal tärningskast: 1000");
            Random rand = new Random();
            for(int i=0;i<1000;i++)
            {
                nyttUtfall = rand.Next(0, 6);
                utfall[nyttUtfall]++;
            }
            for(int i=0;i<6;i++)
            {
                Console.Write("Antal " + (i + 1) + ": ");
                Console.WriteLine(utfall[i]);
            }
        }
    }
}
