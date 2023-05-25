
namespace CodilityTasks.RandomTaskInternet;

public class Trees
{
    public int solution(int[] X, int[] Y)
    {

        var treeCoordinatesX = new List<int>();
        var treeCoordinatesY = new List<int>();

        foreach (var treeCoordinateX in X)
        {
            treeCoordinatesX.Add(treeCoordinateX);
        }

        foreach (var treeCoordinateY in Y)
        {
            treeCoordinatesY.Add(treeCoordinateY);
        }
        
        treeCoordinatesX.Sort();
        treeCoordinatesY.Sort();
        var maxWidthX = 0;
        var maxWidthY = 0;
        var maxWidtTotal = 0;

        for (var i = 1; i < treeCoordinatesX.Count; i++)
        {
            var j = treeCoordinatesX[i] - treeCoordinatesX[i - 1] ;
            maxWidthX = j >= maxWidthX ? j : maxWidthX;
        }
        
        for (var i = 1; i < treeCoordinatesY.Count; i++)
        {
            var j = treeCoordinatesY[i] - treeCoordinatesY[i - 1] ;
            maxWidthY = j >= maxWidthY ? j : maxWidthY;
        }
        maxWidtTotal = maxWidthX >= maxWidthY ? maxWidthX : maxWidthY;      

        return maxWidtTotal;
    }
    
}