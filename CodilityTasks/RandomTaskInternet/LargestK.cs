namespace CodilityTasks.RandomTaskInternet;

public class LargestK
{
    public int ReturnLargest(int[] A)
    {
        var countMap = new Dictionary<int, int>();

        foreach (int num in A)
        {
            if (countMap.ContainsKey(Math.Abs(num)))
            {
                int currentK = Math.Abs(num);
                int currentCount = countMap[currentK];
                countMap[currentK] = currentCount + 1;
            }
            else
            {
                countMap[Math.Abs(num)] = num > 0 ? 1 : -1;
            }
        }

        int largestK 
        = countMap.Where(c => c.Value == 2).Select(c => c.Key).Max();

        return largestK;
    }

}