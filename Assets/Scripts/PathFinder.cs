using System.Collections.Generic;
using UnityEngine;


public static class PathFinder
{

    public static List<Grid.Position> FindPath(Tile[,] tiles, Grid.Position fromPosition, Grid.Position toPosition)
    {
        var path = new List<Grid.Position>();
        Queue<Grid.Position> q = new Queue<Grid.Position>();
        q.Enqueue(fromPosition);
        Grid.Position[,] caminho = new Grid.Position[tiles.GetLength(0),tiles.GetLength(1)];

        var p = q.Dequeue();

        while (p.x != toPosition.x || p.y != toPosition.y)
        {
            if (p.x == toPosition.x && p.y == toPosition.y)
            {
                Debug.Log("Achei");
                break;
            }
            else
            {
                if (p.x != toPosition.x)
                {
                    if (p.x < toPosition.x)
                        p.x++;
                    else
                        p.x--;
                }
                if (p.y != toPosition.y)
                {
                    if (p.y < toPosition.y)
                        p.y++;
                    else
                        p.y--;
                }
                path.Add(p);
            }
        }
        return path;
    }
}
