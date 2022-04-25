using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DunjinzAnDizeRollz.Models
{
    public class DiceRoll
    {
        public int Sides { get; set; }
        public int NumberOfDice { get; set; }
        public int[] Results { get; set; }        

        public DiceRoll(int sides = 100, int numberOfDice = 1)
        {
            Sides = sides;
            NumberOfDice = numberOfDice;

            int[] dice = new int[numberOfDice];

            Random random = new Random();

            for (int i = 0; i < dice.Length; i++)
            {
                dice[i] = random.Next(1, sides + 1);
            }

            Results = dice;
        }

        public override string ToString()
        {
            string toString = $"Dice type: {Sides}\n" +
                $"Number of dice rolled: {NumberOfDice}\n";

            for (int i = 0; i < Results.Length; i++)
            {
                toString += $"Result {i + 1}: {Results[i]}\n";
            }

            return toString;
        }
    }
}
