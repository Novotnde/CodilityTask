namespace CodilityTasks.Medium.CountingElements.MissingInteger;

public class MissinInteger
{
    // Find the smallest positive integer that does not occur in a given sequence. 
    // 60 correct a 50 perf.. 
    public int solution(int[] A)
    {
        Array.Sort(A);
        var counter = 1;
        var uniqueNumbers = new HashSet<int>();
        foreach (var num in A)
        {
            if (Math.Sign(num) != 1)
            {
                return 1;
            }
            uniqueNumbers.Add(num);
        }
        while (uniqueNumbers.Contains(counter))
        {
            counter++;
        }
        return counter;
    }
    // 60 correct a 50 perf.. 
    public int solutionOK(int[] A)
    {
        var distinctArray = A.Distinct();
        var counter = 1;
        var enumerable = distinctArray as int[] ?? distinctArray.ToArray();
        Array.Sort(enumerable);

        for (int i = 0; i < enumerable.Count(); i++)
        {
            var num = enumerable[i];
            if (Math.Sign(num) != 1)
            {
                return 1;
            }

            if (counter == num)
            {
                counter++;
            }
        }

        return counter;
    }
    
}