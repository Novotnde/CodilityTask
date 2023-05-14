namespace CodilityTasks.Easy.TimeComplexity.PermMissingElement;

public class PermMissingElement
{
    //Find the missing element in a given permutation.
    //100 correct 100 perf / way too long to solve
    public int solution(int[] A)
    {
        if (A.Length == 0 || A.Length == 1 && A[0] > 1)
        {
            return 1;
        }

        if (A.Length == 1 && A[0] == 1)
        {
            return 2;
        }
        Array.Sort(A);
        var counter = 1;
        for (int i = 0; i < A.Length; i++)
        {
            var num = A[i] ;
            if (counter == num)
            {
                counter++;
            }
        }
        return counter;
    }

    //20 correct 0 perg
    public int solutionBadVeryBad(int[] A)
    {
        if (A.Length == 0)
        {
            return 1;
        }
        if (A.Length == 1)
        {
            if (A[0] > 1)
            {
                return A[0] += 1;
            }
            return 1;
        }
       
        foreach (var t in A)
        {
            var number = t + 1;
            if (!A.Contains(number))
            {
                return number;
            }
        }

        return 0;
    }
}