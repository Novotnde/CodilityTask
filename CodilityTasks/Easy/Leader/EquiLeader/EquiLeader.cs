namespace CodilityTasks.Easy.Leader.EquiLeader;

public class EquiLeader
{
    public int solution(int[] A)
    {
        var candidate = A.GroupBy(x => x)
            .OrderByDescending(g => g.Count())
            .First()
            .Key;
        var leaderCount = A.Count(x => x == candidate);
        if (leaderCount <= A.Length / 2)
        {
            return 0;
        }
         
        var leftOccurance = 0;
        var equiLeaderCount = 0;
        for (int i = 0; i < A.Length -1 ; i++)
        {
            if (A[i] == candidate)
            {
                leftOccurance++;
                leaderCount--;
            }
            int leftLength = i + 1;
            int rightLength = A.Length - leftLength;

            if (leftOccurance > leftLength / 2 && leaderCount > rightLength / 2)
            {
                equiLeaderCount++;
            }
        }

        return equiLeaderCount;
    }

}