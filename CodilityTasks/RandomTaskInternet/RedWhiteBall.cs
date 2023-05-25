namespace CodilityTasks.RandomTaskInternet;

public class RedWhiteBall
{
    public int MinSwaps(string s)
    {
        List<int> redIndex = new List<int>();
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == 'R')
            {
                redIndex.Add(i);
            }
        }
        int res = 0;
        int mid = redIndex.Count / 2; // mid is the point to get minimum swaps; greedy.
        for (int i = 0; i < redIndex.Count; i++)
        {
            res += Math.Abs(redIndex[mid] - redIndex[i]) - Math.Abs(mid - i);
        }
        return res;

    }

}