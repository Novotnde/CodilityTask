namespace CodilityTasks.Easy.GreedyAlgorithms.Ropes;

public class Ropes
{
    // Tie adjacent ropes to achieve the maximum number of ropes of length >= K. 
    public int solution(int K, int[] A) {
        int totalRopes = 0;
        int maxRopes = 0;
        int currentLength = 0;

        for (int i = 0; i < A.Length; i++) {
            currentLength += A[i];

            if (currentLength >= K) {
                totalRopes++;
                if (totalRopes > maxRopes) {
                    maxRopes = totalRopes;
                }
                currentLength = 0;
            }
        }

        return maxRopes;
    }

}