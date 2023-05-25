namespace CodilityTasks.Search;

public static class BinarySearch
{
    public static int SearchRecursive(int[] array, int target)
    {
        return SearchRecursive(array, target, 0, array.Length - 1);
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

    public static int SearchIteration(int[] array, int target)
    {
        int left = 0;
        int right = array.Length - 1;
        
        while (left <= right)
        {
           var middle = (left + right) / 2;

           if (array[middle] == target)
               return middle;
           if (target < array[middle])
               right = middle - 1;
           else
               left = middle + 1;
        }

        return -1;
    }

}