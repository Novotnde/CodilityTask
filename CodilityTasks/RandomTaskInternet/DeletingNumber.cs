namespace CodilityTasks.RandomTaskInternet;

public class DeletingNumber
{
    public int solution(int number)
    {
        var result = 0;
        var found = false;
        var factor = 1;
        
        while (number > 0)
        {
            var digit =number % 10;
            number /= 10;

            if (digit == 5  && !found)
            {
                found = true;
            }
            else
            {
                result += digit * factor;
                factor *= 10;
            }
        }

        return result;
    }
}