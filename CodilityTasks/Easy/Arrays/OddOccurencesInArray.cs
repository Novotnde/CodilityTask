namespace CodilityTasks.Easy.Arrays;

public class OddOccurencesInArray
{
    // Find value that occurs in odd number of elements. 
    
    //80 Correct a perf 50
    public int solution(int[] A)
    {
        if (A.Length == 0) return 0;
        var dictionary = new Dictionary<int,int>();
        for (var i = 0; i < A.Length; i++)
        {
            var num = A[i];
            if (dictionary.ContainsKey(num))
            {
                dictionary[num]++;
            }
            else
            {
                dictionary.Add(num,1);
            }
        }
        var odd = dictionary.FirstOrDefault(x => x.Value == 1);
        return odd.Key;
    }

    // 80 correct 25 perf
    public int solutionFirstButSlow(int[] A)
    {
        if (A.Length <= 0) return 0;
        foreach (var t in A)
        {
            int count = A.Count(a => a == t);
            if (count < 2) return t;
        }

        return 0;
    }
}