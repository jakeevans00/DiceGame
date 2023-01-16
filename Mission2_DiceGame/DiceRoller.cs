using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2_DiceGame
{
    class DiceRoller
    {
        public void createHistogram(int throws)
        {
            Console.WriteLine("DICE ROLLING SIMULATION RESULTS\nEach \"*\" represents 1% of the total number of rolls.\n" +
                "Total number of rolls = " + throws + "\n");
            int[] results = new int[13];
            Random rand = new Random();

            for (int i = 0; i < throws; i++)
            {
                //create first and second dice, roll randomly between 1 and 6 (repeat as many times as throws is initialized)
                int dice1 = rand.Next(1, 7);
                int dice2 = rand.Next(1, 7);

                //increment array holding the sum of dice rolls
                results[dice1 + dice2]++;
            }

            for (int i = 2; i < results.Length; i++)
            {
                //print out histogram coordinates
                Console.Write(i + ":");
                

                if (results[i] == 0)
                {
                    Console.Write("\n");
                }
                else
                { 
                    float percentage = ((results[i]/ (float) throws) * 100);
                    
                    int data = (int)percentage;
                  
                    
                    for (int j = 0; j < data; j++)
                    {
                 
                        Console.Write("x");
                    }
                    Console.Write("\n");
                }
            }
        }
    }
}
