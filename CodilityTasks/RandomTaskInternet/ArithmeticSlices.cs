namespace CodilityTasks.RandomTaskInternet;

public class ArithmeticSlices
{
    public int GetNumberOfSubArrays(int[] nums)
    {
        var count = 0;
        var current = 0;

        for (int i = 2; i < nums.Length; i++)
        {
            if (nums[i] - nums[i - 1] == nums[i - 1] - nums[i - 2])
            {
                current += 1;
                count += current;
            }
            else
            {
                current = 0;
            }
        } 
        return count;
    }
}