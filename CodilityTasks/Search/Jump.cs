namespace CodilityTasks.Search;

public static class Jump
{
    public static int SearchJump(int[] array, int target)
    {
        var blockSize = (int)Math.Sqrt(array.Length);
        int start = 0;
        int next = blockSize;

        while (array[next -1]<target)
        {
            start = next;
            next += blockSize;
            if (next > array.Length)
                next = array.Length;
        }

        for (int i = start; i < next; i++)
        {
            if (array[i] == target)
                return i;
        }

        return -1;
    }

}