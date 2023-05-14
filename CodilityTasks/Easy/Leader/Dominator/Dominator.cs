namespace CodilityTasks.Easy.Leader.Dominator;

public class Dominator
{
    public int solution(int[] A)    
    {
        if (A.Length == 0) return -1;
        var dictionary = new Dictionary<int,int>();
        for (var i = 0; i < A.Length; i++)
        {
            var num = A[i];
            if (dictionary.ContainsKey(num))
            {
                dictionary[num]++;
            }
            else
            {
                dictionary.Add(num,1);
            }
        }

        var highest = dictionary.Values.Max();
        if (highest > A.Length / 2) {
            var mostOccured = dictionary.FirstOrDefault(x => x.Value == highest).Key;
            var index = Array.IndexOf(A, mostOccured);
            return index;
        } else {
            return -1; 
        }
        
    }
}