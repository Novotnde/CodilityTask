namespace CodilityTasks.RandomTaskInternet;

public class LexicographicallySmallestString
{
    //LexicographicallySmallestString formed by removing one char
    public string RemoveCharacter(string text)
    {
        string smallestString = text;

        for (int i = 0; i < text.Length; i++)
        {
            string removed = text.Remove(i, 1);
            if (removed.CompareTo(smallestString) < 0)
            {
                smallestString = removed;
            }
        }

        return smallestString;
    }

}