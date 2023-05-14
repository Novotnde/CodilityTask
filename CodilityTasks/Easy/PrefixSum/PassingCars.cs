namespace CodilityTasks.Easy.PrefixSum;

public class PassingCars
{
    //Count the number of passing cars on the road. 
    //100
    public int solution(int[] A)
    {
        var east = 0;
        var passed = 0; 
        foreach (var car in A)
        {
            if (car == 0) {
                east++;
            }
            else {
                passed += east;
                if (passed > 1000000000) {
                    return -1;
                }
            }
        }
    
        return passed;
    }
}