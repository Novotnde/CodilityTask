namespace CodilityTasks.Sorting;

public class SelectionSort
{
    public int[] Sort(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i; j < array.Length; j++)
            {   var minIndex = i;
                if (array[j] < array[minIndex])
                {
                    minIndex = j;
                   swap(array,minIndex,i);
                }
            }
        }

        return array;
    }

    private void swap(int[] array, int index1, int index2)
    {
        var temp = array[index1];
        array[index1] = array[index2];
        array[index2] = temp;
    }
}