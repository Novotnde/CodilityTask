namespace CodilityTasks.Sorting;

public class MergeSort
{
    public void sort(int[] array)
    {
        if (array.Length < 2)
        {
            return;
        }
        // divide this array into half
        var middle = array.Length / 2;

        var left = new int [middle];
        for (var i = 0; i < middle; i++)
        {
            left[i] = array[i];
        }

        var right = new int[array.Length - middle];
        for (int i = middle; i < array.Length; i++)
        {
            right[i - middle] = array[i];
        }
        
        //recursive
        sort(left);
        sort(right);
        merge(left,right,array);
    }

    private void merge(int[] left, int[] right, int[] result)
    {
        int leftIterator = 0;
        int rightIterator = 0;
        int resultIterator = 0;

        while(leftIterator < left.Length && rightIterator < right.Length)
        {
            if (left[leftIterator] <= right[rightIterator])
            {
                result[resultIterator++] = left[leftIterator++];
            }
            else
            {
                result[resultIterator++] = right[rightIterator++];
            }
        }

        while (leftIterator < left.Length)
        {
            result[resultIterator++] = left[leftIterator++];
        }
        while (rightIterator < right.Length)
        {
            result[resultIterator++] = right[rightIterator++];
        }

    }
}