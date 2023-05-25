using System.Collections;

namespace CodilityTasks.RandomTaskInternet;

public class Jump
{
    public bool CanReachZero(int[] arr, int start)
    {
        int n = arr.Length;
        bool[] visited = new bool[n];

        Queue<int> queue = new Queue<int>();
        queue.Enqueue(start);
        visited[start] = true;

        while (queue.Count > 0)
        {
            int currentIndex = queue.Dequeue();

            if (arr[currentIndex] == 0)
            {
                return true;
            }

            int nextIndex1 = currentIndex + arr[currentIndex];
            int nextIndex2 = currentIndex - arr[currentIndex];

            if (nextIndex1 >= 0 && nextIndex1 < n && !visited[nextIndex1])
            {
                queue.Enqueue(nextIndex1);
                visited[nextIndex1] = true;
            }

            if (nextIndex2 >= 0 && nextIndex2 < n && !visited[nextIndex2])
            {
                queue.Enqueue(nextIndex2);
                visited[nextIndex2] = true;
            }
        }

        return false;
    }

}