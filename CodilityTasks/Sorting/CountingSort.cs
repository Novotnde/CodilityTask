namespace CodilityTasks.Sorting;

public class CountingSort
{
    public void sort(int[] array, int max)
    {
        var counts = new int[max + 1];
        foreach (var item in array)
        {
            counts[item]++;
        }

        var k = 0;
        for (var i = 0; i < counts.Length; i++)
        {
            for (var j = 0; j < counts[i]; j++)
            {
                array[k++] = i;
            }
        }
    }
}