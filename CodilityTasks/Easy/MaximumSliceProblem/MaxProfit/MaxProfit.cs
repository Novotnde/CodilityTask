namespace CodilityTasks.Easy.MaxProfit;

public class MaxProfit
{
    public int solution(int[] A)
    {
        if (A.Length > 0 && A.Length < 400000)
        {
            int minPrice = A[0];
            int maxProfit = 0;
            for (int i = 1; i < A.Length; i++) {
                int currentPrice = A[i];
                int currentProfit = currentPrice - minPrice;

                if (currentProfit > maxProfit) {
                    maxProfit = currentProfit;
                }

                if (currentPrice < minPrice) {
                    minPrice = currentPrice;
                }
            }
            if (maxProfit < 0)
            {
                return 0;
            }
            return maxProfit;
        }
        return 0;
    }
}