namespace CodilityTasks.RandomTaskInternet;

public class UniqueCharacters
{
    public int MaxConcatenatedLength(string[] arr)
    {
        List<string> subsequences = new List<string> { "" };

        foreach (string s in arr)
        {
            List<string> newSubsequences = new List<string>();

            foreach (string sub in subsequences)
            {
                string newSubsequence = s + sub;

                if (IsUnique(newSubsequence))
                {
                    newSubsequences.Add(newSubsequence);
                }
            }

            subsequences.AddRange(newSubsequences);
        }

        int maxLength = 0;
        foreach (string subsequence in subsequences)
        {
            maxLength = Math.Max(maxLength, subsequence.Length);
        }

        return maxLength;
    }

    private bool IsUnique(string s)
    {
        HashSet<char> chars = new HashSet<char>();

        foreach (char c in s)
        {
            if (chars.Contains(c))
            {
                return false;
            }

            chars.Add(c);
        }

        return true;
    }
}