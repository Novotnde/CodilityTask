namespace CodilityTasks.RandomTaskInternet;

public class EqualHeight
{
    public int MakeEqual(int[] piles)
    {
        int maxHeight = piles.Max();
        int steps = 0;

        // Repeat the process until all piles have the same height
        while (true)
        {
            int minDiff = int.MaxValue;
            int maxIdx = -1;

            // Find the maximum height pile
            for (int i = 0; i < piles.Length; i++)
            {
                if (piles[i] == maxHeight)
                {
                    maxIdx = i;
                    break;
                }
            }

            // Check if all piles are already equal in height
            bool allEqual = true;
            foreach (int pile in piles)
            {
                if (pile != maxHeight)
                {
                    allEqual = false;
                    break;
                }
            }

            if (allEqual)
            {
                break;
            }

            // Find the next maximum height pile
            for (int i = 0; i < piles.Length; i++)
            {
                if (piles[i] < maxHeight && maxHeight - piles[i] < minDiff)
                {
                    minDiff = maxHeight - piles[i];
                    maxIdx = i;
                }
            }

            // Update the heights of piles
            piles[maxIdx] = maxHeight - minDiff;
            steps += minDiff;
        }

        return steps;
    }

}