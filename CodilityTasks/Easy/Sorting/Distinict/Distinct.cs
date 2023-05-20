namespace CodilityTasks.Easy.Sorting.Distinict;

public class Distinct
{
    // 100 correct 33 perf
    public int solution(int[] A)
    {
        var distinct = new Dictionary<int, int>();
        var repeated = 0;
        var unique = 0;

        if (A.Length <= 0 || A.Length >= 100000) return distinct.Count();
        for (int i = 0; i < A.Length; i++)
        {
            var num = A[i];
            if (num < -1000000 || num > 1000000) continue;
            if (!distinct.ContainsKey(num))
            {
                distinct.Add(num,1);
                unique++;
            }
            else
            {
                repeated++;
            }
        }

        return unique;
    }
    
    
    // 100 correct 33 perf

    public int solutionTheSameSlow(int[] A)
    {
        var distinct = new HashSet<int>();
        if (A.Length <= 0 || A.Length >= 100000) return distinct.Count();
        for (var i = 0; i < A.Length; i++)
        {
            distinct.Add(A[i]);
        }
        return distinct.Count();
    }

    
    // 100 correct 33 perf
    public int solutionTooSlow(int[] A)
    {
        if (A.Length > 0 && A.Length < 100000)
        {
            var distinct = A.Distinct().Count();
            return distinct;
        }

        return 0;
    }
}