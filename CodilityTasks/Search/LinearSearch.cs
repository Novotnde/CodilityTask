namespace CodilityTasks.Search;

public class LinearSearch
{
    public int linearSearch(int[]array, int target)
    {
        for (var i = 0; i < array.Length; i++)
        {
            if (array[i] == target)
            {
                return i;
            }
        }
        return -1;
    }
}