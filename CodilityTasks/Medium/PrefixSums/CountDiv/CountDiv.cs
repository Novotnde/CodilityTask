namespace CodilityTasks.Medium.PrefixSums.CountDiv;

public class CountDiv
{
    // Compute number of integers divisible by k in range [a..b]. 

    public int solution(int A, int B, int K)
    {
        if (A > 2000000000 || 
            B > 2000000000 ||
            K > 2000000000 || 
            A < 0 
            || B < 0 
            || K < 1) 
        {
            return -1;
        }
        
        int start = A % K == 0 ? A : A + (K - (A % K));
        int end = B - (B % K);
    
        if (start > B) {
            return 0;
        }
        return (end - start) / K + 1;
    }
}