namespace CodilityTasks.RandomTaskInternet;

public class UniqueSumUpToZero
{
    public int[] ReturnAnArray(int n)
    {
        int[] result = new int[n];
        int sum = 0;

        for (int i = 1; i < n; i++)
        {
            result[i - 1] = i;
            sum += i;
        }

        result[n - 1] = -sum;

        return result;
    }
}