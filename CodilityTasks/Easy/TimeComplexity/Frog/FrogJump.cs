namespace CodilityTasks.Easy.TimeComplexity;

public class FrogJump
{
    // Count minimal number of jumps from position X to Y. 
    //Frog must jump on all of the lists

    //100
    public int solution(int X, int Y, int D)
    {
        var distance = D;
        var position = X;
        var destination = Y;
        //how far do i need to go
        var difference = destination - position;
        if (difference <= 0)
        {
            return 0;
        }
        if (difference <= distance)
        {
            return 1;
        }

        var jumps = difference / distance;
        var remainingDistanceToJump = difference % distance;
        if (remainingDistanceToJump > 0)
        {
            remainingDistanceToJump = 1;
        }
        else
        {
            remainingDistanceToJump = 0;
        }

        var result = jumps + remainingDistanceToJump;
        return result;
    }
    
    //100 correct 0 perf
    public int solutionTooSlow(int X, int Y, int D)
    {
        var distance = D;
        var position = X;
        var destination = Y;
        var counter = 0;
        while (position < destination)
        {
            counter++;
            position += distance;
        }

        return counter;
    }
}