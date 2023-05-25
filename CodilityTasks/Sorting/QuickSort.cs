namespace CodilityTasks.Sorting;

public class QuickSort
{
    public void sort(int[] array)
    {
        sort(array,0,array.Length);
    }
    private void sort(int[] array, int start, int end)
    {
        if(start >= end) return;
        
        var boundary = partioning(array,start,end);
        sort(array, start,boundary-1);
        sort(array, boundary+1 ,end);

    }

    private int partioning(int[] arr, int start, int end)
    { //get index of pivot after is moved
        var pivot = arr[end];
        var boundry =start -1;

        for (var i = start; i <= end; i++)
        {
            if (arr[i] <= pivot)
            {
                boundry++;
                swap(arr,i, boundry);
            }
        }

        return boundry;
    }
    
    private void swap(int[] array, int index1, int index2)
    {
        var temp = array[index1];
        array[index1] = array[index2];
        array[index2] = temp;
    }

}
