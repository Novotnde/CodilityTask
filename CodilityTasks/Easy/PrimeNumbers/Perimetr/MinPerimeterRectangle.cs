namespace CodilityTasks.Easy.PrimeNumbers;

public class MinPerimeterRectangle
{
// Find the minimal perimeter of any rectangle whose area equals N. 
    public int solution(int N)
    {
        if (N >= 1 && N < 1000000000)
        {
            var i = 1;
            var list = new Dictionary<int,int>();
            var results = new HashSet<int>();
            while (i <= N)
            {
                if (N % i == 0)
                {
                    var num = N / i;
                    list.Add(i,num);
                }
                i++;
            }

            foreach (var per in list)
            {
                var res = 2 * (per.Key + per.Value);
                results.Add(res);
            }

            return results.Min();
        }

        return 0;
    }

}