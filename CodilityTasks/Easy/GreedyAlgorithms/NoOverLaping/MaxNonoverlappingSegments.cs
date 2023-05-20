namespace CodilityTasks.Easy.GreedyAlgorithms;

public class MaxNonoverlappingSegments
{
    public int solution(int[] A, int[] B)
    {
        if (A.Length > 0 && B.Length > 0)
        {
            Array.Sort(A);
            Array.Sort(B);

            var counter = 1;
            var b = B[0];
            for (var index = 0; index < A.Length; index++)
            {
                var a = A[index];
                if(a > 1000000000 || b > 1000000000)
                {
                    return 0;
                }
                if (a > b)
                {
                    counter++;
                    b = B[index];
                }
            }

            return counter;
        }

        return 0;
    }
}