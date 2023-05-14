namespace CodilityTasks.Easy.Sorting.Triangle;

public class Triangle
{
    //Determine whether a triangle can be built from a given set of edges. 

    //90 correct and 100 Perf
    public int solution(int[] A)
    {
        if (A.Length < 3) {
            return 0;
        }       
        Array.Sort(A);
        for (var i = 0; i< A.Length -2; i++)
        {
            var a = A[i];
            var b = A[i + 1];
            var c = A[i + 2];
            var sum = a + b;
            if (sum > c)
            {
                return 1;
            }
        }

        return 0;
    }
}