using System.Text;

namespace CodilityTasks.RandomTaskInternet;

public class MaxInsertToObtainString
{ 
    public int Solution(string S)
    {
        int countA = 0;
        int insertA = 0;
        int maxLength = 2;  // Maximum consecutive 'a' allowed

        foreach (char c in S)
        {
            if (c == 'a')
            {
                countA++;
                if (countA > maxLength)
                    return -1;  // Found 'aaa', return -1
            }
            else
            {
                insertA += maxLength - countA;  // Accumulate additional 'a' insertions
                countA = 0;  // Reset count
            }
        }

        // Check for remaining 'a' insertions at the end of the string
        insertA += maxLength - countA;

        return insertA;
    }

}