using Mission2;
public class Program
{
    private static void Main(string[] args)
    {
        // connect new class
        DiceRolls dc = new DiceRolls();

        // display initial prompts
        System.Console.WriteLine("Welcome to the dice throwing simulator!");
        System.Console.WriteLine("How many dice rolls would you like to simulate?");

        // get number of dices rolls
        int dice_rolls = int.Parse(System.Console.ReadLine());

        // get array of results from other class
        int[] results = dc.Simulatation(dice_rolls);

        // display result messages
        System.Console.WriteLine("DICE ROLLING SIMULATION RESULTS\nEach '*' represents 1% of the total number of rolls\nTotal number of rolls = " + dice_rolls);

        // show results
        ShowResults(results);

        // display end message
        System.Console.WriteLine("Thanks for using the simulator. Goodbye!");

    }

    public static void ShowResults(int[] results)
    {
        int totalCount = results.Sum(); // Calculate the total count of values

        for (int i = 2; i <= 12; i++)
        {
            // write each number in the histogram
            System.Console.Write($"{i,2}: ");

            // determine percentage and write * to show it
            int percentage = (int)Math.Round((double)results[i - 2] * 100 / totalCount);
            for (int j = 0; j < percentage; j++)
            {
                System.Console.Write("*");
            }

            System.Console.WriteLine();
        }
    }

}