// See https://aka.ms/new-console-template for more information

using DiceRolling;

internal class Program
{
    public static void Main(string[] args)
    {
        int numRolls = 100;
        string starString = "";
        Console.WriteLine("Welcome to the dice throwing simulator! \n");
        Console.WriteLine("How many dice rolls would you like to simulate?");
        numRolls = Convert.ToInt32(Console.ReadLine());

        int[] results = new int[numRolls];

        Console.WriteLine("Perfect! We will roll " + numRolls + " dice.");
        rollDice rollDice = new rollDice();
        results = rollDice.Roll(numRolls, 2, 6);

        Dictionary<int, int> rollCounts = new Dictionary<int, int>();

        for (int i = 0; i < results.Length; i++)
        {
            // Console.WriteLine(results[i]);
            if (rollCounts.ContainsKey(results[i]))
            {
                rollCounts[results[i]]++;
            }
            else
            {
                rollCounts.Add(results[i], 1);
            }
        }

        for (int key = 2; key < 13; key++)
        {
            if (rollCounts.ContainsKey(key))
            {
                for (int star = 0; star < 100 * rollCounts[key] / numRolls; star++)
                {
                    starString += "*";
                }
                Console.WriteLine($"{key}: {starString}");
                starString = "";
            }
            else
            {
                Console.WriteLine($"{key}: ");
            }
        }
        Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
    }
}