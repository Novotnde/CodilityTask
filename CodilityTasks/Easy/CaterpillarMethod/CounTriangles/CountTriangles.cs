namespace CodilityTasks.Easy.CaterpillarMethod.CounTriangles;

public class CountTriangles
{
    // Count the number of triangles that can be built from a given set of edges. 
    public int solution(int[] A)
    {
        var counter = 0;
        if (A.Length < 3)
        {
            return 0;
        }
        Array.Sort(A);
        for (var back = 0; back < A.Length - 2; back++)
        {
            var front = back+ 2;

            for (var middle = back + 1; middle < A.Length - 1; middle++)
            {
                while (front < A.Length && A[back] + A[middle] > A[front])
                {
                    front++;
                }

                counter += front - middle - 1;
            }
        }
        return counter;
    }

}