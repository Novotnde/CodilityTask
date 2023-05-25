using System.Text;

namespace CodilityTasks.RandomTaskInternet;

public class LongestSubstring
{
    //get substring from a string that doesnt cointhat more than two continuous aabb
    
    public string GetSubString(string text)
    {
        var stack = new Stack<char>();
        var result = new StringBuilder();

        foreach (char c in text)
        {
            if (stack.Count >= 2 && stack.Peek() == c && stack.ElementAt(1) == c)
            {
                break;
            }

            stack.Push(c);
        }

        while (stack.Count > 0)
        {
            result.Insert(0, stack.Pop()); // Reconstruct the string in reverse order
        }

        return result.ToString();

    }
    
    public string DeleteThirdOccurrence(string text)
    {
        var stack = new Stack<char>();
        var result = new StringBuilder();

        foreach (char c in text)
        {
            if (stack.Count >= 2 && stack.Peek() == c && stack.ElementAt(1) == c)
            {
                continue; // Skip the third occurrence of the character
            }

            stack.Push(c);
        }

        while (stack.Count > 0)
        {
            result.Insert(0, stack.Pop()); // Reconstruct the string in reverse order
        }

        return result.ToString();
    }

}