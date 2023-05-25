namespace CodilityTasks.RandomTaskInternet;

public class Palindrome
{
    //A palindrome is a string of letters that is equal to itself when reversed.Given an input string, not necessarily a palindrome,
    // compute the number of times you need to swap to transform the string into a palindrome. By swap we mean reversing the order of teo adjacent symbols.

    public int GetNumberOfSwaps(string mixed)
    {
        var swap = 0;
        var firstPointer = 0;
        var lastPointer = mixed.Length - 1;

        while (firstPointer < lastPointer)
        {
            if (mixed[firstPointer] == mixed[lastPointer])
            {
                firstPointer++;
                lastPointer--;
                swap++;
            }
            else
            {
                var currentLast = lastPointer;
                while (currentLast > firstPointer)
                {
                    if (mixed[firstPointer] == mixed[currentLast])
                    {
                        firstPointer++;
                        lastPointer--;
                        break; // Found a match, no need to continue the loop
                    }
                    swap++;
                    currentLast--;
                }
            }
        }
        return swap;
    }



}