using System.Timers;

namespace CodilityTasks.Easy.StacksAndQueues.Fish;

public class Fish
{
    // N voracious fish are moving along a river. Calculate how many fish are alive. 
    public int solution(int[] A, int[] B)
    {
        if (A.Distinct().Count() == A.Length && (B.Any(b => b != 0 && b != 1))) return 0;
        var downStream = new Stack<int>();        
        var eaten = 0;
        for (int i = 0; i < B.Length; i++)
        {
            if (B[i] == 1)
            {
                downStream.Push(A[i]);
            }
            else
            {
                while (downStream.Any())
                {
                    if (downStream.Peek() > A[i])
                    {
                        eaten++;
                        break;
                    }
                    else if(downStream.Peek() < A[i])
                    {
                        eaten++;
                        downStream.Pop();
                    }
                }
            }
        }
        
        var alive = B.Length - eaten;
        return alive;
    }
}