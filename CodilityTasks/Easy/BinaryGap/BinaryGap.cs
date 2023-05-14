namespace CodilityTasks.Easy.BinaryGap;


public class BinaryGap
{
    //100% correct, Performance not shown 
    public int Solution(int N)
    {
        var binaryGap = 0;
        var counter = 0;
        var list = new List<int>();
        var binaryNumber = Convert.ToString(N, 2);
        if (!string.IsNullOrWhiteSpace(binaryNumber))
        {
            for (var i = 0; i < binaryNumber.Length; i++)
            {
                if (binaryNumber[i] == '0')
                {
                    counter++;
                }
                else
                {
                    binaryGap += counter;
                    counter = 0;
                    list.Add(binaryGap);
                    binaryGap = 0;
                }
            }

            var maxNum = int.MinValue;
            foreach (var num in list)
            {
                if (num > maxNum)
                {
                    maxNum = num;
                }
            }

            return maxNum;
        }
        return 0;
    }
}