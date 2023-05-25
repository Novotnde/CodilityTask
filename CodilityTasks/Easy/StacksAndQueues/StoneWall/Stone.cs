namespace CodilityTasks.Easy.StacksAndQueues.StoneWall;

public class Stone
{
public int solution(int[] H) {
    var stack = new Stack<int>();
    int counter = 0;

    foreach (var t in H)
    {
        while (stack.Count > 0 && t < stack.Peek()) {
            stack.Pop();
        }

        if (stack.Count != 0 && t <= stack.Peek()) continue;
        stack.Push(t);
        counter++;
    }

    return counter;
}
}