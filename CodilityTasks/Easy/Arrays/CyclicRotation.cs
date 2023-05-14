namespace CodilityTasks.Easy.Arrays;

public class CyclicRotation
{
    //100% correct, Performance not shown 
    public int[] solution(int[] A, int K)
    {
        var length = A.Length;
        var rotatedArray = new int[length];

        for (var i = 0; i < length; i++)
        {
            rotatedArray[(i + K) % length] = A[i];
        }

        return rotatedArray;
    }
}