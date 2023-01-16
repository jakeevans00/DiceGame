using System;

namespace Mission2_DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Dice Throwing Simulator!\nHow many times would you like to roll?");
            string input = Console.ReadLine();
            int numThrows = Convert.ToInt32(input);

            DiceRoller dr = new DiceRoller();
            dr.createHistogram(numThrows);
        }
    }
}
