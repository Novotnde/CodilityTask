namespace CodilityTasks.Search;

public static class Exponential
{
    public static int ExponentialSearch(int []arr, int target)
    {
        int bound = 1;
        while (bound < arr.Length && arr[bound] < target)
            bound *= 2;
        int left = bound / 2;
        int right = Math.Min(bound, arr.Length - 1);
        return SearchRecursive(arr, target, left, right);
    }
    
    private static int SearchRecursive(int[] array, int target, int left, int right)
    {
        if (right < left) return -1;
        var middle = (left + right) / 2;
        if (array[middle] == target)
        {
            return target;
        }

        if (target < array[middle])
        {
            return SearchRecursive(array, target, left, middle - 1);
        }

        return SearchRecursive(array, target, middle + 1, right);
    }

}