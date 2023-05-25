namespace CodilityTasks.Sorting;

public class BubbleSort
{
    public int[] Bubble(int[] array)
    {
        bool isSorted;
        for (int i = 0; i < array.Length; i++)
        {
            isSorted = true;
            for (int j = 1; j < array.Length - i; j++)
            {
                if (array[j] < array[j - 1])
                {
                    var temp = array[j];
                    array[j] = array[j - 1];
                    array[j - 1] = temp;
                    isSorted = false;
                }

                if (isSorted)
                {
                    return array;
                }
            }
        }
        return array;
    }
}