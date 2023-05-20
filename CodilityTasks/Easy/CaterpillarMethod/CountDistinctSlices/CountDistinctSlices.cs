namespace CodilityTasks.Easy.CaterpillarMethod.CountDistinctSlices;

public class CountDistinctSlices
{
    public int solution(int M, int[] A)
    {
        int distinctCount = 0;
        int front = 0;
        int back = 0;
        var count = new int[M + 1];

        while (front < A.Length && back < A.Length)
        {
            while (front < A.Length && count[A[front]] == 0)
            {
                count[A[front]]++; 
                distinctCount += (front - back + 1);
                front++;
            
                if (distinctCount > 1_000_000_000)
                    return 1_000_000_000;
            }
        
            count[A[back]]--;
            back++;
        }
    
        return distinctCount;
    }
}