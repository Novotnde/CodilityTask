namespace CodilityTasks.Medium.Sieve;

public class NonDIvisible
{
    public int[] solution(int[] A)
    {
        var primeFactors = new List<int>();
        var i = 0;
        while (A[i] > 0)
        {
            primeFactors.Add(A[i]);
        }

        return A;
    }
      
}