namespace CodilityTasks.RandomTaskInternet;

public class BalancedString
{
    // You are given a string of char an and b You can delete any number of characters to make it balanced, return the min number of deletion.
    // S is balanced if there is no pair of indices (i,j) such that I< j and s[i] = b and s[j] = a

    public int GetBalancedString(string unbalanced)
    {
        var charCount = 0;
        var stack = new Stack<char>();

        foreach (var c in unbalanced.ToLower())
        {
            if (c == 'a')
            {
                if (stack.Count > 0 && stack.Peek() == 'b')
                {
                    stack.Pop();
                    charCount++;
                }
                else
                {
                    stack.Push(c);
                }
            }
            else if (c == 'b')
            {
                stack.Push(c);
            }
        }

        return charCount;
    }
}