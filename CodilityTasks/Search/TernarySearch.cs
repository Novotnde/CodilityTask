namespace CodilityTasks.Search;

public static class TernarySearch
{
    public static int ternarySearch(int[] arr, int target)
    {
        return ternarySearch(arr, target, 0, arr.Length -1);

    }

    private static int ternarySearch(int[] arr, int target, int left, int right)
    {
        if (left > right) return -1;
        var partitionSize = (right - left) / 3;
        int mid1 = left + partitionSize;
        int mid2 = right - partitionSize;

        if (arr[mid1] == target)
        {
            return mid1;
        }

        if (arr[mid2] == target)
        {
            return mid2;
        }

        if (target < arr[mid1])
        {
            return ternarySearch(arr, target, left, mid1- 1);
        }
        
        if (target > arr[mid2])
        {
            return ternarySearch(arr, target, mid2+1 , right);
        }
        return ternarySearch(arr, target, mid1+1 , mid2 -1);
    }
}