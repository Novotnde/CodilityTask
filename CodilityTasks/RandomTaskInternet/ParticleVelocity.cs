namespace CodilityTasks.RandomTaskInternet;

public class ParticleVelocity
{
    public int CountStablePeriods(int[] particles)
    {
        int count = 0;

        for (int i = 1; i < particles.Length - 1; i++)
        {
            int diff = particles[i] - particles[i - 1];
            int stablePeriodCount = 0;

            for (int j = i + 1; j < particles.Length; j++)
            {
                int currentDiff = particles[j] - particles[j - 1];

                if (currentDiff == diff)
                {
                    stablePeriodCount++;
                }
                else
                {
                    break;
                }
            }

            count += stablePeriodCount;
        }

        return count;
    }

}