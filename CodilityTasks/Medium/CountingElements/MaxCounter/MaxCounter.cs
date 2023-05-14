namespace CodilityTasks.Medium.CountingElements.MaxCounter;

public class MaxCounter
{
    public int[] solution(int N, int[] A)
    {
        var maxCounterArray = new int[N];
        var maxDictionary = new Dictionary<int, int>();
        var counter = 0;
        for (var i = 0; i < A.Length; i++)
        {
            var num = A[i] -1;
            if ((num + 1) == N)
            {
                maxCounterArray[num]++;
            }
            else
            {
               var max=  maxCounterArray.Max();
               maxDictionary.Add(i,max);
               counter++;
            }
        }

        var index = maxDictionary.Keys.FirstOrDefault();
        var val = maxDictionary.Values.FirstOrDefault();
        for (int i = 0; i < maxCounterArray.Length; i++)
        {
            if (i != index)
            {
                if (maxCounterArray[i] != 0)
                {
                    var diff = val - maxCounterArray[i];
                    maxCounterArray[i] += diff;
                }
                
                else
                {
                    maxCounterArray[i] += val;
                }
            }
        }

        return maxCounterArray;
    }
}