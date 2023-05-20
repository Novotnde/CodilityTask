using System.ComponentModel.Design;

namespace CodilityTasks.Easy.MaxProfit;

public class MaxSlice
{
    public int solution(int[] A) {
        int maxEndingHere = A[0];
        int maxSlice = A[0];

        for (int i = 1; i < A.Length; i++) {
            maxEndingHere = Math.Max(A[i], A[i] + maxEndingHere);
            maxSlice = Math.Max(maxSlice, maxEndingHere);
        }

        return maxSlice;
    }
}