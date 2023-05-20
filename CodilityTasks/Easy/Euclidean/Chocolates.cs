namespace CodilityTasks.Easy.Euclidean;

public class Chocolates
{
    public int solution(int N, int M)
    {
        int gcd = GCD(N, M);
        return N / gcd;
    }
    
    private int GCD(int a, int b) {
        if (b == 0)
            return a;
        else
            return GCD(b, a % b);
    }
}