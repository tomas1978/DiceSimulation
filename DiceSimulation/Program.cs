using System;

namespace DiceSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfDice;
            int nyttUtfall;
            int[] utfall = new int[6];
            Console.Write("Ange antal tärningskast: ");
            numberOfDice = int.Parse(Console.ReadLine());
            Random rand = new Random();
            for(int i=0;i< numberOfDice; i++)
            {
                nyttUtfall = rand.Next(0, 6);
                utfall[nyttUtfall]++;
            }
            for(int i=0;i<6;i++)
            {
                Console.Write("Antal " + (i + 1) + ": ");
                Console.Write(utfall[i]);
                Console.Write(", relativ frekvens: " + 100*(float)utfall[i] / numberOfDice + " %\n");
            }
        }
    }
}
