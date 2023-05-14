namespace CodilityTasks.Easy.StacksAndQueues;

public class Brackets
{
    // Determine whether a given string of parentheses (multiple types) is properly nested. 
    //For example, the string "{[()()]}" is properly nested but "([)()]" is not.

   // correct  
    public int solution(String S)
    {
        var stack = new Stack<char>();
        var pairs = new Dictionary<char, char>() {
            { '(', ')' },
            { '{', '}' },
            { '[', ']' }
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
        return pairs.Count(x => S.Contains("" + x.Key + x.Value));
    }

    public int solutionw(String S)
    {
        if (!S.All(c => c == '(' || c == ')' || c == '{' || c == '}' || c == '[' || c == ']'))
        {
            return 0;
        }
        
        var curlyRight = 0;
        var curlyLeft = 0;
        var squareRight = 0;
        var squareLeft = 0;
        var simpleRight = 0;
        var simpleLeft = 0;

        foreach (var s in S)
        {
            switch(s) 
            {
                case '(':
                    simpleLeft++;
                    break;
                case ')':
                    simpleRight++;
                    break;
                case '{':
                    curlyLeft++;
                    break;
                case '}':
                    curlyRight++;
                    break;
                case '[':
                    squareRight++;
                    break;
                case ']':
                    squareLeft++;
                    break;
            }
        }
        if((curlyRight != curlyLeft) || (squareRight != squareLeft)  || (simpleRight  != simpleLeft ))
        {
            return 0;
        } 
        else 
        {
            return 1;
        }
    }
    public int solutionWrong(String S)
    {
        if (!S.All(c => c == '(' || c == ')' || c == '{' || c == '}' || c == '[' || c == ']'))
        {
            return 0;
        }
        
        var right = 0;
        var left = 0;
        foreach (var s in S)
        {
            if (s == '(' || s == '{' || s == '[')
            {
                left++;

            }
            else if (s == ')' || s == '}' || s == ']')
            {
                right++;

            }
        }

        if (left != right)
        {
            return 0;
        }
        return 1;
    }
}