namespace CodilityTasks.RandomTaskInternet;

public class FairIndex
{
    public int GetFairIndex(int[] A, int[] B)
    {
        var length = A.Length;
        int sumA = 0;
        long sumB = 0;

        for (var i = 0; i < length; i++)
        {
            sumA += A[i];
            sumB += B[i];
        }

        if (sumA != sumB)
        {
            return 0;
        }

        long preA = 0;
        long preB = 0;
        int answer = 0;

        for (int i = 0; i < length - 1; i++)
        {
            preA += A[i];
            preB += B[i];

            if (preA == preB && sumA - preA == preA)
            {
                answer += 1;
            }
        }

        return answer;
    }

}