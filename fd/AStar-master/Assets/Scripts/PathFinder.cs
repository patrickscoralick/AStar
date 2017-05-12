using System.Collections.Generic;
using UnityEngine;


public class PathFinder
{

    public static List<Grid.Position> FindPath(Tile[,] tiles, Grid.Position fromPosition, Grid.Position toPosition)
    {
        int x = fromPosition.x;
        int y = fromPosition.y;
        int i;
        var path = new List<Grid.Position>();
        var middlePosition = new Grid.Position();  

        path.Add(fromPosition);
        path.Add(middlePosition);
        path.Add(toPosition);

        for ( i = 0; i <= x; i++ )
        {
            middlePosition.x = fromPosition.x + i;
           // Debug.Log("Valor do i " + i);
            if(i == x) { i = 0; }
        }

        for (i = 0; i <= y; i++)
        {
            middlePosition.y = fromPosition.y + i;
            if (i == y) { i = 0; }
        }

        Debug.Log("Posição inicial: " + fromPosition);
        Debug.Log("Posição final: " + toPosition);
        Debug.Log("Posição do meio: " + middlePosition);

        return path;

    }
}
