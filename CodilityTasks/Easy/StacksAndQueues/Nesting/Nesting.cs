namespace CodilityTasks.Easy.StacksAndQueues.Nesting;

public class Nesting
{
    public int solution(String S)
    {
        if (S == "")
        {
            return 1;
        }
        var stack = new Stack<char>();
        var pairs = new Dictionary<char, char>() {
            { '(', ')' },
        };
        
        foreach (char c in S) {
            if (pairs.ContainsKey(c)) {
                stack.Push(c);
            } else if (pairs.ContainsValue(c)) {
                if (stack.Count == 0 || pairs[stack.Pop()] != c) {
                    return 0;
                }
            }
        }
        if (stack.Count > 0) {
            return 0;
        }

        return 1;
    }
}