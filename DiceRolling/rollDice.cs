namespace DiceRolling;

public class rollDice
{
    public static int[] Roll(int numRolls, int numDice, int numSides)
    {
        int[] results = new int[numRolls];
        Random rnd = new Random();
        int value = 0;
        int total = 0;
        for(int i= 0; i < numRolls; i++)
        {
            total = 0;
            for (int j = 0; j < numDice; j++)
            {
                value = rnd.Next(1, numSides + 1);
                total += value;
            }
            results[i] = total;
        }
        
        return results;
    }
}