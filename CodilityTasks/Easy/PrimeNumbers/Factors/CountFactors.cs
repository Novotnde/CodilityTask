namespace CodilityTasks.Easy.PrimeNumbers;

public class CountFactors
{
    public int solution(int N)
    {
        var i = 1;
        var counter = 0;
        while (i * i < N)
        {
            if (N % i == 0)
            {
                counter += 2;
            }
            i += 1;
        }
        if (i * i == N)
        {
            counter +=1;
        }
        return counter;
    }
}