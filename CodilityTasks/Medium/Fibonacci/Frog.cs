namespace CodilityTasks.Medium.Fibonacci;

public class Frog
{
    public int solution(int[] A)
    {
        var N = A.Length;
        var fib = GenerateFibonacci(N + 1); // 
        var minJumps = new int[N + 2]; // Array to store the minimum number of jumps
        Array.Fill(minJumps, Int32.MaxValue); // Initialize all elements with a large value

        minJumps[0] = 0; // Starting bank
        minJumps[N + 1] = -1; // Other bank (not reachable yet)

        for (int i = 1; i <= N - 1; i++) {
            if (A[i - 1] == 1) { // Leaf position
                for (int j = fib.Length - 1; j >= 2; j--) {
                    int jumpPosition = i - fib[j];
                    if (jumpPosition == -1) {
                        minJumps[i] = 1;
                        break;
                    } else if (jumpPosition > -1) {
                        minJumps[i] = Math.Min(minJumps[i], minJumps[jumpPosition] + 1);
                    }
                }
            }
        }

        return minJumps[N + 1];

    }
    
    private int[] GenerateFibonacci(int limit) {
        var fib = new int[limit];
        fib[0] = 0;
        fib[1] = 1;
        for (var i = 2; i < limit; i++) {
            fib[i] = fib[i - 1] + fib[i - 2];
        }
        return fib;
    }
}