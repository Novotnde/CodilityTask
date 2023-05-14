namespace CodilityTasks.Easy.Sorting.MaxProductOfThree;

public class MaxProductOfThree
{
    //55 successs 
    public int solution(int[] A)
    {
        if (A.Length < 3 || A.Length > 100000)
        {
            return 0;
        }

        Array.Sort(A);
        var results = new Dictionary<int, int>();
        var counter = 0; 
        for (var i = A.Length -1; i >= 2; i--)
        {
            if (A[i] < -1000 || A[i] > 1000) continue;
            var second = i - 1;
            var third = i - 2;
            var sum = Math.Abs(A[i] * A[second] * A[third]);
            results.Add(counter, sum);
            counter++;
        }
        
        int largestValue = results.Values.Max();
        return largestValue;
    }
}