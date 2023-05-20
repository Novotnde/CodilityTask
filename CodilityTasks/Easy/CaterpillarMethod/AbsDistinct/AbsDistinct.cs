namespace CodilityTasks.Easy.CaterpillarMethod.AbsDistinct;

public class AbsDistinct
{
    // Compute number of distinct absolute values of sorted array elements. 
    public int solution(int[] A)
    {
        var distinctValues = new HashSet<int>();

        foreach (var num in A)
        {
            distinctValues.Add(Math.Abs(num));
        }

        return distinctValues.Count;
    }
} 