using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2
{
    internal class DiceRolls
    {
        public int[] Simulatation(int dice_rolls)
        {
            // make randomizer for numbers
            Random randomizer = new Random();

            // make array for results
            int[] result_array = new int[11];    

            // roll two dice each time and append result to the array
            for (int i = 0; i < dice_rolls; i++)
            {
                int dice1 = randomizer.Next(1, 7);
                int dice2 = randomizer.Next(1, 7);
                int sum = dice1 + dice2;

                result_array[sum - 2]++;
            }

            // return result
            return result_array;
        }
    }
}
